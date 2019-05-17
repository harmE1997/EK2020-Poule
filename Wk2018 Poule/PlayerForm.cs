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
    public partial class PlayerForm : Form
    {
        public PlayerManager manager;
        public PlayerForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string name = tbPlayerName.Text;
            string mail = tbMail.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Veld niet ingevuld. Controleer en probeer opnieuw");
                return;
            }

            string payment;
            if (rdbOnline.Checked && !rdbCash.Checked)
            {
                payment = "online";
            }

            else if (!rdbOnline.Checked && rdbCash.Checked)
            {
                payment = "cash";
            }

            else
            {
                MessageBox.Show("Wijze van betaling is niet ingevuld.");
                return;
            }

            TotoForm toto = new TotoForm();
            toto.email = mail;
            toto.payment = payment;
            toto.name = name;
            toto.manager = manager;
            toto.Show();
            this.Close();
        }
    }
}
