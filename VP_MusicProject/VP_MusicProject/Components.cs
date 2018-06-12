using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;

namespace VP_MusicProject
{
    public class Components
    {
        System.Windows.Forms.Control radioButton;
        System.Windows.Forms.Control button;

        public Components(System.Windows.Forms.Control r, System.Windows.Forms.Control b)
        {
            radioButton = r;
            button = b;
        }

    }
}