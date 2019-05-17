namespace Wk2018_Poule
{
    partial class EmailsForm
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
            this.lbMails = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbMails
            // 
            this.lbMails.BackColor = System.Drawing.Color.DarkRed;
            this.lbMails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMails.ForeColor = System.Drawing.Color.White;
            this.lbMails.FormattingEnabled = true;
            this.lbMails.ItemHeight = 15;
            this.lbMails.Location = new System.Drawing.Point(12, 12);
            this.lbMails.Name = "lbMails";
            this.lbMails.Size = new System.Drawing.Size(260, 240);
            this.lbMails.TabIndex = 0;
            // 
            // EmailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbMails);
            this.Name = "EmailsForm";
            this.Text = "EmailsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMails;
    }
}