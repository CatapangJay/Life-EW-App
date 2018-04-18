using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePointsPrototype.Model {
    public class LyricsModel {
        public List<string> sampLyrics = new List<string>();

        public LyricsModel() {
            sampLyrics.Add("This is the first Stanza verse \r\n This is 2nd Stanza verse \r\n This is Third Stanza verse");
            sampLyrics.Add("This is the first Stanza chorus \r\n This is 2nd Stanza chorus \r\n This is Third Stanza chorus");
            sampLyrics.Add("This is the first Stanza 2nd verse \r\n This is 2nd Stanza 2nd verse \r\n This is Third Stanza 2nd verse");
        }
    }
}
