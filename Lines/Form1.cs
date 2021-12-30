using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lines
{
    public partial class Form1 : Form
    {
        static int xStart, xEnd, yStart, yEnd;
        static int Length = 0, Angle = 0, Increment = 0;
        int red = 255, green = 0, blue = 0;
        Graphics g = null;
        Pen pen = new Pen(Color.Red, 1);
        Point Start, End;
        Random rand = new Random();

        private void rbWhite_CheckedChanged(object sender, EventArgs e)
        {
            canvas.BackColor = Color.White;
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            canvas.BackColor = Color.Black;
        }

        public Form1()
        {
            InitializeComponent();
            InfoForm f = new InfoForm();
            f.ShowDialog();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int tb = trackBar1.Value;

            if (trackBar1.Value <= 10)
            {
                red = 255;
                green = trackBar1.Value * 25;
                blue = 0;
            }
            else if (trackBar1.Value > 10 && trackBar1.Value <= 20)
            {
                tb -= 10;

                red = 255 - tb * 25;
                green = 255;
                blue = 0;
            }
            else if (trackBar1.Value > 20 && trackBar1.Value <= 30)
            {
                tb -= 20;

                red = 0;
                green = 255;
                blue = tb * 25;
            }
            else if (trackBar1.Value > 30 && trackBar1.Value <= 40)
            {
                tb -= 30;

                red = 0;
                green = 255 - tb * 25;
                blue = 255;
            }
            else if (trackBar1.Value > 40 && trackBar1.Value <= 50)
            {
                tb -= 40;

                red = tb * 25;
                green = 0;
                blue = 255;
            }
            else if (trackBar1.Value > 50 && trackBar1.Value <= 60)
            {
                tb -= 50;

                red = 255;
                green = 0;
                blue = 255 - tb * 25;
            }
            else if (trackBar1.Value > 60 && trackBar1.Value <= 70)
            {
                tb -= 60;

                red = tb * 25 + 5;
                green = tb * 25 + 5;
                blue = tb * 25 + 5;
            }


            trackBar1.BackColor = Color.FromArgb(red, green, blue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Length = Int32.Parse(tbLength.Text);
                Angle = Int32.Parse(tbAngle.Text);
                Increment = Int32.Parse(tbIncrement.Text);
            }
            catch (Exception ex)
            { }

            xStart = canvas.Width / 2;
            yStart = canvas.Height / 2;

            canvas.Invalidate();
        }

        private void draw()
        {
            xEnd = (int)(xStart + (Length * Math.Cos(Math.PI * Angle / 180)));
            yEnd = (int)(yStart + (Length * Math.Sin(Math.PI * Angle / 180)));

            Start = new Point(xStart, yStart);
            End = new Point(xEnd, yEnd);

            g.DrawLine(pen, Start, End);

            xStart = xEnd;
            yStart = yEnd;

            Length = Length + Increment;
            Angle = Angle + Int32.Parse(tbAngle.Text);

            pen.Color = Color.FromArgb(red, green, blue);
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            try
            {
                for (int i = 0; i < Int32.Parse(tbNzmOfLines.Text); i++)
                {
                    draw();
                }
            }
            catch (Exception)
            { }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            xStart = canvas.Width / 2;
            yStart = canvas.Height / 2;

            //button1.PerformClick();
        }

        private void canvas_Click(object sender, EventArgs e)
        {
            try
            {
                Length = Int32.Parse(tbLength.Text);
                Angle = Int32.Parse(tbAngle.Text);
                Increment = Int32.Parse(tbIncrement.Text);
            }
            catch (Exception ex)
            { }

            xStart = this.PointToClient(Cursor.Position).X;
            yStart = this.PointToClient(Cursor.Position).Y - 47;

            canvas.Invalidate();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            XY.Text = "X: " + this.PointToClient(Cursor.Position).X + "  |  Y: " + (this.PointToClient(Cursor.Position).Y - 47);
        }


    }
}
