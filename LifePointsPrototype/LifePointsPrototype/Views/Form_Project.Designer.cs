namespace LifePointsPrototype.Views {
    partial class Form_Project {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_lyricDisp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_lyricDisp
            // 
            this.lbl_lyricDisp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lyricDisp.AutoSize = true;
            this.lbl_lyricDisp.ForeColor = System.Drawing.Color.White;
            this.lbl_lyricDisp.Location = new System.Drawing.Point(12, 9);
            this.lbl_lyricDisp.Name = "lbl_lyricDisp";
            this.lbl_lyricDisp.Size = new System.Drawing.Size(169, 52);
            this.lbl_lyricDisp.TabIndex = 0;
            this.lbl_lyricDisp.Text = "Through You I can do anything\r\nI can do all things\r\nCoz its You who gives me stre" +
    "ngth\r\nNothing is impossible";
            // 
            // Form_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(430, 315);
            this.Controls.Add(this.lbl_lyricDisp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_lyricDisp;
    }
}