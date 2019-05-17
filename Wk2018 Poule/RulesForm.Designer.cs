namespace Wk2018_Poule
{
    partial class RulesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesForm));
            this.rtbRules = new System.Windows.Forms.RichTextBox();
            this.rtbPrizes = new System.Windows.Forms.RichTextBox();
            this.btnRulesPrizes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbRules
            // 
            this.rtbRules.BackColor = System.Drawing.Color.DarkRed;
            this.rtbRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRules.ForeColor = System.Drawing.Color.White;
            this.rtbRules.Location = new System.Drawing.Point(12, 12);
            this.rtbRules.Name = "rtbRules";
            this.rtbRules.ReadOnly = true;
            this.rtbRules.Size = new System.Drawing.Size(539, 328);
            this.rtbRules.TabIndex = 0;
            this.rtbRules.Text = resources.GetString("rtbRules.Text");
            // 
            // rtbPrizes
            // 
            this.rtbPrizes.BackColor = System.Drawing.Color.DarkRed;
            this.rtbPrizes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPrizes.ForeColor = System.Drawing.Color.White;
            this.rtbPrizes.Location = new System.Drawing.Point(12, 12);
            this.rtbPrizes.Name = "rtbPrizes";
            this.rtbPrizes.Size = new System.Drawing.Size(252, 149);
            this.rtbPrizes.TabIndex = 1;
            this.rtbPrizes.Text = resources.GetString("rtbPrizes.Text");
            this.rtbPrizes.Visible = false;
            // 
            // btnRulesPrizes
            // 
            this.btnRulesPrizes.Location = new System.Drawing.Point(12, 347);
            this.btnRulesPrizes.Name = "btnRulesPrizes";
            this.btnRulesPrizes.Size = new System.Drawing.Size(201, 23);
            this.btnRulesPrizes.TabIndex = 2;
            this.btnRulesPrizes.Text = "Prijsverdeling";
            this.btnRulesPrizes.UseVisualStyleBackColor = true;
            this.btnRulesPrizes.Click += new System.EventHandler(this.btnRulesPrizes_Click);
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(563, 382);
            this.Controls.Add(this.btnRulesPrizes);
            this.Controls.Add(this.rtbPrizes);
            this.Controls.Add(this.rtbRules);
            this.Name = "RulesForm";
            this.Text = "RulesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRules;
        private System.Windows.Forms.RichTextBox rtbPrizes;
        private System.Windows.Forms.Button btnRulesPrizes;
    }
}