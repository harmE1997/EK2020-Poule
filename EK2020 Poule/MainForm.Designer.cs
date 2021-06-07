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
            this.gbMatches = new System.Windows.Forms.GroupBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPoule = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.cbPoules = new System.Windows.Forms.ComboBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnResetHost = new System.Windows.Forms.Button();
            this.gbExistingplayer.SuspendLayout();
            this.gbMatches.SuspendLayout();
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
            this.btnNewPlayer.Size = new System.Drawing.Size(218, 70);
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
            this.btnRanking.Location = new System.Drawing.Point(495, 15);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(4);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(207, 31);
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
            this.btnCheck.Location = new System.Drawing.Point(496, 53);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(207, 30);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check All";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(495, 89);
            this.btnStats.Name = "btnStats";
            this.btnStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStats.Size = new System.Drawing.Size(207, 32);
            this.btnStats.TabIndex = 11;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // gbMatches
            // 
            this.gbMatches.BackColor = System.Drawing.Color.Transparent;
            this.gbMatches.Controls.Add(this.btnMatch);
            this.gbMatches.Controls.Add(this.btnInfo);
            this.gbMatches.Controls.Add(this.lblID);
            this.gbMatches.Controls.Add(this.lblPoule);
            this.gbMatches.Controls.Add(this.cbID);
            this.gbMatches.Controls.Add(this.cbPoules);
            this.gbMatches.ForeColor = System.Drawing.Color.White;
            this.gbMatches.Location = new System.Drawing.Point(495, 163);
            this.gbMatches.Name = "gbMatches";
            this.gbMatches.Size = new System.Drawing.Size(207, 152);
            this.gbMatches.TabIndex = 12;
            this.gbMatches.TabStop = false;
            this.gbMatches.Text = "Matches";
            // 
            // btnMatch
            // 
            this.btnMatch.ForeColor = System.Drawing.Color.Black;
            this.btnMatch.Location = new System.Drawing.Point(6, 115);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(188, 29);
            this.btnMatch.TabIndex = 5;
            this.btnMatch.Text = "Get match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.Location = new System.Drawing.Point(6, 81);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(188, 27);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Get Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(22, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID";
            // 
            // lblPoule
            // 
            this.lblPoule.AutoSize = true;
            this.lblPoule.Location = new System.Drawing.Point(13, 24);
            this.lblPoule.Name = "lblPoule";
            this.lblPoule.Size = new System.Drawing.Size(44, 17);
            this.lblPoule.TabIndex = 2;
            this.lblPoule.Text = "Poule";
            // 
            // cbID
            // 
            this.cbID.FormattingEnabled = true;
            this.cbID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbID.Location = new System.Drawing.Point(63, 51);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(131, 24);
            this.cbID.TabIndex = 1;
            this.cbID.Text = "1";
            // 
            // cbPoules
            // 
            this.cbPoules.FormattingEnabled = true;
            this.cbPoules.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbPoules.Location = new System.Drawing.Point(63, 21);
            this.cbPoules.Name = "cbPoules";
            this.cbPoules.Size = new System.Drawing.Size(131, 24);
            this.cbPoules.TabIndex = 0;
            this.cbPoules.Text = "1";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(495, 321);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(207, 105);
            this.rtbNotes.TabIndex = 13;
            this.rtbNotes.Text = "";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(21, 387);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(228, 17);
            this.lblWarning.TabIndex = 14;
            this.lblWarning.Text = "Loading host takes approx. 5 secs.";
            // 
            // btnResetHost
            // 
            this.btnResetHost.Location = new System.Drawing.Point(495, 124);
            this.btnResetHost.Name = "btnResetHost";
            this.btnResetHost.Size = new System.Drawing.Size(207, 33);
            this.btnResetHost.TabIndex = 15;
            this.btnResetHost.Text = "Reset Host";
            this.btnResetHost.UseVisualStyleBackColor = true;
            this.btnResetHost.Click += new System.EventHandler(this.btnResetHost_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 437);
            this.Controls.Add(this.btnResetHost);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.gbMatches);
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
            this.gbMatches.ResumeLayout(false);
            this.gbMatches.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox gbMatches;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPoule;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.ComboBox cbPoules;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnResetHost;
    }
}

