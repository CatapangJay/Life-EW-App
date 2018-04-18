using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LifePointsPrototype.Controller {
    public class ThemeOperations {
        public Model.SystemModels.ActiveTheme actTheme;

        public ThemeOperations() {
        }
        public void SetTheme(Label lyricLabel, Color bgcolor, string loopPath = "") {
            actTheme.ActiveFont = lyricLabel.Font;
            actTheme.ActiveBgColor = bgcolor;
            actTheme.activeLoopPath = loopPath;
        }

        public void GetTheme(ref Label lyricLabel, ref Color bgcolor, ref string loopPath) {
            lyricLabel.Font = actTheme.ActiveFont;
            bgcolor = actTheme.ActiveBgColor;
            loopPath = actTheme.activeLoopPath;
        }
    }
}
