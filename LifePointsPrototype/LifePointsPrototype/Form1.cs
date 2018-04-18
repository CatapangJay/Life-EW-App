using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifePointsPrototype
{
    public partial class Form1 : Form
    {
        public Controller.LyrcisOperations lyrcisOps;
        public Controller.SystemOperations sysOps;
        public Controller.ThemeOperations themeOps;
        public Views.Form_Project secScreen;
        public Model.SystemModels.ActiveTheme actTheme;
        public Model.SystemModels sysModel;
        public Model.LyricsModel lyrcModels;
        public Form1()
        {
            InitializeComponent();
            InitializeMVC();
            sysOps.PopulateFonts(cmb_font);
            DisplayProjectScreen();
        }

        private void InitializeMVC() {

            actTheme = new Model.SystemModels.ActiveTheme();
            sysModel = new Model.SystemModels();
            lyrcModels = new Model.LyricsModel();
            lyrcisOps = new Controller.LyrcisOperations();
            sysOps = new Controller.SystemOperations();
            themeOps = new Controller.ThemeOperations();
            secScreen = new Views.Form_Project();

            lyrcisOps.lyricsMod = lyrcModels;
            sysOps.sysMod = sysModel;
            themeOps.actTheme = actTheme;

        }
        private void bnt_showfrm_Click(object sender, EventArgs e)
        {

        }

        private void DisplayOnScreen2()
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                //Second Screen
                
            }
        }

        private void btn_loadSamp_Click(object sender, EventArgs e) {
            List<string> lyrcsList = new List<string>();
            lyrcsList = lyrcisOps.SelectLyrics();
            foreach (string line in lyrcsList) {
                dgv_lyrics.Rows.Add(line);
            }
        }

        private void DisplayProjectScreen() {
            secScreen = new Views.Form_Project();
            secScreen.parent = this;
            secScreen.themeOps = themeOps;
            secScreen.SetDefaultTheme();

            //secScreen.TopLevel = false;
            //pnl_secScreen.Controls.Add(secScreen);
            secScreen.Show();
        }
        

        private void dgv_lyrics_CellClick(object sender, DataGridViewCellEventArgs e) {
            string selectedLyrics = dgv_lyrics.SelectedCells[0].Value.ToString();
            lyrcisOps.ProjectLyrics(secScreen.lbl_lyricDisp, selectedLyrics);
        }

        private void btn_addTheme_Click(object sender, EventArgs e) {
            Views.Form_ThemeEditor form_ThemeEditor = new Views.Form_ThemeEditor();
            form_ThemeEditor.parent = this;
            form_ThemeEditor.themeOps = themeOps;
            form_ThemeEditor.InitializeData();
            sysOps.ShowThemeEditor(form_ThemeEditor);
        }
    }
}
