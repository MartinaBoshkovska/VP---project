using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace VP_MusicProject
{

    public partial class Form1 : Form
    {

        private MyComposition composition;
        private int octave; // the starting notePitch in the current octave
        private int formTempo;  // chosen in the form, and sent to the composition
        OutputDevice outputDevice;
        private List<MyNote> generatedNotes;

        private List<Components> compositionHistory;

        //---for saving and loading purposes----
        public String FileName { get; private set; }
        


        public Form1()
        {
            InitializeComponent();
            octave = 60;
            formTempo = 200;
            openOutputDevice();
            generatedNotes = new List<MyNote>();
            generateNotes();
            composition = new MyComposition(formTempo);
            compositionHistory = new List<Components>();
            radioButton3.Checked = true;
            //disableButtons();
        }

       

        //public void disableButtons()
        //{
        ////    rbn11.Enabled = false;
        //    rbn12.Enabled = false;
        //    rbn13.Enabled = false;
        //    rbn14.Enabled = false;
        //    rbn15.Enabled = false;
        //    rbn16.Enabled = false;
        //    button11.Enabled = false;
        //    button12.Enabled = false;
        //    button13.Enabled = false;
        //    button14.Enabled = false;
        //    button15.Enabled = false;
        //    button16.Enabled = false;
        //}


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

            //Console.WriteLine("Playing an arpeggiated C chord and then bending it down.");
            outputDevice.SendControlChange(Channel.Channel1, Midi.Control.SustainPedal, 0);
            outputDevice.SendPitchBend(Channel.Channel1, 8192);
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);

        }


        //  -----------------------------------  PLAY ---------------------------------------------------------

        private void pbPlayButton_Click(object sender, EventArgs e)
        {
            composition.setTempo(formTempo);
            composition.play(outputDevice);
            picGraph.Invalidate();
            //Invalidate();
        }

        //  -----------------------------------  TEMPO ---------------------------------------------------------


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

        //  -----------------------------------  PRESLUSHUVANJE SINGLE NOTE ---------------------------------------------------------


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


        //  -----------------------------------  ADD NOTE ---------------------------------------------------------

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            List<MyNote> toDebug = generatedNotes;

            var checkedButton = gbNotes.Controls.OfType<RadioButton>()
                                       .FirstOrDefault(r => r.Checked);
            if (checkedButton == null)
                return;

            if (rbN1.Checked)
            {
                composition.addNote(new MyNote(generatedNotes.ElementAt(0).myPitch, generatedNotes.ElementAt(0).myDurationInBeats));
                rbN1.Checked = false;
            }
            if (rbN2.Checked)
            {
                composition.addNote(new MyNote(generatedNotes.ElementAt(1).myPitch, generatedNotes.ElementAt(1).myDurationInBeats));
                rbN2.Checked = false;
            }
            if (rbN3.Checked)
            {
                composition.addNote(new MyNote(generatedNotes.ElementAt(2).myPitch, generatedNotes.ElementAt(2).myDurationInBeats));
                //composition.addNote(generatedNotes.ElementAt(2));
                rbN6.Checked = false;
            }
            if (rbN4.Checked)
            {
                composition.addNote(new MyNote(generatedNotes.ElementAt(3).myPitch, generatedNotes.ElementAt(3).myDurationInBeats));         
                rbN3.Checked = false;
            }
            if (rbN5.Checked)
            {
                composition.addNote(new MyNote(generatedNotes.ElementAt(4).myPitch, generatedNotes.ElementAt(4).myDurationInBeats));
                rbN4.Checked = false;
            }
            if (rbN6.Checked)
            {
                composition.addNote(new MyNote(generatedNotes.ElementAt(5).myPitch, generatedNotes.ElementAt(5).myDurationInBeats));
                rbN5.Checked = false;
            }

            fillPanel();
            //showLastSix();
            generateNotes(); //generate new six notes on each note addition to the composition
            clearGeneratedChecked();
            picGraph.Invalidate();
            //Invalidate();
        }


        //----------------------------------- PANEL -------------------------------------------------------------------


        private void fillPanel()
        {

            panel1.Controls.Clear();
            int radioY = 53;
            int buttonY = 10;
            int counter = 0;
            int currentButton = 10;
            int currentRadio = 37;
            int increment = 80;
            foreach (MyNote n in composition.getListNotes())
            {

                panel1.HorizontalScroll.Value = 0;

                Button button = new Button();
                RadioButton radioButton = new RadioButton();

                button.Height = 40;
                button.Width = 70;
                radioButton.Width = 35;
                
                //button.Tag = counter;
                radioButton.Tag = counter;


                button.Location = new Point(currentButton, buttonY);
                radioButton.Location = new Point(currentRadio, radioY);

                compositionHistory.Add(new Components(button, radioButton));

                currentRadio += increment;
                currentButton += increment;

                button.Text = n.ToString();

                button.Click += (s, e) => {
                    MyComposition comp = new MyComposition(formTempo);
                    comp.addNote(n);
                    comp.play(outputDevice);
                };

                panel1.Controls.Add(button);
                panel1.Controls.Add(radioButton);

                panel1.ScrollControlIntoView(button);
                counter++;
            }


        }

        private void panel1_ControlAdded_1(object sender, ControlEventArgs e)
        {
            panel1.ScrollControlIntoView(e.Control);
        }


        private void btnNewNotes_Click(object sender, EventArgs e)
        {
            enableRadios();
            changeOctave();
            generateNotes();
            clearGeneratedChecked();

        }

        private void enableRadios()
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void changeOctave()
        {
            if (radioButton1.Checked)
                octave += 12;
            if (radioButton2.Checked)
                octave -= 12;

            if (octave <= 48)
            {
                octave = 48;
                radioButton2.Enabled = false;
            }

            if (octave >= 72)
            {
                octave = 72;
                radioButton1.Enabled = false;
            }

        }

        private void clearGeneratedChecked()
        {
            rbN1.Checked = false;
            rbN2.Checked = false;
            rbN3.Checked = false;
            rbN4.Checked = false;
            rbN5.Checked = false;
            rbN6.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
        }

        

        private void PlayLastSix_Click(object sender, EventArgs e)
        {
            int compositionLength = composition.getLength();
            if(compositionLength > 6)
            {
                List<MyNote> lastSix = composition.getLastSix();
                MyComposition.play(lastSix,formTempo,outputDevice);
            }
            else
            {
                composition.setTempo(formTempo);
                composition.play(outputDevice);
            }
            
        }
        //  -----------------------------------  DELETE SELECTED ---------------------------------------------------------

        //private void DeleteSelectedNote_Click(object sender, EventArgs e)
        //{   
            
        //    if (rbn11.Checked)
        //    {
        //        composition.removeLastSixAt(0);
        //        rbn11.Checked = false;
        //    }
        //    if (rbn12.Checked)
        //    {
        //        composition.removeLastSixAt(1);
        //        rbn12.Checked = false;
        //    }
        //    if (rbn13.Checked)
        //    {
        //        composition.removeLastSixAt(2);
        //        rbn13.Checked = false;
        //    }
        //    if (rbn14.Checked)
        //    {
        //        composition.removeLastSixAt(3);
        //        rbn14.Checked = false;
        //    }
        //    if (rbn15.Checked)
        //    {
        //        composition.removeLastSixAt(4);
        //        rbn15.Checked = false;
        //    }
        //    if (rbn16.Checked)
        //    {
        //        composition.removeLastSixAt(5);
        //        rbn16.Checked = false;
        //    }

        //    showLastSix();
        //    picGraph.Invalidate();
                
        //}

        private void generatePanelComponents()
        {
            
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

        

        //public void showLastSix()
        //{


        //    if (composition.getLength() > 6)
        //    {

        //        List<MyNote> lastSix = composition.getLastSix();
        //        for (int i = 0; i < 6; i++)
        //        {
        //            int num = i + 11;
        //            string name = "button" + num;
        //            System.Windows.Forms.Control ctn = gbLastSix.Controls[name];
        //            ctn.Text = lastSix.ElementAt(i).ToString();
        //        }
            
        //    }
        //    else
        //    {
        //        int n = composition.getLength();
        //        List<MyNote> lastN = composition.getLastN(n);
        //        for (int i = 0; i < 6; i++)
        //        {
        //            int num = i + 11;
        //            string name = "button" + num;
        //            string radioButtonName = "rbn" + num;
        //            System.Windows.Forms.Control ctn = gbLastSix.Controls[name];
        //            System.Windows.Forms.Control radioButton = gbLastSix.Controls[radioButtonName];
        //            if (i < n)
        //            {
        //                ctn.Text = lastN.ElementAt(i).ToString();
        //                ctn.Enabled = true;
        //                radioButton.Enabled = true;


        //            }
        //            else
        //            {
        //                ctn.Text = "no note";
        //                ctn.Enabled = false;
        //                radioButton.Enabled = false;
        //            }


        //        }
        //    }
            
        //}

        private void generateNotes()
        {
            generatedNotes = new List<MyNote>();

            Random random = new Random();

            int notePitch = random.Next(octave, octave + 12);
            int beatsDuration = random.Next(1, 4);
            MyNote toAddNext = new MyNote(notePitch, beatsDuration);
            generatedNotes.Add(toAddNext);
            btnN1.Text = toAddNext.ToString();

            notePitch = random.Next(octave, octave + 12);
            beatsDuration = random.Next(1, 4);
            toAddNext = new MyNote(notePitch, beatsDuration);
            generatedNotes.Add(toAddNext);
            btnN2.Text = toAddNext.ToString();

            notePitch = random.Next(octave, octave + 11);
            beatsDuration = random.Next(1, 4);
            toAddNext = new MyNote(notePitch, beatsDuration);
            generatedNotes.Add(toAddNext);
            btnN3.Text = toAddNext.ToString();

            notePitch = random.Next(octave, octave + 11);
            beatsDuration = random.Next(1, 4);
            toAddNext = new MyNote(notePitch, beatsDuration);
            generatedNotes.Add(toAddNext);
            btnN4.Text = toAddNext.ToString();

            notePitch = random.Next(octave, octave + 11);
            beatsDuration = random.Next(1, 4);
            toAddNext = new MyNote(notePitch, beatsDuration);
            generatedNotes.Add(toAddNext);
            btnN5.Text = toAddNext.ToString();

            notePitch = random.Next(octave, octave + 11);
            beatsDuration = random.Next(1, 4);
            toAddNext = new MyNote(notePitch, beatsDuration);
            generatedNotes.Add(toAddNext);
            btnN6.Text = toAddNext.ToString();


        }
    


        // ---------------------- playing last 6 ---------------------
        

        private void button11_Click(object sender, EventArgs e)
        {
            List<MyNote> posledni = composition.getLastSix();
            MyComposition singleNote = new MyComposition(formTempo);
            singleNote.addNote(posledni.ElementAt(0));
            singleNote.play(outputDevice);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<MyNote> posledni = composition.getLastSix();
            MyComposition singleNote = new MyComposition(formTempo);
            singleNote.addNote(posledni.ElementAt(1));
            singleNote.play(outputDevice);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            List<MyNote> posledni = composition.getLastSix();
            MyComposition singleNote = new MyComposition(formTempo);
            singleNote.addNote(posledni.ElementAt(2));
            singleNote.play(outputDevice);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            List<MyNote> posledni = composition.getLastSix();
            MyComposition singleNote = new MyComposition(formTempo);
            singleNote.addNote(posledni.ElementAt(3));
            singleNote.play(outputDevice);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            List<MyNote> posledni = composition.getLastSix();
            MyComposition singleNote = new MyComposition(formTempo);
            singleNote.addNote(posledni.ElementAt(4));
            singleNote.play(outputDevice);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            List<MyNote> posledni = composition.getLastSix();
            MyComposition singleNote = new MyComposition(formTempo);
            singleNote.addNote(posledni.ElementAt(5));
            singleNote.play(outputDevice);

        }

        private void picGraph_Click(object sender, EventArgs e)
        {

        }

        private void picGraph_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bufl = new Bitmap(picGraph.Width, picGraph.Height);
            Pen pnr = new Pen(Color.Red, 1.5f);
            Pen png = new Pen(Color.Green, 1.5f);
            using (Graphics g = Graphics.FromImage(bufl))
            {
                
                g.FillRectangle(Brushes.MidnightBlue, new Rectangle(0, 0,
                    picGraph.Width, picGraph.Height));

                g.DrawLine(png, 0, picGraph.Height / 2, picGraph.Width, picGraph.Height / 2);

                composition.Draw(g, pnr);

                //for (int i = 1; i < composition.notes.Count; i++)
                //{
                //    g.DrawLine(pnr, (i - 1) * 5, 75 - (float)Math.Pow(composition.notes.ElementAt(i - 1).myPitch - 47, 1.22),
                //    i * 5, 75 - (float)Math.Pow(composition.notes.ElementAt(i).myPitch - 47, 1.22));
                //}

                g.SmoothingMode = SmoothingMode.AntiAlias;
                picGraph.CreateGraphics().DrawImageUnscaled(bufl, 0, 0);
                picGraph.Refresh();
            }
            
        }

        private void rbMedium_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbMedium.Checked)
            {
                formTempo = 200;
            }
                
        }

        private void rbFast_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbFast.Checked)
            {
                formTempo = 250;
            }
        }

        private void rbSlow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbSlow.Checked)
            {
                formTempo = 150;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void pbPlayButton_Click_1Async(object sender, EventArgs e)
        {
            pbPlayButton.Image = Properties.Resources.playPressed;
            composition.setTempo(formTempo);
            composition.play(outputDevice);
            picGraph.Invalidate();
            await Task.Delay(composition.getTotalDuration() + 500);
            pbPlayButton.Image = Properties.Resources.Play;
            //Invalidate();
        }

        //private void rbN4_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void rbN6_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void gbLastSix_Enter(object sender, EventArgs e)
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            var checkedButton = panel1.Controls.OfType<RadioButton>()
                                       .FirstOrDefault(r => r.Checked);
            composition.removeAt((int)checkedButton.Tag);
            fillPanel();
        }


        //----------------------------SAVING FILES--------------------------------------

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String oldName = FileName;
            FileName = null;
            saveToolStripMenuItem_Click(sender, e);
            if (FileName == null)
                FileName = oldName;
        }

        public void SaveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Composed music files (*.cmf)|*.cmf";
                saveFileDialog.Title = "Save composed music";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, composition);
                }
            }
        }


        // ----------------------- NEW FILE AND OPEN FILE ------------------------
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openFile()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Composed music files (*.cmf)|*.cmf";
            openFileDialog.Title = "Open composed music file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        composition = (MyComposition)formater.Deserialize(fileStream);
                        generateNotes();
                        rbMedium.Checked = true;
                        compositionHistory = new List<Components>();
                        fillPanel();
                        radioButton3.Checked = true;
                        picGraph.Invalidate(true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        

        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            composition = new MyComposition(200); //medium tempo is 200
            generateNotes();
            rbMedium.Checked = true;
            compositionHistory = new List<Components>();
            panel1.Controls.Clear();
            radioButton3.Checked = true;
            picGraph.Invalidate(true);
            
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //const string helpMessage =
            //        "Are you sure that you would like to close the form?";
            //const string caption = "Instruction manual";
            //MessageBox.Show(helpMessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult clearMessageBox = MessageBox.Show("Do you really want to clear this form?",
            "Reset Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (clearMessageBox == DialogResult.Yes)
            {
                //thisMessageTextBox.Text = "";
                //thisGenrePictureBox.Image = null;
            }

        }
    }
}
