using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
{
    public partial class Form1 : Form
    {
        Card card1 = new Card(10, Properties.Resources.jack_of_spades);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = card1.img;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
