using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void shoeBackbutton_Click(object sender, EventArgs e)
        {
            cardbackpictureBox.Visible = false;
            cardbackpictureBox.Visible = true;
        }

        private void cardFacepictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cardbackpictureBox.Visible = false;
            cardbackpictureBox.Visible = true;
        }

        private void showFacebutton_Click(object sender, EventArgs e)
        {
            cardbackpictureBox.Visible = false;
            cardbackpictureBox.Visible = true;
        }
    }
}
