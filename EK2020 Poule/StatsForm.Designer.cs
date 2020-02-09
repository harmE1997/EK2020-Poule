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
            this.btnLast16 = new System.Windows.Forms.Button();
            this.btnQuarter = new System.Windows.Forms.Button();
            this.btnSemi = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
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
            // btnLast16
            // 
            this.btnLast16.Location = new System.Drawing.Point(493, 190);
            this.btnLast16.Name = "btnLast16";
            this.btnLast16.Size = new System.Drawing.Size(241, 53);
            this.btnLast16.TabIndex = 4;
            this.btnLast16.Text = "Last16";
            this.btnLast16.UseVisualStyleBackColor = true;
            this.btnLast16.Click += new System.EventHandler(this.btnLast16_Click);
            // 
            // btnQuarter
            // 
            this.btnQuarter.Location = new System.Drawing.Point(493, 249);
            this.btnQuarter.Name = "btnQuarter";
            this.btnQuarter.Size = new System.Drawing.Size(241, 53);
            this.btnQuarter.TabIndex = 5;
            this.btnQuarter.Text = "QuarterFinals";
            this.btnQuarter.UseVisualStyleBackColor = true;
            this.btnQuarter.Click += new System.EventHandler(this.btnQuarter_Click);
            // 
            // btnSemi
            // 
            this.btnSemi.Location = new System.Drawing.Point(493, 308);
            this.btnSemi.Name = "btnSemi";
            this.btnSemi.Size = new System.Drawing.Size(241, 53);
            this.btnSemi.TabIndex = 6;
            this.btnSemi.Text = "Semifinals";
            this.btnSemi.UseVisualStyleBackColor = true;
            this.btnSemi.Click += new System.EventHandler(this.btnSemi_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(493, 367);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(241, 53);
            this.btnFinal.TabIndex = 7;
            this.btnFinal.Text = "Finals";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnSemi);
            this.Controls.Add(this.btnQuarter);
            this.Controls.Add(this.btnLast16);
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
        private System.Windows.Forms.Button btnLast16;
        private System.Windows.Forms.Button btnQuarter;
        private System.Windows.Forms.Button btnSemi;
        private System.Windows.Forms.Button btnFinal;
    }
}