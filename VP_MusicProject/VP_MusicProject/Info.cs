using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_MusicProject
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            richTextBox1.Text = Instructions.toString();
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
