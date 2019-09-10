using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk2018_Poule
{
    public partial class SchedduleForm : Form
    {
        public SchedduleForm(Player host)
        {
            InitializeComponent();
            fillScheddule(host);
        }

        private void fillScheddule(Player host)
        {
            lbScheddule.Items.Add("Poule A");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t \tResultaat");
            lbScheddule.Items.Add("-------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("14-6 \t 17:00 \t Moskou          \t Rusland - Saoudie-Arabië  \t"  + host.Results[0].MatchToString());
            lbScheddule.Items.Add("15-6 \t 14:00 \t Jekaterinenburg \t Egypte - Urugay           \t"  + host.Results[1].MatchToString());
            lbScheddule.Items.Add("19-6 \t 20:00 \t Sint-Petersburg \t Rusland - Egypte          \t"  + host.Results[2].MatchToString());
            lbScheddule.Items.Add("20-6 \t 17:00 \t Rostov          \t Uruguay – Saoudi-Arabië   \t"  + host.Results[3].MatchToString());
            lbScheddule.Items.Add("25-6 \t 16:00 \t Samara          \t Uruguay – Rusland         \t"  + host.Results[4].MatchToString());
            lbScheddule.Items.Add("25-6 \t 16:00 \t Volkograd       \t Saoudi-Arabië – Egypte    \t"  + host.Results[5].MatchToString());
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("Poule B");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t \tResultaat");
            lbScheddule.Items.Add("-------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("15-6 \t 17:00 \t Sint-Petersburg \t Marokko - Iran    \t \t"  + host.Results[6].MatchToString());
            lbScheddule.Items.Add("15-6 \t 20:00 \t Sotsji          \t Portugal - Spanje    \t"  + host.Results[7].MatchToString());
            lbScheddule.Items.Add("20-6 \t 14:00 \t Moskou          \t Portugal - Marokko   \t"  + host.Results[8].MatchToString());
            lbScheddule.Items.Add("20-6 \t 20:00 \t Kazan           \t Iran – Spanje     \t \t"  + host.Results[9].MatchToString());
            lbScheddule.Items.Add("25-6 \t 20:00 \t Saransk         \t Iran – Portugal   \t \t"  + host.Results[10].MatchToString());
            lbScheddule.Items.Add("25-6 \t 20:00 \t Kaliningrad     \t Spanje – Marokko     \t"  + host.Results[11].MatchToString());
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("Poule C");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t \tResultaat");
            lbScheddule.Items.Add("-------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("16-6 \t 12:00 \t Kazan           \t Frankrijk - Australië     \t"  + host.Results[12].MatchToString());
            lbScheddule.Items.Add("16-6 \t 18:00 \t Saransk         \t Peru - Denemarken         \t"  + host.Results[13].MatchToString());
            lbScheddule.Items.Add("21-6 \t 14:00 \t Samara          \t Frankrijk – Peru          \t"  + host.Results[14].MatchToString());
            lbScheddule.Items.Add("21-6 \t 17:00 \t Jekaterinenburg \t Denemarken – Australië    \t"  + host.Results[15].MatchToString());
            lbScheddule.Items.Add("26-6 \t 16:00 \t Moskou          \t Denemarken – Frankrijk    \t"  + host.Results[16].MatchToString());
            lbScheddule.Items.Add("26-6 \t 16:00 \t Sotsji          \tAustralië – Peru           \t"  + host.Results[17].MatchToString());
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("Poule D");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t \tResultaat");
            lbScheddule.Items.Add("-------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("16-6 \t 15:00 \t Moskou          \t Argentinië - IJsland      \t"  + host.Results[18].MatchToString());            
            lbScheddule.Items.Add("16-6 \t 21:00 \t Kaliningrad     \t Kroatië - Nigeria         \t"  + host.Results[19].MatchToString());
            lbScheddule.Items.Add("21-6 \t 20:00 \t Nizjni Novgorod \t Argentinië – Kroatië      \t"  + host.Results[20].MatchToString());
            lbScheddule.Items.Add("22-6 \t 17:00 \t Volgograd       \t Nigeria – IJsland         \t"  + host.Results[21].MatchToString());
            lbScheddule.Items.Add("26-6 \t 20:00 \t Sint-Petersburg \t Nigeria – Argentinië      \t"  + host.Results[22].MatchToString());
            lbScheddule.Items.Add("26-6 \t 20:00 \t Rostov          \t IJsland – Kroatië         \t"  + host.Results[23].MatchToString());
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("Poule E");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t \tResultaat");
            lbScheddule.Items.Add("-------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("17-6 \t 14:00 \t Samara          \t Costa Rica - Servië       \t"  + host.Results[24].MatchToString());
            lbScheddule.Items.Add("17-6 \t 20:00 \t Rostov          \t Brazilië - Zwitserland    \t"  + host.Results[25].MatchToString());
            lbScheddule.Items.Add("22-6 \t 14:00 \t Sint-petersburg \t Brazilië – Costa Rica     \t"  + host.Results[26].MatchToString());         
            lbScheddule.Items.Add("22-6 \t 20:00 \t Kaliningrad     \t Servië – Zwitserland      \t"  + host.Results[27].MatchToString());
            lbScheddule.Items.Add("27-6 \t 20:00 \t Moskou          \t Servië – Brazilië         \t"  + host.Results[28].MatchToString());
            lbScheddule.Items.Add("27-6 \t 20:00 \t Nizjni Novgorod \t Zwitserland – Costa Rica  \t"  + host.Results[29].MatchToString());
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("Poule F");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t \tResultaat");
            lbScheddule.Items.Add("-------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("17-6 \t 17:00 \t Moskou          \t Duitslad - Mexico         \t"  + host.Results[30].MatchToString());            
            lbScheddule.Items.Add("18-6 \t 14:00 \t Nizjni Novgorod \t Zweden - Zuid-Korea       \t"  + host.Results[31].MatchToString());
            lbScheddule.Items.Add("23-6 \t 17:00 \t Rostov          \t Zuid-Korea – Mexico       \t"  + host.Results[32].MatchToString());
            lbScheddule.Items.Add("23-6 \t 20:00 \t Sotsji          \t Duitsland - Zweden        \t"  + host.Results[33].MatchToString());
            lbScheddule.Items.Add("27-6 \t 16:00 \t Jekaterinenburg \t Zuid-Korea – Duitsland    \t"  + host.Results[34].MatchToString());
            lbScheddule.Items.Add("27-6 \t 16:00 \t Kazan           \t Mexico – Zweden           \t"  + host.Results[35].MatchToString());
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("Poule G");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t \tResultaat");
            lbScheddule.Items.Add("-------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("18-6 \t 17:00 \t Sotsji          \t België - Panama           \t"  + host.Results[36].MatchToString());
            lbScheddule.Items.Add("18-6 \t 20:00 \t Volgograd       \t Tunesië - Engeland        \t"  + host.Results[37].MatchToString());
            lbScheddule.Items.Add("23-6 \t 14:00 \t Moskou          \t België – Tunesië          \t"  + host.Results[38].MatchToString());           
            lbScheddule.Items.Add("24-6 \t 14:00 \t Nizjni Novgorod \t Engeland – Panama         \t"  + host.Results[39].MatchToString());
            lbScheddule.Items.Add("28-6 \t 20:00 \t Saransk         \t Engeland – België         \t"  + host.Results[40].MatchToString());
            lbScheddule.Items.Add("28-6 \t 20:00 \t Kaliningrad     \tPanama – Tunesië           \t"  + host.Results[41].MatchToString());
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("Poule H");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t \tResultaat");
            lbScheddule.Items.Add("-------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("19-6 \t 14:00 \t Saransk         \t Polen - Senegal           \t"  + host.Results[42].MatchToString());
            lbScheddule.Items.Add("19-6 \t 17:00 \t Moskou          \t Colombia - Japan          \t"  + host.Results[43].MatchToString());
            lbScheddule.Items.Add("24-6 \t 17:00 \t Jekaterinenburg \t Japan – Senegal           \t"  + host.Results[44].MatchToString());
            lbScheddule.Items.Add("24-6 \t 20:00 \t Kazan           \t Polen – Colombia          \t"  + host.Results[45].MatchToString());
            lbScheddule.Items.Add("28-6 \t 16:00 \t Volgograd       \t Japan – Polen             \t"  + host.Results[46].MatchToString());
            lbScheddule.Items.Add("28-6 \t 16:00 \t Samara          \tSenegal – Colombia         \t"  + host.Results[47].MatchToString());

            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("Achtste Finales");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t \t \tResultaat");
            lbScheddule.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("30-6 \t 16:00 \t Kazan           \t\t Frankrijk - Argentinië \t  4-3");
            lbScheddule.Items.Add("30-6 \t 20:00 \t Sotsji          \t\t Uruguay - Portugal \t\t  2-1");
            lbScheddule.Items.Add("1-7  \t 16:00 \t Moskou          \t\t Spanje - Rusland \t\t  4-3 n.s. ");
            lbScheddule.Items.Add("1-7  \t 20:00 \t Nizjni Novgorod \t\t Kroatië - Denemarken \t  3-2 n.s. ");
            lbScheddule.Items.Add("2-7  \t 16:00 \t Samara          \t\t Brazilië - Mexico \t\t  2-0 ");
            lbScheddule.Items.Add("2-7  \t 20:00 \t Rostov          \t\t België - Japan \t\t  3-2 ");
            lbScheddule.Items.Add("3-7  \t 16:00 \t Sint-Petersburg \t\t Zweden - Zwitserland \t  1-0 ");
            lbScheddule.Items.Add("3-7  \t 20:00 \t Moskou          \t\t Colombia - Engeland \t  3-4 n.s. ");

            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("Kwart finales");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t \t \t\tResultaat");
            lbScheddule.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("6-7 \t 16:00 \t Nizjni Novgorod  \t\t Uruguay - Frankrijk  \t\t   0-2 ");
            lbScheddule.Items.Add("6-7 \t 20:00 \t Kazan            \t\t Brazilië - België  \t\t\t   1-2 ");
            lbScheddule.Items.Add("7-7 \t 16:00 \t Samara           \t\t Zweden - Engeland  \t\t   0-2 ");
            lbScheddule.Items.Add("7-7 \t 20:00 \t Sotsji           \t\t Rusland - Kroatië  \t\t\t   3-4 n.s. ");

            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("Halve finales");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t\t\t          Resultaat");
            lbScheddule.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("10-7 \t 20:00 \t Sint-Petersburg \t\t Frankrijk - België \t\t\t 1-0 ");
            lbScheddule.Items.Add("11-7 \t 20:00 \t Moskou          \t\t Kroatië - Engeland \t\t\t 2-1 n.v. ");

            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("Troostfinale");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t \t \t          Resultaat");
            lbScheddule.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("14-7 \t 16:00 \t Sint-Petersburg \t\t België - Engeland \t\t\t - ");

            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("");
            lbScheddule.Items.Add("Finale");
            lbScheddule.Items.Add("Datum \t Tijd \t Speelstad \t \t Wedstrijd\t \t \t          Resultaat");
            lbScheddule.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------");
            lbScheddule.Items.Add("15-7 \t 17:00 \t Moskou \t\t\t Frankrijk - Kroatië \t\t\t  - ");
        }
    }
}
