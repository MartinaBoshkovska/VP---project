using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;

namespace VP_MusicProject
{
    public class MyNote
    {
        public static readonly int myVelocity = 80;
        public static readonly Channel myChannel = Channel.Channel1;
        public int myPitch { get; set; } 
        public int myDurationInBeats { get; set; }
        enum NoteTranslator
        {
            C01, Csharp01, D01, Dsharp01, E01, F01, Fsharp01, G01, Gsharp01, A01, Asharp01, B01,
            C0, Csharp0, D0, Dsharp0, E0, F0, Fsharp0, G0, Gsharp0, A0, Asharp0, B0,
            C1, Csharp1, D1, Dsharp1, E1, F1, Fsharp1, G1, Gsharp1, A1, Asharp1, B1,
            C2, Csharp2, D2, Dsharp2, E2, F2, Fsharp2, G2, Gsharp2, A2, Asharp2, B2,
            C3, Csharp3, D3, Dsharp3, E3, F3, Fsharp3, G3, Gsharp3, A3, Asharp3, B3,
            C4, Csharp4, D4, Dsharp4, E4, F4, Fsharp4, G4, Gsharp4, A4, Asharp4, B4,
            C5, Csharp5, D5, Dsharp5, E5, F5, Fsharp5, G5, Gsharp5, A5, Asharp5, B5,
            C6, Csharp6, D6, Dsharp6, E6, F6, Fsharp6, G6, Gsharp6, A6, Asharp6, B6,
            C7, Csharp7, D7, Dsharp7, E7, F7, Fsharp7, G7, Gsharp7, A7, Asharp7, B7,
            C8, Csharp8, D8, Dsharp8, E8, F8, Fsharp8, G8, Gsharp8, A8, Asharp8, B8,
            C9, Csharp9, D9, D9sharp, E9, F9, Fsharp9, G9, Gsharp9, A9, Asharp9, B9,

        };

        public override string ToString()
        {
            string s = ((NoteTranslator)myPitch).ToString()
                     + " - " + (myDurationInBeats).ToString() + " beats";
            return s;
        }

        public MyNote(int pitch, int duration)
        {
            this.myPitch = pitch;
            this.myDurationInBeats = duration;
        }

        public NoteOnMessage noteStart(OutputDevice outputDevice, int position)
        {
            int tryPitch = myPitch;
            return new NoteOnMessage(outputDevice, myChannel, (Pitch)myPitch, myVelocity, position);
        }

        public NoteOffMessage noteEnd(OutputDevice outputDevice, int position)
        {
            return new NoteOffMessage(outputDevice, myChannel, (Pitch)myPitch, myVelocity, position + myDurationInBeats);
        }

        

    }
}