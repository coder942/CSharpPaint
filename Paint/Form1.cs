using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Point _startPoint;
        private Graphics _graphics;
        private Pen _pen;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this._graphics = pictureBox.CreateGraphics();
            this._pen = new Pen(Color.Black, 2);

            btnActivateColor.BackColor = Color.Black;

            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseMove += PictureBox_MouseMove;
            pictureBox.MouseUp += PictureBox_MouseUp;
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            this._startPoint = Point.Empty;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this._startPoint.IsEmpty)
            {
                this._graphics.DrawLine(this._pen, this._startPoint, e.Location);
                this._startPoint = e.Location;
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            
            this._startPoint = e.Location;
        }

        private void red_Click(object sender, EventArgs e)
        {
            btnActivateColor.BackColor = Color.Red;
            this._pen = new Pen(Color.Red, 2);
        }

        private void blue_Click(object sender, EventArgs e)
        {
            btnActivateColor.BackColor = Color.Blue;
            this._pen = new Pen(Color.Blue, 2);
        }

        private void green_Click(object sender, EventArgs e)
        {
            btnActivateColor.BackColor = Color.Green;
            this._pen = new Pen(Color.Green, 2);
        }

        private void black_Click(object sender, EventArgs e)
        {
            btnActivateColor.BackColor = Color.Black;
            this._pen = new Pen(Color.Black, 2);
        }

        private void white_Click(object sender, EventArgs e)
        {
            btnActivateColor.BackColor = Color.White;
            this._pen = new Pen(Color.White, 2);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileFullName = $"c:\\Draw\\Draw_Picture_{DateTime.Now.Ticks}.png";

            var bitmaps = new Bitmap(pictureBox.Width, pictureBox.Height);
            var graphics = Graphics.FromImage(bitmaps);

            var rectangle = pictureBox.RectangleToScreen(pictureBox.ClientRectangle);
            graphics.CopyFromScreen(rectangle.Location, Point.Empty, pictureBox.Size);

            bitmaps.Save(fileFullName);

            Process.Start(fileFullName);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}
