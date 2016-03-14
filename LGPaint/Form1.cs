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

        //Used to paint
        SolidBrush brush;
        Color color = Color.Black;

        //Width and height of the brush
        int width = 10;
        int height = 10;

        public Form1()
        {
            InitializeComponent();

            //Change the title of the window
            this.Text = "Lost Guy Paint";

            //Change canvas' background
            canvas.BackColor = Color.White;

            //Set the track bars to the default width and height
            widthTrackBar.Value = width;
            heightTrackBar.Value = height;
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
                brush = new SolidBrush(color);

                Graphics g = canvas.CreateGraphics();

                //Paint on the mouse location
                g.FillEllipse(brush, e.X, e.Y, width, height);
                g.Dispose();
            }
        }

        //Opens up a ColorDialog for the user to change colors
        private void changeColorButton_Click(object sender, EventArgs e)
        {
            //Open the ColorDialog
            DialogResult result = colorDialog1.ShowDialog();

            //Check to see if the user clicked OK
            if (result == DialogResult.OK)
            {
                this.color = colorDialog1.Color;
            }

        }

        //Change the brush's width
        private void widthTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.width = widthTrackBar.Value;
        }

        //Change the brush's height
        private void heightTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.height = heightTrackBar.Value;
        }

        //Opens a file explorer so the user can open an image
        private void openButton_Click(object sender, EventArgs e)
        {
            //Set the dialogs filter
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            //Set the background image to what the user selected
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Scale the image upon load to fit the canvas
                //ToDo: Make a scaling canvas
                this.canvas.BackgroundImage = new Bitmap(Image.FromFile(openFileDialog1.FileName), new Size(canvas.Width, canvas.Height));
            }
        }
    }
}
