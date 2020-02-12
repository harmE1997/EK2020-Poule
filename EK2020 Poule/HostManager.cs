using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Configuration;

namespace EK2020_Poule
{
    public class HostManager
    {
        private Player Host;
        private string HostFileName;

        public HostManager()
        {
            HostFileName = ConfigurationManager.AppSettings.Get("HostFileName");
            SetHost();
        }

        public Player GetHost()
        {
            return Host;
        }

        public void SetHost(Player host = null)
        {
            LoadHost();
        }

        private void LoadHost()
        {
            string file = ConfigurationManager.AppSettings.Get("AdminLocation");
            int sheet = Convert.ToInt32(ConfigurationManager.AppSettings.Get("HostSheet"));
            ExcelManager em = new ExcelManager();
            Host = new Player("host", "zb", em.ReadGroupPhase(file, sheet, new ExcelReadSettings()), em.readKnockout(file, sheet, new ExcelReadSettings()), em.readBonus(file, sheet));
        }

    }
}
