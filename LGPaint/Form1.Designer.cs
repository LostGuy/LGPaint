﻿namespace LGPaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.changeColorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolsHeader = new System.Windows.Forms.Label();
            this.widthTrackBar = new System.Windows.Forms.TrackBar();
            this.brushWidth = new System.Windows.Forms.Label();
            this.brushHeightLabel = new System.Windows.Forms.Label();
            this.heightTrackBar = new System.Windows.Forms.TrackBar();
            this.openButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.changeCanvasColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(822, 559);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(56, 26);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(977, 559);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 26);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // changeColorButton
            // 
            this.changeColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeColorButton.Location = new System.Drawing.Point(857, 35);
            this.changeColorButton.Name = "changeColorButton";
            this.changeColorButton.Size = new System.Drawing.Size(148, 35);
            this.changeColorButton.TabIndex = 3;
            this.changeColorButton.Text = "Change Brush Color";
            this.changeColorButton.UseVisualStyleBackColor = true;
            this.changeColorButton.Click += new System.EventHandler(this.changeColorButton_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // toolsHeader
            // 
            this.toolsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolsHeader.AutoSize = true;
            this.toolsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsHeader.Location = new System.Drawing.Point(911, 12);
            this.toolsHeader.Name = "toolsHeader";
            this.toolsHeader.Size = new System.Drawing.Size(38, 13);
            this.toolsHeader.TabIndex = 4;
            this.toolsHeader.Text = "Tools";
            // 
            // widthTrackBar
            // 
            this.widthTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widthTrackBar.Location = new System.Drawing.Point(876, 89);
            this.widthTrackBar.Maximum = 100;
            this.widthTrackBar.Minimum = 1;
            this.widthTrackBar.Name = "widthTrackBar";
            this.widthTrackBar.Size = new System.Drawing.Size(104, 45);
            this.widthTrackBar.TabIndex = 5;
            this.widthTrackBar.Value = 1;
            this.widthTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.widthTrackBar_MouseUp);
            // 
            // brushWidth
            // 
            this.brushWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brushWidth.AutoSize = true;
            this.brushWidth.Location = new System.Drawing.Point(897, 73);
            this.brushWidth.Name = "brushWidth";
            this.brushWidth.Size = new System.Drawing.Size(65, 13);
            this.brushWidth.TabIndex = 6;
            this.brushWidth.Text = "Brush Width";
            // 
            // brushHeightLabel
            // 
            this.brushHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brushHeightLabel.AutoSize = true;
            this.brushHeightLabel.Location = new System.Drawing.Point(894, 137);
            this.brushHeightLabel.Name = "brushHeightLabel";
            this.brushHeightLabel.Size = new System.Drawing.Size(68, 13);
            this.brushHeightLabel.TabIndex = 8;
            this.brushHeightLabel.Text = "Brush Height";
            // 
            // heightTrackBar
            // 
            this.heightTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.heightTrackBar.Location = new System.Drawing.Point(876, 153);
            this.heightTrackBar.Maximum = 100;
            this.heightTrackBar.Minimum = 1;
            this.heightTrackBar.Name = "heightTrackBar";
            this.heightTrackBar.Size = new System.Drawing.Size(104, 45);
            this.heightTrackBar.TabIndex = 7;
            this.heightTrackBar.Value = 1;
            this.heightTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.heightTrackBar_MouseUp);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(857, 195);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(148, 33);
            this.openButton.TabIndex = 9;
            this.openButton.Text = "Open Image";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(897, 559);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(60, 25);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.Location = new System.Drawing.Point(13, 13);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(803, 571);
            this.canvas.TabIndex = 13;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // changeCanvasColorButton
            // 
            this.changeCanvasColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeCanvasColorButton.Location = new System.Drawing.Point(857, 250);
            this.changeCanvasColorButton.Name = "changeCanvasColorButton";
            this.changeCanvasColorButton.Size = new System.Drawing.Size(148, 35);
            this.changeCanvasColorButton.TabIndex = 14;
            this.changeCanvasColorButton.Text = "Change Canvas Color";
            this.changeCanvasColorButton.UseVisualStyleBackColor = true;
            this.changeCanvasColorButton.Click += new System.EventHandler(this.changeCanvasColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 597);
            this.Controls.Add(this.changeCanvasColorButton);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.brushHeightLabel);
            this.Controls.Add(this.heightTrackBar);
            this.Controls.Add(this.brushWidth);
            this.Controls.Add(this.widthTrackBar);
            this.Controls.Add(this.toolsHeader);
            this.Controls.Add(this.changeColorButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button changeColorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label toolsHeader;
        private System.Windows.Forms.TrackBar widthTrackBar;
        private System.Windows.Forms.Label brushWidth;
        private System.Windows.Forms.Label brushHeightLabel;
        private System.Windows.Forms.TrackBar heightTrackBar;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button changeCanvasColorButton;
    }
}

