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
        private int tempo;
        
        

        public Form1()
        {
            InitializeComponent();
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
            pbPlayButton.Image = VP_MusicProject.Properties.Resources.playPressed; //Image.FromFile(@"C:\Users\Martina\source\repos\VP-project-master\VP_MusicProject\VP_MusicProject\Resources\playPressed.png");

            OutputDevice outputDevice = ExampleUtil.ChooseOutputDeviceFromConsole();
            if (outputDevice == null)
            {
                Console.WriteLine("No output devices, so can't run this example.");
                ExampleUtil.PressAnyKeyToContinue();
                return;
            }
            outputDevice.Open();

            outputDevice.SendControlChange(Channel.Channel1, Midi.Control.SustainPedal, 0);
            outputDevice.SendPitchBend(Channel.Channel1, 8192);
            //PLAY THE MELODY
            composition.play(outputDevice);
            pbPlayButton.Image = Properties.Resources.Play;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
