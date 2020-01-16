namespace EK2020_Poule
{
    partial class StatsForm
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
            this.lbStats = new System.Windows.Forms.ListBox();
            this.btnChampions = new System.Windows.Forms.Button();
            this.btnTopscorers = new System.Windows.Forms.Button();
            this.btnNL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStats
            // 
            this.lbStats.FormattingEnabled = true;
            this.lbStats.ItemHeight = 16;
            this.lbStats.Location = new System.Drawing.Point(12, 12);
            this.lbStats.Name = "lbStats";
            this.lbStats.Size = new System.Drawing.Size(453, 500);
            this.lbStats.TabIndex = 0;
            // 
            // btnChampions
            // 
            this.btnChampions.Location = new System.Drawing.Point(493, 12);
            this.btnChampions.Name = "btnChampions";
            this.btnChampions.Size = new System.Drawing.Size(241, 55);
            this.btnChampions.TabIndex = 1;
            this.btnChampions.Text = "Kampioenen";
            this.btnChampions.UseVisualStyleBackColor = true;
            this.btnChampions.Click += new System.EventHandler(this.btnChampions_Click);
            // 
            // btnTopscorers
            // 
            this.btnTopscorers.Location = new System.Drawing.Point(493, 73);
            this.btnTopscorers.Name = "btnTopscorers";
            this.btnTopscorers.Size = new System.Drawing.Size(241, 52);
            this.btnTopscorers.TabIndex = 2;
            this.btnTopscorers.Text = "Topscorers";
            this.btnTopscorers.UseVisualStyleBackColor = true;
            this.btnTopscorers.Click += new System.EventHandler(this.btnTopscorers_Click);
            // 
            // btnNL
            // 
            this.btnNL.Location = new System.Drawing.Point(493, 131);
            this.btnNL.Name = "btnNL";
            this.btnNL.Size = new System.Drawing.Size(241, 53);
            this.btnNL.TabIndex = 3;
            this.btnNL.Text = "NL";
            this.btnNL.UseVisualStyleBackColor = true;
            this.btnNL.Click += new System.EventHandler(this.btnNL_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnNL);
            this.Controls.Add(this.btnTopscorers);
            this.Controls.Add(this.btnChampions);
            this.Controls.Add(this.lbStats);
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbStats;
        private System.Windows.Forms.Button btnChampions;
        private System.Windows.Forms.Button btnTopscorers;
        private System.Windows.Forms.Button btnNL;
    }
}