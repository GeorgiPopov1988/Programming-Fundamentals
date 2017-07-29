using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Distance_between_Points_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turtle.Forward(60);
            Turtle.Rotate(90);
            Turtle.Forward(60);
            Turtle.Rotate(90);
            Turtle.Forward(60);
            Turtle.Rotate(90);
            Turtle.Forward(60);
            Turtle.Rotate(90);
        }
    }
}
