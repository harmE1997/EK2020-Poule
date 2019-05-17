namespace Wk2018_Poule
{
    partial class SchedduleForm
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
            this.lbScheddule = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbScheddule
            // 
            this.lbScheddule.BackColor = System.Drawing.Color.DarkRed;
            this.lbScheddule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbScheddule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScheddule.ForeColor = System.Drawing.Color.White;
            this.lbScheddule.FormattingEnabled = true;
            this.lbScheddule.Location = new System.Drawing.Point(12, 12);
            this.lbScheddule.Name = "lbScheddule";
            this.lbScheddule.Size = new System.Drawing.Size(532, 312);
            this.lbScheddule.TabIndex = 0;
            // 
            // SchedduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(556, 339);
            this.Controls.Add(this.lbScheddule);
            this.Name = "SchedduleForm";
            this.Text = "SchedduleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbScheddule;
    }
}