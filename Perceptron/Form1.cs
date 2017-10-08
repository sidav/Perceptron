using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        public const int cellSize = 10;
        static Graphics grphcs;
        static SolidBrush myBrush;
        static Pen myPen;
        //myPen = new Pen(Color.FromArgb(255, r, g, b)); 

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DRAWING
        /// </summary>
        static void setColor(int r, int g, int b)
        {
            myBrush = new SolidBrush(Color.FromArgb(255, r, g, b));
            myPen = new Pen(Color.FromArgb(255, r, g, b));
        }

        /// <summary>
        /// That's all folks!
        /// </summary>

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            grphcs = this.CreateGraphics();
            Grid.setGrphcs(grphcs);
            Grid.clearGrid();
            Grid.draw();
            //grphcs.DrawRectangle(myPen, 0, 0, 400, 400);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Grid.getInput(e.X, e.Y);
            Grid.draw();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Grid.getInput(e.X, e.Y);
                Grid.draw();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Grid.clearGrid();
        }
    }
}
