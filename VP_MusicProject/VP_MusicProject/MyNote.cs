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
        public int myPitch { get; set; } // values 60-71
        public int myDuration { get; set; } //values 1 - 4

        public MyNote(int pitch, int duration)
        {
            this.myPitch = pitch;
            this.myDuration = duration;
        }

        public NoteOnMessage noteStart(OutputDevice outputDevice, int counter)
        {
            return new NoteOnMessage(outputDevice, myChannel, (Pitch)myPitch, myVelocity, counter);
        }

        public NoteOffMessage noteEnd(OutputDevice outputDevice, int counter)
        {
            return new NoteOffMessage(outputDevice, myChannel, (Pitch)myPitch, myVelocity, counter + myDuration);
        }

    }
}
