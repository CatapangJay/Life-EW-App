using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePointsPrototype.Model {
    public class SystemModels {

        public List<string> SystemFonts;

        public SystemModels() {
            SystemFonts = new List<string>();
            foreach (var font in System.Drawing.FontFamily.Families) {
                SystemFonts.Add(font.Name);
            }
        }

        public class ActiveTheme {
            public string Name { get; set; }
            public System.Drawing.Font ActiveFont { get; set; }
            public System.Drawing.Color ActiveBgColor { get; set; }
            public string activeLoopPath { get; set; }
        }
    }
}
