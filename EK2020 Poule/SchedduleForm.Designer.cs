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
            this.lbScheddule.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbScheddule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbScheddule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScheddule.ForeColor = System.Drawing.Color.White;
            this.lbScheddule.FormattingEnabled = true;
            this.lbScheddule.ItemHeight = 17;
            this.lbScheddule.Location = new System.Drawing.Point(16, 15);
            this.lbScheddule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbScheddule.Name = "lbScheddule";
            this.lbScheddule.Size = new System.Drawing.Size(709, 374);
            this.lbScheddule.TabIndex = 0;
            // 
            // SchedduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(741, 417);
            this.Controls.Add(this.lbScheddule);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SchedduleForm";
            this.Text = "SchedduleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbScheddule;
    }
}