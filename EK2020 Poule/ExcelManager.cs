using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;

namespace EK2020_Poule
{
    public class ExcelReadSettings
    {
        //Group Phase
        public int GroupStartRow = 15;
        public int GroupSize = 6;
        public int TotalGroups = 6;
        public int CurrentGroup = 0;
        public int GroupHomeColumn = 8;
        public int GroupOutColumn = 9;

        //KO Phase
        public int KOColumn = 10;
        public int KOStart = 66;
        public int KOSize = 8;
        public int Phases = 4;

        public int Miss = 0;

        public ExcelReadSettings(int miss = 0)
        {
            GroupStartRow += miss;
        }
    }

    public class ExcelManager
    {
        excel.Application xlApp;
        excel.Workbook xlWorkbook;
        excel._Worksheet xlWorksheet;
        excel.Range xlRange;
        private void Initialise(string filename, int sheet)
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException();

            xlApp = new excel.Application();
            xlWorkbook = xlApp.Workbooks.Open(filename);
            xlWorksheet = xlWorkbook.Sheets[sheet];
            xlRange = xlWorksheet.UsedRange;
        }

        public IEnumerable<int> ExportPlayersToExcel(string filename, int sheet, List<Player> Players)
        {
            Initialise(filename, sheet);
            int y = 2;
            foreach (Player player in Players)
            {
                xlRange.Cells[y, 1].value2 = player.Ranking;
                y++;
                yield return y;
            }
            Clean();
        }

        public PoolMatchResult[] ReadGroupPhase(string filename, int sheet, ExcelReadSettings Settings)
        {
            Initialise(filename, sheet);
            List<PoolMatchResult> res = new List<PoolMatchResult>();

            int Groupschecked = 0;
            while (Groupschecked < Settings.TotalGroups)
            {
                int rowschecked = 0;
                while (rowschecked < Settings.GroupSize)
                {
                    double x = 99;
                    double y = 99;
                    int currentRow = Settings.GroupStartRow + rowschecked;

                    if (xlRange.Cells[currentRow, Settings.GroupHomeColumn].Value2 != null && xlRange.Cells[currentRow, Settings.GroupOutColumn].Value2 != null)
                    {
                        x = xlRange.Cells[currentRow, Settings.GroupHomeColumn].Value2;
                        y = xlRange.Cells[currentRow, Settings.GroupOutColumn].Value2;
                    }
                    PoolMatchResult pmr = new PoolMatchResult(Convert.ToInt32(x), Convert.ToInt32(y));
                    res.Add(pmr);
                    rowschecked++;
                }
                Settings.GroupStartRow += Settings.GroupSize + 1;
                Groupschecked++;
            }
            Clean();
            return res.ToArray();
        }

        public KnockOutPhase readKnockout(string filename, int sheet, ExcelReadSettings settings)
        {
            Initialise(filename, sheet);
            KnockOutPhase ko = new KnockOutPhase();
            int phase = 0;
            while (phase < settings.Phases)
            {
                int line = 0;
                while (line < settings.KOSize)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int row = line + settings.KOStart;
                        string team = xlRange.Cells[row, settings.KOColumn + i].value2;
                        if (team != null)
                        {
                            ko.Stages.ElementAt(phase).Value.teams.Add(team.ToLower());
                        }
                    }
                    line++;
                }
                settings.KOStart += settings.KOSize + 3;
                settings.KOSize /= 2;
                phase++;
            }
            Clean();
            return ko;
        }

        public BonusQuestions readBonus(string filename, int sheet)
        {
            Initialise(filename, sheet);
            BonusQuestions b = new BonusQuestions(xlRange.Cells[94, 5].value2.ToLower(), xlRange.Cells[95, 5].value2.ToLower(), xlRange.Cells[96, 5].value2.ToLower());
            Clean();
            return b;            
        }
        public void Clean()
        {
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}

