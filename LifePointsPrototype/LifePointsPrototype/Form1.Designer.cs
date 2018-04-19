namespace LifePointsPrototype
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_display = new System.Windows.Forms.Button();
            this.dgv_lyrics = new System.Windows.Forms.DataGridView();
            this.col_song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_loadSamp = new System.Windows.Forms.Button();
            this.pnl_themes = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_addTheme = new System.Windows.Forms.Button();
            this.cmb_font = new System.Windows.Forms.ComboBox();
            this.btn_leftJust = new System.Windows.Forms.Button();
            this.btn_midJust = new System.Windows.Forms.Button();
            this.btn_rightJust = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnshowscrn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLivePreview = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnl_previewScreen = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lyrics)).BeginInit();
            this.pnl_themes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(107, 27);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(79, 24);
            this.btn_display.TabIndex = 0;
            this.btn_display.Text = "Project";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.bnt_showfrm_Click);
            // 
            // dgv_lyrics
            // 
            this.dgv_lyrics.AllowUserToAddRows = false;
            this.dgv_lyrics.AllowUserToDeleteRows = false;
            this.dgv_lyrics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lyrics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_lyrics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lyrics.ColumnHeadersVisible = false;
            this.dgv_lyrics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_song});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lyrics.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_lyrics.Location = new System.Drawing.Point(12, 30);
            this.dgv_lyrics.MultiSelect = false;
            this.dgv_lyrics.Name = "dgv_lyrics";
            this.dgv_lyrics.ReadOnly = true;
            this.dgv_lyrics.RowHeadersVisible = false;
            this.dgv_lyrics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_lyrics.Size = new System.Drawing.Size(357, 261);
            this.dgv_lyrics.TabIndex = 1;
            this.dgv_lyrics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lyrics_CellClick);
            this.dgv_lyrics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lyrics_CellContentClick);
            // 
            // col_song
            // 
            this.col_song.HeaderText = "Song";
            this.col_song.Name = "col_song";
            this.col_song.ReadOnly = true;
            // 
            // btn_loadSamp
            // 
            this.btn_loadSamp.Location = new System.Drawing.Point(22, 27);
            this.btn_loadSamp.Name = "btn_loadSamp";
            this.btn_loadSamp.Size = new System.Drawing.Size(79, 24);
            this.btn_loadSamp.TabIndex = 2;
            this.btn_loadSamp.Text = "Load Sample";
            this.btn_loadSamp.UseVisualStyleBackColor = true;
            this.btn_loadSamp.Click += new System.EventHandler(this.btn_loadSamp_Click);
            // 
            // pnl_themes
            // 
            this.pnl_themes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_themes.Controls.Add(this.tabControl1);
            this.pnl_themes.Location = new System.Drawing.Point(22, 71);
            this.pnl_themes.Name = "pnl_themes";
            this.pnl_themes.Size = new System.Drawing.Size(362, 246);
            this.pnl_themes.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 238);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Song";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bible";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(346, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Media";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_addTheme
            // 
            this.btn_addTheme.Location = new System.Drawing.Point(6, 6);
            this.btn_addTheme.Name = "btn_addTheme";
            this.btn_addTheme.Size = new System.Drawing.Size(57, 21);
            this.btn_addTheme.TabIndex = 0;
            this.btn_addTheme.Text = "Add";
            this.btn_addTheme.UseVisualStyleBackColor = true;
            this.btn_addTheme.Click += new System.EventHandler(this.btn_addTheme_Click);
            // 
            // cmb_font
            // 
            this.cmb_font.FormattingEnabled = true;
            this.cmb_font.Location = new System.Drawing.Point(379, 30);
            this.cmb_font.Name = "cmb_font";
            this.cmb_font.Size = new System.Drawing.Size(166, 21);
            this.cmb_font.TabIndex = 4;
            // 
            // btn_leftJust
            // 
            this.btn_leftJust.Location = new System.Drawing.Point(551, 29);
            this.btn_leftJust.Name = "btn_leftJust";
            this.btn_leftJust.Size = new System.Drawing.Size(27, 21);
            this.btn_leftJust.TabIndex = 5;
            this.btn_leftJust.Text = "<-";
            this.btn_leftJust.UseVisualStyleBackColor = true;
            // 
            // btn_midJust
            // 
            this.btn_midJust.Location = new System.Drawing.Point(584, 29);
            this.btn_midJust.Name = "btn_midJust";
            this.btn_midJust.Size = new System.Drawing.Size(27, 21);
            this.btn_midJust.TabIndex = 6;
            this.btn_midJust.Text = "--";
            this.btn_midJust.UseVisualStyleBackColor = true;
            // 
            // btn_rightJust
            // 
            this.btn_rightJust.Location = new System.Drawing.Point(617, 30);
            this.btn_rightJust.Name = "btn_rightJust";
            this.btn_rightJust.Size = new System.Drawing.Size(27, 21);
            this.btn_rightJust.TabIndex = 7;
            this.btn_rightJust.Text = "->";
            this.btn_rightJust.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // btnshowscrn
            // 
            this.btnshowscrn.Location = new System.Drawing.Point(1094, 30);
            this.btnshowscrn.Name = "btnshowscrn";
            this.btnshowscrn.Size = new System.Drawing.Size(87, 24);
            this.btnshowscrn.TabIndex = 11;
            this.btnshowscrn.Text = "Off Air";
            this.btnshowscrn.UseVisualStyleBackColor = true;
            this.btnshowscrn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgv_lyrics);
            this.panel1.Location = new System.Drawing.Point(809, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 294);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblLivePreview);
            this.panel2.Location = new System.Drawing.Point(809, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 247);
            this.panel2.TabIndex = 13;
            // 
            // lblLivePreview
            // 
            this.lblLivePreview.AutoSize = true;
            this.lblLivePreview.Location = new System.Drawing.Point(118, 98);
            this.lblLivePreview.Name = "lblLivePreview";
            this.lblLivePreview.Size = new System.Drawing.Size(35, 13);
            this.lblLivePreview.TabIndex = 0;
            this.lblLivePreview.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(390, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 294);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Location = new System.Drawing.Point(22, 323);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(362, 294);
            this.panel4.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(4, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(44, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 264);
            this.listBox1.TabIndex = 0;
            // 
            // pnl_previewScreen
            // 
            this.pnl_previewScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_previewScreen.Location = new System.Drawing.Point(390, 68);
            this.pnl_previewScreen.Name = "pnl_previewScreen";
            this.pnl_previewScreen.Size = new System.Drawing.Size(413, 249);
            this.pnl_previewScreen.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(22, 623);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(781, 28);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(809, 623);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(372, 28);
            this.panel6.TabIndex = 17;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(346, 212);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Projection";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_addTheme);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(346, 212);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Theme";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(7, 35);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(333, 147);
            this.listBox2.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(51, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(95, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(38, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(139, 7);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(38, 23);
            this.button10.TabIndex = 6;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 659);
            this.Controls.Add(this.btnshowscrn);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_themes);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_previewScreen);
            this.Controls.Add(this.btn_rightJust);
            this.Controls.Add(this.btn_midJust);
            this.Controls.Add(this.btn_leftJust);
            this.Controls.Add(this.cmb_font);
            this.Controls.Add(this.btn_loadSamp);
            this.Controls.Add(this.btn_display);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lyrics)).EndInit();
            this.pnl_themes.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.DataGridView dgv_lyrics;
        private System.Windows.Forms.Button btn_loadSamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_song;
        private System.Windows.Forms.Panel pnl_themes;
        private System.Windows.Forms.ComboBox cmb_font;
        private System.Windows.Forms.Button btn_leftJust;
        private System.Windows.Forms.Button btn_midJust;
        private System.Windows.Forms.Button btn_rightJust;
        private System.Windows.Forms.Button btn_addTheme;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button btnshowscrn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel pnl_previewScreen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblLivePreview;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button7;
    }
}

