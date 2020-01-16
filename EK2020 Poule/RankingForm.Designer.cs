namespace EK2020_Poule
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
            this.btnRanking = new System.Windows.Forms.Button();
            this.ofdRanking = new System.Windows.Forms.OpenFileDialog();
            this.proBarRanking = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbRanking
            // 
            this.lbRanking.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRanking.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRanking.FormattingEnabled = true;
            this.lbRanking.ItemHeight = 16;
            this.lbRanking.Location = new System.Drawing.Point(16, 50);
            this.lbRanking.Margin = new System.Windows.Forms.Padding(4);
            this.lbRanking.Name = "lbRanking";
            this.lbRanking.Size = new System.Drawing.Size(424, 624);
            this.lbRanking.TabIndex = 0;
            // 
            // btnRanking
            // 
            this.btnRanking.Location = new System.Drawing.Point(12, 12);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(188, 31);
            this.btnRanking.TabIndex = 1;
            this.btnRanking.Text = "Export Ranking to Excel";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // ofdRanking
            // 
            this.ofdRanking.FileName = "ofdRanking";
            // 
            // proBarRanking
            // 
            this.proBarRanking.Location = new System.Drawing.Point(206, 12);
            this.proBarRanking.Name = "proBarRanking";
            this.proBarRanking.Size = new System.Drawing.Size(234, 31);
            this.proBarRanking.Step = 1;
            this.proBarRanking.TabIndex = 2;
            // 
            // RankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(456, 682);
            this.Controls.Add(this.proBarRanking);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.lbRanking);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RankingForm";
            this.Text = "FormRanking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRanking;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.OpenFileDialog ofdRanking;
        private System.Windows.Forms.ProgressBar proBarRanking;
    }
}