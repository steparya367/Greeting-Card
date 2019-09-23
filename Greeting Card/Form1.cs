using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greeting_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen drawPen = new Pen(Color.Black, 10);
            Font titleFont = new Font("Arial", 20);
            drawBrush.Color = Color.FromArgb(160, 255, 0, 0);
            g.Clear(Color.MidnightBlue);
            g.DrawString("Happy Birthday Darnell", titleFont, drawBrush, 275, 215);
            g.Clear(Color.Black);
            //2nd Frame 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen drawPen = new Pen(Color.Black, 10);
            Font titleFont = new Font("Arial", 20);
            drawBrush.Color = Color.FromArgb(160, 255, 0, 0);
            g.Clear(Color.MidnightBlue);
            g.DrawString("Have a good One", titleFont, drawBrush, 275, 215);
        }

    }
    }

