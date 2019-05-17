using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Wk2018_Poule
{
    public partial class PassWordForm : Form
    {
        private string password = "WK2018Host";
        public string nextform;
        public Player host;
        public PlayerManager manager;

        public PassWordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == password && nextform == "hostform")
            {
                HostForm hostform = new HostForm();
                hostform.player = host;
                hostform.loadHost();
                hostform.manager = manager;
                hostform.Show();
                this.Hide();
                this.Dispose();
            }

            else if (tbPassword.Text == password && nextform == "mailform")
            {
                EmailsForm form = new EmailsForm(manager);
                form.Show();
                this.Hide();
                this.Dispose();
            }

            else
            {
                MessageBox.Show("incorrect password");
            }
        }
    }
}
