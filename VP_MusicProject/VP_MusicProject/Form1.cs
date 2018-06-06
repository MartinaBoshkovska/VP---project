using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;

namespace VP_MusicProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //OutputDevice outputDevice = ExampleUtil.ChooseOutputDeviceFromConsole();
            //if (outputDevice == null)
            //{
            //    Console.WriteLine("No output devices, so can't run this example.");
            //    ExampleUtil.PressAnyKeyToContinue();
            //    return;
            //}
            //outputDevice.Open();

            //Console.WriteLine("Playing an arpeggiated C chord and then bending it down.");
            //outputDevice.SendControlChange(Channel.Channel1, Midi.Control.SustainPedal, 0);
            //outputDevice.SendPitchBend(Channel.Channel1, 8192);
            //// Play C, E, G in half second intervals.
            //outputDevice.SendNoteOn(Channel.Channel1, Pitch.C4, 80);
            //Thread.Sleep(500);
            //outputDevice.SendNoteOn(Channel.Channel1, Pitch.E4, 80);
            //Thread.Sleep(500);
            //outputDevice.SendNoteOn(Channel.Channel1, Pitch.G4, 80);
            //Thread.Sleep(500);

            //// Now apply the sustain pedal.
            //outputDevice.SendControlChange(Channel.Channel1, Midi.Control.SustainPedal, 127);

            //// Now release the C chord notes, but they should keep ringing because of the sustain
            //// pedal.
            //outputDevice.SendNoteOff(Channel.Channel1, Pitch.C4, 80);
            //outputDevice.SendNoteOff(Channel.Channel1, Pitch.E4, 80);
            //outputDevice.SendNoteOff(Channel.Channel1, Pitch.G4, 80);
        }
    }
}
