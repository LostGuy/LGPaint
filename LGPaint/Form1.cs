using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGPaint
{
    public partial class Form1 : Form
    {
        //Fields
        bool paint = false;
        SolidBrush color;

        public Form1()
        {
            InitializeComponent();

            //Change canvas' background
            canvas.BackColor = Color.White;
        }

        //Close the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Create grapchis object
            Graphics graphics = canvas.CreateGraphics();

            //Clear the canvas
            graphics.Clear(canvas.BackColor);
        }

        //MouseUp event for the panel, turns paint to false to quit painting
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        //MouseDown event for the panel, turns paint to true to start painting
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        //MouseMove event for the panel
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //Paint if the mouse is down
            if(paint)
            {
                //Pick a color
                //ToDo: Add more colors
                color = new SolidBrush(Color.Black);

                Graphics g = canvas.CreateGraphics();

                //Paint on the mouse location
                //ToDo: Allow a size changer
                g.FillEllipse(color, e.X, e.Y, 500, 10);
                g.Dispose();


            }
        }
    }
}
