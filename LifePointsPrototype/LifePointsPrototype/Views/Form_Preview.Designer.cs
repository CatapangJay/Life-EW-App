namespace LifePointsPrototype.Views {
    partial class Form_Preview {
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
            this.lbl_lyricDisp.AutoSize = true;
            this.lbl_lyricDisp.ForeColor = System.Drawing.Color.White;
            this.lbl_lyricDisp.Location = new System.Drawing.Point(97, 112);
            this.lbl_lyricDisp.Name = "lbl_lyricDisp";
            this.lbl_lyricDisp.Size = new System.Drawing.Size(35, 13);
            this.lbl_lyricDisp.TabIndex = 1;
            this.lbl_lyricDisp.Text = "label1";
            // 
            // Form_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(399, 314);
            this.Controls.Add(this.lbl_lyricDisp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Preview";
            this.Text = "Form_Preview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_lyricDisp;
    }
}