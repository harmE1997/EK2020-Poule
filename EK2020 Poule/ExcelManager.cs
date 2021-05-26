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
    public class Phase
    {
        public int column;
        public int startrow;
        public int gapsize;
        public int size;
    }

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
        public Phase[] phases;
        public int Miss = 0;

        public ExcelReadSettings(int miss = 0)
        {
            GroupStartRow += miss;
            phases = new Phase[4]
            {
                new Phase() { column = 4, startrow = 68, gapsize = 2, size = 16},
                new Phase() { column = 6, startrow = 69, gapsize = 4, size = 8},
                new Phase() { column = 8, startrow = 71, gapsize = 8, size = 4 },
                new Phase() { column = 11, startrow = 74, gapsize = 16, size = 2}
            };
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
            int p = 0;
            foreach (var phase in settings.phases)
            {
                for (int i = 0; i < phase.size; i++)
                {
                    int row = phase.startrow + (phase.gapsize * i);
                    if (i >= phase.size / 2)
                        row++;
                    string team = xlRange.Cells[row, phase.column].value2;
                    if (team == null)
                    {
                        team = "";
                    }
                    ko.Stages.ElementAt(p).Value.teams.Add(team.ToLower());
                }
                p++;
            }
            Clean();
            return ko;
        }

        public BonusQuestions readBonus(string filename, int sheet)
        {
            Initialise(filename, sheet);
            string kampioen = xlRange.Cells[103, 5].value2;
            string topscorer = xlRange.Cells[104, 5].value2;;
            string nl = xlRange.Cells[105, 5].value2;
            if (kampioen == null)
            {
                kampioen = "";
            }

            if (topscorer == null)
            {
                topscorer = "";
            }

            if (nl == null)
            {
                nl = "";
            }
            BonusQuestions b = new BonusQuestions(kampioen.ToLower(), topscorer.ToLower(), nl.ToLower());
            Clean();
            return b;
        }

        public List<goalScorer> readGoalScorers(string filename, int sheet)
        {
            List<goalScorer> scorers = new List<goalScorer>();
            Initialise(filename, sheet);
            int i = 2;
            while (true)
            {
                if (xlRange.Cells[i,1].value2 == null)
                {
                    break;
                }
                goalScorer s = new goalScorer()
                {
                    name = xlRange.Cells[i,1].value2.ToLower(),
                    goals = Convert.ToInt32(xlRange.Cells[i, 3].value2)
                };
                scorers.Add(s);
                i++;
            }
            Clean();
            return scorers;
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

