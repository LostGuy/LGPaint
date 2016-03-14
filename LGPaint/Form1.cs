using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace LGPaint
{
    public partial class Form1 : Form
    {
        //Fields
        bool paint = false;
        Bitmap bmp;

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

            //Set the window size
            this.Width = Screen.FromControl(this).Bounds.Width;
            this.Height = Screen.FromControl(this).Bounds.Height;
            this.WindowState = FormWindowState.Maximized;

            //Set the image
            bmp = new Bitmap(canvas.ClientSize.Width, canvas.ClientSize.Height);
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

            //Clear set the background image to nothing
            canvas.BackgroundImage = null;

            //New image
            bmp = new Bitmap(canvas.ClientSize.Width, canvas.ClientSize.Height);
        }

        //MouseUp event for the panel, turns paint to false to quit painting
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        //MouseDown event for the panel, turns paint to true to start painting
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //Make sure it's the left mouse button
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            paint = true;
        }

        //MouseMove event for the panel
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //Paint if the mouse is down
            if(paint)
            {
                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    //Set the color
                    brush = new SolidBrush(color);

                    //Paint on the mouse location
                    gr.FillEllipse(brush, e.X, e.Y, width, height);
                }
            }

            canvas.Invalidate();
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
                this.canvas.BackgroundImage = new Bitmap(Image.FromFile(openFileDialog1.FileName), new Size(canvas.Width, canvas.Height));
            }
        }
       
        //Save the image
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Set the filters
            saveFileDialog1.Filter = "Image files (*.bmp, *.jpeg, *.png) | *.bmp; *.jpeg; *.png";

            //Open the save file dialog
            DialogResult dr = saveFileDialog1.ShowDialog();

            //Save the file as the correct type
            if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "bmp")
            {
                Bitmap bitmap = new Bitmap(canvas.Width, canvas.Height);
                canvas.DrawToBitmap(bitmap, new Rectangle(0, 0, canvas.Width, canvas.Height));
                bitmap.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
            }
            else if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "jpg")
            {
                Bitmap bitmap = new Bitmap(canvas.Width, canvas.Height);
                canvas.DrawToBitmap(bitmap, new Rectangle(0, 0, canvas.Width, canvas.Height));
                bitmap.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }
            else if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "png")
            {
                Bitmap bitmap = new Bitmap(canvas.Width, canvas.Height);
                canvas.DrawToBitmap(bitmap, canvas.Bounds);
                bitmap.Save(saveFileDialog1.FileName, ImageFormat.Png);
            }
        }

        //Paint the image
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        //Change the canvas color
        private void changeCanvasColorButton_Click(object sender, EventArgs e)
        {
            //Open the ColorDialog
            DialogResult result = colorDialog1.ShowDialog();

            //Check to see if the user clicked OK
            if (result == DialogResult.OK)
            {
                canvas.BackColor = colorDialog1.Color;
            }
        }
    }
}
