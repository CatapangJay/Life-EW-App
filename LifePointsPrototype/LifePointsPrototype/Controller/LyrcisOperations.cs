using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePointsPrototype.Controller {
    public class LyrcisOperations {
        public Model.LyricsModel lyricsMod;

        public LyrcisOperations() {
        }
        public List<string> SelectLyrics() {
            //var lyricSample = lyrics.sampLyrics;
            return lyricsMod.sampLyrics;
        }

        public void ProjectLyrics(Label lyricProj, string lyrictoDisp) {
            lyricProj.Text = lyrictoDisp;
        }
    }
}
