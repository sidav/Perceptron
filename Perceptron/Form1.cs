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
        Perceptron prcp;
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
            prcp = new Perceptron();
            grphcs = this.CreateGraphics();
            Grid.setGrphcs(grphcs);
            Grid.clearGrid();
            Grid.drawGridOnly();
            //grphcs.DrawRectangle(myPen, 0, 0, 400, 400);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Grid.getInput(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
                Grid.eraseInput(e.X, e.Y);
            Grid.drawGridOnly();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Grid.getInput(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
                Grid.eraseInput(e.X, e.Y);
            Grid.drawGridOnly();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Grid.clearGrid();
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grid.moveTheDrawedToCorner();
            Grid.scaletheDrawed();
            TeachBtn.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grid.scaletheDrawed();
        }

        private void RecognizeBtn_Click(object sender, EventArgs e)
        {
            int res = prcp.Recognize();
            if (res == 0)
                label1.Text = "Я думаю, это "+prcp.category1+".";
            else
                label1.Text = "Я думаю, это "+prcp.category2+".";
            label1.Visible = true;
        }

        private void TeachBtn_Click(object sender, EventArgs e)
        {
            prcp.DeltaRule();
            label1.Text += "\nДельта-правило применено.";
            TeachBtn.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            prcp.setCat1(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            prcp.setCat2(textBox2.Text);
        }
    }
}
