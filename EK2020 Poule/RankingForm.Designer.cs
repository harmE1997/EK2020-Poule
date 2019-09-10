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
            this.lbRanking.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRanking.ForeColor = System.Drawing.Color.White;
            this.lbRanking.FormattingEnabled = true;
            this.lbRanking.ItemHeight = 16;
            this.lbRanking.Location = new System.Drawing.Point(16, 18);
            this.lbRanking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbRanking.Name = "lbRanking";
            this.lbRanking.Size = new System.Drawing.Size(424, 656);
            this.lbRanking.TabIndex = 0;
            // 
            // RankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(456, 682);
            this.Controls.Add(this.lbRanking);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RankingForm";
            this.Text = "FormRanking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRanking;
    }
}