namespace Wk2018_Poule
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
            this.btnCheckScore = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.gbExistingplayer = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnScheddule = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbCheck = new System.Windows.Forms.TextBox();
            this.gbExistingplayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(117, 25);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(224, 20);
            this.tbPlayerName.TabIndex = 0;
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlayer.Location = new System.Drawing.Point(10, 12);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(147, 140);
            this.btnNewPlayer.TabIndex = 1;
            this.btnNewPlayer.Text = "Nieuwe Speler";
            this.btnNewPlayer.UseVisualStyleBackColor = false;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // btnLoadPlayer
            // 
            this.btnLoadPlayer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLoadPlayer.Location = new System.Drawing.Point(9, 51);
            this.btnLoadPlayer.Name = "btnLoadPlayer";
            this.btnLoadPlayer.Size = new System.Drawing.Size(99, 43);
            this.btnLoadPlayer.TabIndex = 2;
            this.btnLoadPlayer.Text = "Laad Speler";
            this.btnLoadPlayer.UseVisualStyleBackColor = true;
            this.btnLoadPlayer.Click += new System.EventHandler(this.btnLoadPlayer_Click);
            // 
            // btnCheckScore
            // 
            this.btnCheckScore.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCheckScore.Location = new System.Drawing.Point(245, 50);
            this.btnCheckScore.Name = "btnCheckScore";
            this.btnCheckScore.Size = new System.Drawing.Size(99, 43);
            this.btnCheckScore.TabIndex = 5;
            this.btnCheckScore.Text = "Check Score";
            this.btnCheckScore.UseVisualStyleBackColor = true;
            this.btnCheckScore.Click += new System.EventHandler(this.btnCheckScore_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.Location = new System.Drawing.Point(288, 43);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(153, 25);
            this.btnRanking.TabIndex = 4;
            this.btnRanking.Text = "Toon Tussenstand";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Naam van de speler:";
            // 
            // gbExistingplayer
            // 
            this.gbExistingplayer.BackColor = System.Drawing.Color.Transparent;
            this.gbExistingplayer.Controls.Add(this.btnRemove);
            this.gbExistingplayer.Controls.Add(this.lblName);
            this.gbExistingplayer.Controls.Add(this.btnCheckScore);
            this.gbExistingplayer.Controls.Add(this.tbPlayerName);
            this.gbExistingplayer.Controls.Add(this.btnLoadPlayer);
            this.gbExistingplayer.ForeColor = System.Drawing.SystemColors.Window;
            this.gbExistingplayer.Location = new System.Drawing.Point(12, 158);
            this.gbExistingplayer.Name = "gbExistingplayer";
            this.gbExistingplayer.Size = new System.Drawing.Size(428, 99);
            this.gbExistingplayer.TabIndex = 7;
            this.gbExistingplayer.TabStop = false;
            this.gbExistingplayer.Text = "Bestaande Speler";
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnRemove.Location = new System.Drawing.Point(130, 51);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 43);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Verwijder Speler";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRules
            // 
            this.btnRules.Location = new System.Drawing.Point(288, 12);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(153, 25);
            this.btnRules.TabIndex = 8;
            this.btnRules.Text = "Spelregels en Prijsverdeling";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnScheddule
            // 
            this.btnScheddule.Location = new System.Drawing.Point(288, 74);
            this.btnScheddule.Name = "btnScheddule";
            this.btnScheddule.Size = new System.Drawing.Size(153, 25);
            this.btnScheddule.TabIndex = 9;
            this.btnScheddule.Text = "Toon Speelschema";
            this.btnScheddule.UseVisualStyleBackColor = true;
            this.btnScheddule.Click += new System.EventHandler(this.btnScheddule_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(288, 105);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(152, 23);
            this.btnAdmin.TabIndex = 12;
            this.btnAdmin.Text = "Toon Aministratie";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnMails_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(70, 290);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(113, 23);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "Check Final";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbCheck
            // 
            this.tbCheck.Location = new System.Drawing.Point(207, 290);
            this.tbCheck.Name = "tbCheck";
            this.tbCheck.Size = new System.Drawing.Size(100, 20);
            this.tbCheck.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 336);
            this.Controls.Add(this.tbCheck);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnScheddule);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.gbExistingplayer);
            this.Controls.Add(this.btnNewPlayer);
            this.Controls.Add(this.btnRanking);
            this.Name = "MainForm";
            this.Text = "WK 2018 Poule";
            this.gbExistingplayer.ResumeLayout(false);
            this.gbExistingplayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.Button btnLoadPlayer;
        private System.Windows.Forms.Button btnCheckScore;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbExistingplayer;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnScheddule;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox tbCheck;
    }
}

