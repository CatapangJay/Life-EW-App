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
    public partial class Form_Project : Form {
        public Form1 parent; 
        public Controller.ThemeOperations themeOps;
        public Form_Project() {
            InitializeComponent();
            //DisplayOnScreen2();
        }

        public void SetDefaultTheme() {
            themeOps.SetTheme(lbl_lyricDisp, this.BackColor);
        }

        private void DisplayOnScreen2() {

            //this.Location = Screen.AllScreens(Top(Screen.AllScreens))
            for (int i = 0; i < Screen.AllScreens.Count(); i++) {
                //if
            }

            var secScreen = Screen.AllScreens[1];
            this.Location = secScreen.Bounds.Location;
            //foreach (Screen screen in Screen.AllScreens) {
            //    //Second Screen

            //}
        }
    }
}
