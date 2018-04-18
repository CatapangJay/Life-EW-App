using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifePointsPrototype.Views {
    public partial class Form_ThemeEditor : Form {
        public Controller.ThemeOperations themeOps;
        public Controller.SystemOperations sysOps;
        public Form1 parent;
        private Label thLbl;
        private Color thColor;
        private string thLoopPath = "";
        public Form_ThemeEditor() {
            InitializeComponent();
            thColor = new Color();
            thLbl = new Label();
        }

        private void btn_bgColors_Click(object sender, EventArgs e) {
            cd_bgColors.ShowDialog();
        }

        public void InitializeData() {
            parent.themeOps.GetTheme(ref thLbl, ref thColor, ref thLoopPath);
            Views.Form_Project prevForm = new Form_Project();
            prevForm.lbl_lyricDisp = thLbl;
            prevForm.BackColor = thColor;
            prevForm.TopLevel = false;
            pnl_preview.Controls.Add(prevForm);
            prevForm.Show();

            parent.sysOps.PopulateFonts(cmb_font);

        }
    }
}
