using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePointsPrototype.Controller {
    public class SystemOperations {
        public Model.SystemModels sysMod;

        public SystemOperations() {
        }
        public List<string> GetFonts() {
            return sysMod.SystemFonts;
        }

        public void PopulateFonts (ComboBox cmbFonts) {
            cmbFonts.Items.AddRange(GetFonts().ToArray<string>());
        }

        public void PopulateFontSizes(ComboBox cmbFontSize) {
            cmbFontSize.Items.AddRange(GetFonts().ToArray<string>());
        }

        public void ShowThemeEditor(Form themeEditor) {
            themeEditor.Show();
        }
    }
}
