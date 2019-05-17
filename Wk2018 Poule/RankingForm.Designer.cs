namespace Wk2018_Poule
{
    partial class RankingForm
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
            this.lbRanking = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbRanking
            // 
            this.lbRanking.BackColor = System.Drawing.Color.DarkRed;
            this.lbRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRanking.ForeColor = System.Drawing.Color.White;
            this.lbRanking.FormattingEnabled = true;
            this.lbRanking.Location = new System.Drawing.Point(12, 15);
            this.lbRanking.Name = "lbRanking";
            this.lbRanking.Size = new System.Drawing.Size(318, 533);
            this.lbRanking.TabIndex = 0;
            // 
            // RankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(342, 554);
            this.Controls.Add(this.lbRanking);
            this.Name = "RankingForm";
            this.Text = "FormRanking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRanking;
    }
}