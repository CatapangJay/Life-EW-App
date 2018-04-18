namespace LifePointsPrototype.Views {
    partial class Form_ThemeEditor {
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
            this.components = new System.ComponentModel.Container();
            this.pnl_preview = new System.Windows.Forms.Panel();
            this.cmb_font = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cd_bgColors = new System.Windows.Forms.ColorDialog();
            this.btn_bgColors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_preview
            // 
            this.pnl_preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_preview.Location = new System.Drawing.Point(21, 12);
            this.pnl_preview.Name = "pnl_preview";
            this.pnl_preview.Size = new System.Drawing.Size(301, 219);
            this.pnl_preview.TabIndex = 0;
            // 
            // cmb_font
            // 
            this.cmb_font.FormattingEnabled = true;
            this.cmb_font.Location = new System.Drawing.Point(21, 237);
            this.cmb_font.Name = "cmb_font";
            this.cmb_font.Size = new System.Drawing.Size(148, 21);
            this.cmb_font.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "B";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(270, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 21);
            this.button2.TabIndex = 8;
            this.button2.Text = "I";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(297, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 21);
            this.button3.TabIndex = 9;
            this.button3.Text = "U";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(21, 311);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(72, 28);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(99, 311);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(49, 28);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(154, 311);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(50, 28);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_bgColors
            // 
            this.btn_bgColors.Location = new System.Drawing.Point(21, 264);
            this.btn_bgColors.Name = "btn_bgColors";
            this.btn_bgColors.Size = new System.Drawing.Size(84, 28);
            this.btn_bgColors.TabIndex = 10;
            this.btn_bgColors.Text = "Choose Colors";
            this.btn_bgColors.UseVisualStyleBackColor = true;
            this.btn_bgColors.Click += new System.EventHandler(this.btn_bgColors_Click);
            // 
            // Form_ThemeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 370);
            this.Controls.Add(this.btn_bgColors);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmb_font);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pnl_preview);
            this.Name = "Form_ThemeEditor";
            this.Text = "Form_ThemeEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_preview;
        private System.Windows.Forms.ComboBox cmb_font;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ColorDialog cd_bgColors;
        private System.Windows.Forms.Button btn_bgColors;
    }
}