namespace EK2020_Poule
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.btnLoadPlayer = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.gbExistingplayer = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.gbExistingplayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(11, 55);
            this.tbPlayerName.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(198, 22);
            this.tbPlayerName.TabIndex = 0;
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlayer.Location = new System.Drawing.Point(13, 15);
            this.btnNewPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(196, 70);
            this.btnNewPlayer.TabIndex = 1;
            this.btnNewPlayer.Text = "Nieuwe Speler";
            this.btnNewPlayer.UseVisualStyleBackColor = false;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // btnLoadPlayer
            // 
            this.btnLoadPlayer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLoadPlayer.Location = new System.Drawing.Point(11, 85);
            this.btnLoadPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadPlayer.Name = "btnLoadPlayer";
            this.btnLoadPlayer.Size = new System.Drawing.Size(198, 53);
            this.btnLoadPlayer.TabIndex = 2;
            this.btnLoadPlayer.Text = "Laad Speler";
            this.btnLoadPlayer.UseVisualStyleBackColor = true;
            this.btnLoadPlayer.Click += new System.EventHandler(this.btnLoadPlayer_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.Location = new System.Drawing.Point(465, 15);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(4);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(204, 31);
            this.btnRanking.TabIndex = 4;
            this.btnRanking.Text = "Toon Tussenstand";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(139, 17);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Naam van de speler:";
            // 
            // gbExistingplayer
            // 
            this.gbExistingplayer.BackColor = System.Drawing.Color.Transparent;
            this.gbExistingplayer.Controls.Add(this.btnRemove);
            this.gbExistingplayer.Controls.Add(this.lblName);
            this.gbExistingplayer.Controls.Add(this.tbPlayerName);
            this.gbExistingplayer.Controls.Add(this.btnLoadPlayer);
            this.gbExistingplayer.ForeColor = System.Drawing.SystemColors.Window;
            this.gbExistingplayer.Location = new System.Drawing.Point(13, 93);
            this.gbExistingplayer.Margin = new System.Windows.Forms.Padding(4);
            this.gbExistingplayer.Name = "gbExistingplayer";
            this.gbExistingplayer.Padding = new System.Windows.Forms.Padding(4);
            this.gbExistingplayer.Size = new System.Drawing.Size(218, 207);
            this.gbExistingplayer.TabIndex = 7;
            this.gbExistingplayer.TabStop = false;
            this.gbExistingplayer.Text = "Bestaande Speler";
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnRemove.Location = new System.Drawing.Point(11, 146);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(199, 53);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Verwijder Speler";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(466, 53);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(204, 30);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check All";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(465, 89);
            this.btnStats.Name = "btnStats";
            this.btnStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStats.Size = new System.Drawing.Size(204, 32);
            this.btnStats.TabIndex = 11;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 414);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.gbExistingplayer);
            this.Controls.Add(this.btnNewPlayer);
            this.Controls.Add(this.btnRanking);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "EK 2020 Poule";
            this.gbExistingplayer.ResumeLayout(false);
            this.gbExistingplayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.Button btnLoadPlayer;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbExistingplayer;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnStats;
    }
}

