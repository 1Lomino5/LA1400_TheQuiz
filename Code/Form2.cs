using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace _1400_Programm
{
    public partial class Form2 : Form
    {
        
        public Form2(Form1 points)
        {
            InitializeComponent();
            int newpoints = points.points;
            string newpoints_ = Convert.ToString(newpoints);
            int showpoints = Convert.ToInt32(newpoints_);
            if (showpoints > 15)
            {
                label2.Text = "Herzlichen Glückwünsch Sie haben " + newpoints_ + " Punkte erreicht";
            }
            else
            {
                label2.Text = "Sie haben " + newpoints_ + " Punkte erreicht";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
