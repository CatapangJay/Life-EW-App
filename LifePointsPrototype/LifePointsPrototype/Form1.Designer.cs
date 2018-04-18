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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_display = new System.Windows.Forms.Button();
            this.dgv_lyrics = new System.Windows.Forms.DataGridView();
            this.col_song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_loadSamp = new System.Windows.Forms.Button();
            this.pnl_themes = new System.Windows.Forms.Panel();
            this.cmb_font = new System.Windows.Forms.ComboBox();
            this.btn_leftJust = new System.Windows.Forms.Button();
            this.btn_midJust = new System.Windows.Forms.Button();
            this.btn_rightJust = new System.Windows.Forms.Button();
            this.pnl_previewScreen = new System.Windows.Forms.Panel();
            this.btn_addTheme = new System.Windows.Forms.Button();
            this.dgv_themes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lyrics)).BeginInit();
            this.pnl_themes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_themes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(379, 83);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lyrics.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_lyrics.Location = new System.Drawing.Point(124, 41);
            this.dgv_lyrics.MultiSelect = false;
            this.dgv_lyrics.Name = "dgv_lyrics";
            this.dgv_lyrics.ReadOnly = true;
            this.dgv_lyrics.RowHeadersVisible = false;
            this.dgv_lyrics.Size = new System.Drawing.Size(224, 340);
            this.dgv_lyrics.TabIndex = 1;
            this.dgv_lyrics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lyrics_CellClick);
            // 
            // col_song
            // 
            this.col_song.HeaderText = "Song";
            this.col_song.Name = "col_song";
            this.col_song.ReadOnly = true;
            // 
            // btn_loadSamp
            // 
            this.btn_loadSamp.Location = new System.Drawing.Point(18, 113);
            this.btn_loadSamp.Name = "btn_loadSamp";
            this.btn_loadSamp.Size = new System.Drawing.Size(79, 24);
            this.btn_loadSamp.TabIndex = 2;
            this.btn_loadSamp.Text = "Load Sample";
            this.btn_loadSamp.UseVisualStyleBackColor = true;
            this.btn_loadSamp.Click += new System.EventHandler(this.btn_loadSamp_Click);
            // 
            // pnl_themes
            // 
            this.pnl_themes.Controls.Add(this.dgv_themes);
            this.pnl_themes.Controls.Add(this.btn_addTheme);
            this.pnl_themes.Location = new System.Drawing.Point(658, 41);
            this.pnl_themes.Name = "pnl_themes";
            this.pnl_themes.Size = new System.Drawing.Size(250, 340);
            this.pnl_themes.TabIndex = 3;
            // 
            // cmb_font
            // 
            this.cmb_font.FormattingEnabled = true;
            this.cmb_font.Location = new System.Drawing.Point(379, 41);
            this.cmb_font.Name = "cmb_font";
            this.cmb_font.Size = new System.Drawing.Size(166, 21);
            this.cmb_font.TabIndex = 4;
            // 
            // btn_leftJust
            // 
            this.btn_leftJust.Location = new System.Drawing.Point(551, 40);
            this.btn_leftJust.Name = "btn_leftJust";
            this.btn_leftJust.Size = new System.Drawing.Size(27, 21);
            this.btn_leftJust.TabIndex = 5;
            this.btn_leftJust.Text = "<-";
            this.btn_leftJust.UseVisualStyleBackColor = true;
            // 
            // btn_midJust
            // 
            this.btn_midJust.Location = new System.Drawing.Point(579, 40);
            this.btn_midJust.Name = "btn_midJust";
            this.btn_midJust.Size = new System.Drawing.Size(27, 21);
            this.btn_midJust.TabIndex = 6;
            this.btn_midJust.Text = "--";
            this.btn_midJust.UseVisualStyleBackColor = true;
            // 
            // btn_rightJust
            // 
            this.btn_rightJust.Location = new System.Drawing.Point(608, 40);
            this.btn_rightJust.Name = "btn_rightJust";
            this.btn_rightJust.Size = new System.Drawing.Size(27, 21);
            this.btn_rightJust.TabIndex = 7;
            this.btn_rightJust.Text = "->";
            this.btn_rightJust.UseVisualStyleBackColor = true;
            // 
            // pnl_previewScreen
            // 
            this.pnl_previewScreen.Location = new System.Drawing.Point(379, 113);
            this.pnl_previewScreen.Name = "pnl_previewScreen";
            this.pnl_previewScreen.Size = new System.Drawing.Size(250, 264);
            this.pnl_previewScreen.TabIndex = 8;
            // 
            // btn_addTheme
            // 
            this.btn_addTheme.Location = new System.Drawing.Point(12, 12);
            this.btn_addTheme.Name = "btn_addTheme";
            this.btn_addTheme.Size = new System.Drawing.Size(57, 21);
            this.btn_addTheme.TabIndex = 0;
            this.btn_addTheme.Text = "Add";
            this.btn_addTheme.UseVisualStyleBackColor = true;
            this.btn_addTheme.Click += new System.EventHandler(this.btn_addTheme_Click);
            // 
            // dgv_themes
            // 
            this.dgv_themes.AllowUserToAddRows = false;
            this.dgv_themes.AllowUserToDeleteRows = false;
            this.dgv_themes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_themes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_themes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_themes.ColumnHeadersVisible = false;
            this.dgv_themes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_themes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_themes.Location = new System.Drawing.Point(13, 56);
            this.dgv_themes.MultiSelect = false;
            this.dgv_themes.Name = "dgv_themes";
            this.dgv_themes.ReadOnly = true;
            this.dgv_themes.RowHeadersVisible = false;
            this.dgv_themes.Size = new System.Drawing.Size(224, 268);
            this.dgv_themes.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Theme";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 495);
            this.Controls.Add(this.pnl_previewScreen);
            this.Controls.Add(this.btn_rightJust);
            this.Controls.Add(this.btn_midJust);
            this.Controls.Add(this.btn_leftJust);
            this.Controls.Add(this.cmb_font);
            this.Controls.Add(this.pnl_themes);
            this.Controls.Add(this.btn_loadSamp);
            this.Controls.Add(this.dgv_lyrics);
            this.Controls.Add(this.btn_display);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lyrics)).EndInit();
            this.pnl_themes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_themes)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel pnl_previewScreen;
        private System.Windows.Forms.Button btn_addTheme;
        private System.Windows.Forms.DataGridView dgv_themes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

