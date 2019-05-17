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
    public partial class RulesForm : Form
    {
        private bool prizeActive = false;
        public RulesForm()
        {
            InitializeComponent();
        }

        private void btnRulesPrizes_Click(object sender, EventArgs e)
        {
            if (!prizeActive)
            {
                rtbPrizes.Visible = true;
                rtbRules.Visible = false;
                btnRulesPrizes.Text = "Spelregels";
                prizeActive = true;
            }

            else
            {
                rtbPrizes.Visible = false;
                rtbRules.Visible = true;
                btnRulesPrizes.Text = "Prijsverdeling";
                prizeActive = false;
            }
        }
    }
}
