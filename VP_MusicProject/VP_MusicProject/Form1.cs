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
        private int formTempo;  // chosen in the form, and sent to the composition
        private bool nextHigher; // if true next generated notes will be an octave above
        private bool nextLower; // if true next generated notes will be an octave below 
        OutputDevice outputDevice;
        private List<MyNote> generatedNotes; 
        enum NoteTranslator
        {
            C01,Csharp01, D01, Dsharp01, E01, F01, Fsharp01, G01, Gsharp01, A01, Asharp01, B01,
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

        

        public Form1()
        {
            InitializeComponent();
            octave = 60;
            nextHigher = false;
            nextLower = false;
            formTempo = 200;
            openOutputDevice();
            generatedNotes = new List<MyNote>();
            generateNotes();
            composition = new MyComposition(formTempo);

        }

        
        private void openOutputDevice()
        {
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
            composition.setTempo(formTempo);
            composition.play(outputDevice);
        }

        
    

       
        
        

        private void rbSlow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSlow.Checked == true)
            {
                formTempo = 80;
            }
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked == true)
            {
                formTempo = 120;
            }
        }

        private void rbFast_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFast.Checked == true)
            {
                formTempo = 160;
            }
        }

        


        private void btnN1_Click(object sender, EventArgs e)
        {
            MyComposition comp1 = new MyComposition(formTempo);
            comp1.addNote(generatedNotes.ElementAt(0));
            comp1.play(outputDevice);
        }

        

        private void btnN2_Click(object sender, EventArgs e)
        {
            MyComposition comp1 = new MyComposition(formTempo);
            comp1.addNote(generatedNotes.ElementAt(1));
            comp1.play(outputDevice);
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            MyComposition comp1 = new MyComposition(formTempo);
            comp1.addNote(generatedNotes.ElementAt(2));
            comp1.play(outputDevice);
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            MyComposition comp1 = new MyComposition(formTempo);
            comp1.addNote(generatedNotes.ElementAt(3));
            comp1.play(outputDevice);
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            MyComposition comp1 = new MyComposition(formTempo);
            comp1.addNote(generatedNotes.ElementAt(4));
            comp1.play(outputDevice);
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            MyComposition comp1 = new MyComposition(formTempo);
            comp1.addNote(generatedNotes.ElementAt(5));
            comp1.play(outputDevice);
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (rbN1.Checked)
            {
                composition.addNote(generatedNotes.ElementAt(0));
                rbN1.Checked = false;
            }
            if (rbN2.Checked)
            {
                composition.addNote(generatedNotes.ElementAt(1));
                rbN2.Checked = false;
            }
            if (rbN3.Checked)
            {
                composition.addNote(generatedNotes.ElementAt(2));
                rbN3.Checked = false;
            }
            if (rbN4.Checked)
            {
                composition.addNote(generatedNotes.ElementAt(3));
                rbN4.Checked = false;
            }
            if (rbN5.Checked)
            {
                composition.addNote(generatedNotes.ElementAt(4));
                rbN5.Checked = false;
            }
            if (rbN6.Checked)
            {
                composition.addNote(generatedNotes.ElementAt(5));
                rbN6.Checked = false;
            }

            showLastSix();

        }

        private void btnNewNotes_Click(object sender, EventArgs e)
        {
            generateNotes();
        }

        
        private void PlayLastSix_Click(object sender, EventArgs e)
        {
            int compositionLength = composition.getLength();
            if(compositionLength > 6)
            {
                List<MyNote> lastSix = composition.getLastSix();
                MyComposition comp = new MyComposition(formTempo);

                foreach (MyNote n in lastSix)
                {
                    comp.addNote(n);
                }

                comp.play(outputDevice);
            }
            else
            {
                composition.setTempo(formTempo);
                composition.play(outputDevice);
            }
            
        }

        private void DeleteSelectedNote_Click(object sender, EventArgs e)
        {   
            
            if (rbn11.Checked)
            {
                composition.removeLastSixAt(0);
                rbn11.Checked = false;
            }
            if (rbn12.Checked)
            {
                composition.removeLastSixAt(1);
                rbn12.Checked = false;
            }
            if (rbn13.Checked)
            {
                composition.removeLastSixAt(2);
                rbn13.Checked = false;
            }
            if (rbn14.Checked)
            {
                composition.removeLastSixAt(3);
                rbn14.Checked = false;
            }
            if (rbn15.Checked)
            {
                composition.removeLastSixAt(4);
                rbn15.Checked = false;
            }
            if (rbn16.Checked)
            {
                composition.removeLastSixAt(5);
                rbn16.Checked = false;
            }

            showLastSix();
        }

        

       

        private void EditComposition_Click(object sender, EventArgs e)
        {
            // to open new form in which composition can be edited
        }

       

        private void PlaySample_Click(object sender, EventArgs e)
        {
            MyComposition comp = new MyComposition(formTempo);
            comp.addNote(new MyNote(64, 1));
            comp.addNote(new MyNote(64, 1));
            comp.addNote(new MyNote(65, 1));
            comp.addNote(new MyNote(67, 1));
            comp.addNote(new MyNote(67, 1));
            comp.addNote(new MyNote(65, 1));
            comp.addNote(new MyNote(64, 1));
            comp.addNote(new MyNote(62, 1));
            comp.addNote(new MyNote(60, 1));
            comp.addNote(new MyNote(60, 1));
            comp.addNote(new MyNote(62, 1));
            comp.addNote(new MyNote(64, 1));
            comp.addNote(new MyNote(64, 2));
            comp.addNote(new MyNote(62, 1));
            comp.addNote(new MyNote(62, 1));
            comp.play(outputDevice);
        }

        private void GenerateHigherNotes_Click_1(object sender, EventArgs e)
        {
            nextHigher = true;
        }

        private void GenerateLowerNotes_Click_1(object sender, EventArgs e)
        {
            nextLower = true;
        }

        private void GenerateLowerNotes_Click(object sender, EventArgs e)
        {
            nextLower = true;
        }

        private void GenerateHigherNotes_Click(object sender, EventArgs e)
        {
            nextHigher = true;
        }

        public void showLastSix()
        {
            if (composition.getLength() > 6)
            {
                List<MyNote> lastSix = composition.getLastSix();
                button11.Text = ((NoteTranslator)(lastSix.ElementAt(0).myPitch)).ToString()
                    + " - " + (lastSix.ElementAt(0).myDurationInBeats).ToString() + " beats";
                button12.Text = ((NoteTranslator)(lastSix.ElementAt(1).myPitch)).ToString()
                    + " - " + (lastSix.ElementAt(1).myDurationInBeats).ToString() + " beats";
                button13.Text = ((NoteTranslator)(lastSix.ElementAt(2).myPitch)).ToString()
                    + " - " + (lastSix.ElementAt(2).myDurationInBeats).ToString() + " beats";
                button14.Text = ((NoteTranslator)(lastSix.ElementAt(3).myPitch)).ToString()
                    + " - " + (lastSix.ElementAt(3).myDurationInBeats).ToString() + " beats";
                button15.Text = ((NoteTranslator)(lastSix.ElementAt(4).myPitch)).ToString()
                    + " - " + (lastSix.ElementAt(4).myDurationInBeats).ToString() + " beats";
                button16.Text = ((NoteTranslator)(lastSix.ElementAt(5).myPitch)).ToString()
                    + " - " + (lastSix.ElementAt(5).myDurationInBeats).ToString() + " beats";
            }
            else
            {
                button11.Text = "no note";
                button12.Text = "no note";
                button13.Text = "no note";
                button14.Text = "no note";
                button15.Text = "no note";
                button16.Text = "no note";
            }
        }

        private void generateNotes()
        {
            generatedNotes.Clear();

            if (nextLower)
            {
                octave -= 12;

            }
            if (nextHigher)
            {
                octave += 12;
            }

            nextLower = false;
            nextHigher = false;

            Random random = new Random();


            int notePitch = random.Next(octave, octave + 11);
            int beatsDuration = random.Next(1, 4);
            generatedNotes.Add(new MyNote(notePitch, beatsDuration));
            string noteName = ((NoteTranslator)notePitch).ToString();
            btnN1.Text = $"{noteName} \n {beatsDuration.ToString()} beats";

            notePitch = random.Next(octave, octave + 11);
            beatsDuration = random.Next(1, 4);
            generatedNotes.Add(new MyNote(notePitch, beatsDuration));
            noteName = ((NoteTranslator)notePitch).ToString();
            btnN2.Text = $"{noteName} \n {beatsDuration.ToString()} beats";

            notePitch = random.Next(octave, octave + 11);
            beatsDuration = random.Next(1, 4);
            generatedNotes.Add(new MyNote(notePitch, beatsDuration));
            noteName = ((NoteTranslator)notePitch).ToString();
            btnN3.Text = $"{noteName} \n {beatsDuration.ToString()} beats";

            notePitch = random.Next(octave, octave + 11);
            beatsDuration = random.Next(1, 4);
            generatedNotes.Add(new MyNote(notePitch, beatsDuration));
            noteName = ((NoteTranslator)notePitch).ToString();
            btnN4.Text = $"{noteName} \n {beatsDuration.ToString()} beats";

            notePitch = random.Next(octave, octave + 11);
            beatsDuration = random.Next(1, 4);
            generatedNotes.Add(new MyNote(notePitch, beatsDuration));
            noteName = ((NoteTranslator)notePitch).ToString();
            btnN5.Text = $"{noteName} \n {beatsDuration.ToString()} beats";

            notePitch = random.Next(octave, octave + 11);
            beatsDuration = random.Next(1, 4);
            generatedNotes.Add(new MyNote(notePitch, beatsDuration));
            noteName = ((NoteTranslator)notePitch).ToString();
            btnN6.Text = $"{noteName} \n {beatsDuration.ToString()} beats";
        }
    }
}
