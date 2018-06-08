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

        private MyComposition composition;
        private int octave; // the starting notePitch in the current octave
        private int tempo;  // chosen in the form, and sent to the composition
        private bool nextHigher; 
        private bool nextLower;
        enum NoteTranslator
        {
            C01,C01sharp, D01, D01sharp, E01, F01, F01sharp, G01, G01sharp, A01, A01sharp, B01,
            C0, C0sharp, D0, D0sharp, E0, F0, F0sharp, G0, G0sharp, A0, A0sharp, B0,
            C1, C1sharp, D1, D1sharp, E1, F1, Fsharp1, G1, Gsharp1, A1, Asharp1, B1,
            C2, C2sharp, D2, D2sharp, E2, F2, F2sharp, G2, G2sharp, A2, A2sharp, B2,
            C3, C3sharp, D3, D3sharp, E3, F3, F3sharp, G3, G3sharp, A3, A3sharp, B3,
            C4, C4harp,  D4, D4sharp, E4, F4, F4sharp, G4, G4sharp, A4, A4sharp, B4,
            C5, C5sharp, D5, D5sharp, E5, F5, F5sharp, G5, G5sharp, A5, A5sharp, B5,
            C6, C6sharp, D6, D6sharp, E6, F6, F6sharp, G6, G6sharp, A6, A6sharp, B6,
            C7, C7sharp, D7, D7sharp, E7, F7, F7sharp, G7, G7sharp, A7, A7sharp, B7,
            C8, Cs8harp, D8, D8sharp, E8, F8, F8sharp, G8, G8sharp, A8, A8sharp, B8,
            C9, C9sharp, D9, D9sharp, E9, F9, F9sharp, G9, G9sharp, A9, A9sharp, B9,

        };

        OutputDevice outputDevice;

        public Form1()
        {
            InitializeComponent();
            octave = 60;
            nextHigher = false;
            nextLower = false;
            outputDevice = ExampleUtil.ChooseOutputDeviceFromConsole();
            if (outputDevice == null)
            {
                Console.WriteLine("No output devices, so can't run this example.");
                ExampleUtil.PressAnyKeyToContinue();
                return;
            }
            outputDevice.Open();

            Console.WriteLine("Playing an arpeggiated C chord and then bending it down.");
            outputDevice.SendControlChange(Channel.Channel1, Midi.Control.SustainPedal, 0);
            outputDevice.SendPitchBend(Channel.Channel1, 8192);
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            composition = new MyComposition();
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pbPlayButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nextLower)
            {
                octave -= 11;
            }
            if (nextHigher)
            {
                octave += 11;
            }

            Random random = new Random();


            int notePitch = random.Next(octave + 60, octave + 72);
            int beatsDuration = random.Next(1, 4);
            string noteName = ((NoteTranslator)notePitch).ToString();
            btnN1.Text = noteName.Substring(0, 1) + " - " + beatsDuration.ToString() + " beats";

            notePitch = random.Next(octave + 60, octave + 72);
            beatsDuration = random.Next(1, 4);
            noteName = ((NoteTranslator)notePitch).ToString();
            btnN2.Text = noteName.Substring(0, 1) + " - " + beatsDuration.ToString() + " beats";

            notePitch = random.Next(octave + 60, octave + 72);
            beatsDuration = random.Next(1, 4);
            noteName = ((NoteTranslator)notePitch).ToString();
            btnN3.Text = noteName.Substring(0, 1) + " - " + beatsDuration.ToString() + " beats";

            notePitch = random.Next(octave + 60, octave + 72);
            beatsDuration = random.Next(1, 4);
            noteName = ((NoteTranslator)notePitch).ToString();
            btnN4.Text = noteName.Substring(0, 1) + " - " + beatsDuration.ToString() + " beats";

            notePitch = random.Next(octave + 60, octave + 72);
            beatsDuration = random.Next(1, 4);
            noteName = ((NoteTranslator)notePitch).ToString();
            btnN5.Text = noteName.Substring(0, 1) + " - " + beatsDuration.ToString() + " beats";

            notePitch = random.Next(octave + 60, octave + 72);
            beatsDuration = random.Next(1, 4);
            noteName = ((NoteTranslator)notePitch).ToString();
            btnN6.Text = noteName.Substring(0, 1) + " - " + beatsDuration.ToString() + " beats";
        }
        
        
        private void btnN5_Click(object sender, EventArgs e)
        {

        }

        private void btnN6_Click(object sender, EventArgs e)
        {

        }

        private void rbSlow_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MyComposition comp = new MyComposition(100);
            comp.addNote(new MyNote(61, 1));
            comp.addNote(new MyNote(62, 1));
            comp.addNote(new MyNote(63, 1));
            comp.addNote(new MyNote(64, 1));
            comp.addNote(new MyNote(65, 1));
            comp.play(outputDevice);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nextLower = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nextHigher = true;
        }

        private void rbN4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbN3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
