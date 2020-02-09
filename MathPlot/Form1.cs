using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathPlot
{
    public partial class Form1 : Form
    {
        private const double Xmin = 0.0;
        private const double Xmax = 10.0;
        private const double Xstep = 0.1;
        private const double Ymin = -2.0;
        private const double Ymax = 2.0;

        private const int CX = 10;
        private const int CY = 150;
        private const int XPOS = 10;
        private const int YPOS = 10;
        private const int XWIDTH = 500;
        private const int YHEIGHT = 300;
        private const double GX = XWIDTH / (Xmax - Xmin);     /* width        */
        private const double GY = -YHEIGHT / (Ymax - Ymin);    /* height       */

        /*===== initialize =====*/
        public Form1()
        {
            InitializeComponent();
        }


        /*===== paint handler =====*/
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            /*----- draw graph area -----*/
            SolidBrush brushWhite = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(brushWhite, XPOS, YPOS, XWIDTH, YHEIGHT);
            brushWhite.Dispose();

            /*----- draw graph -----*/
            Pen blackPen = new Pen(Color.Black);

            double a = double.Parse(textBoxA.Text);
            for (double x = Xmin; x <= Xmax - Xstep; x += Xstep)
            {
                double y0 = Math.Sin(a * x);
                double y1 = Math.Sin(a * (x + Xstep));
                //double y0 = 1.0 / (1.0 + x * x);
                //double y1 = 1.0 / (1.0 + (x + Xstep) * (x + Xstep));

                int gx0 = CX + (int)(x * GX);
                int gy0 = CY + (int)(y0 * GY);
                int gx1 = CX + (int)((x + Xstep) * GX);
                int gy1 = CY + (int)(y1 * GY);
                e.Graphics.DrawLine(blackPen, gx0, gy0, gx1, gy1);

            }

        }

        /*===== Graph button click =====*/
        private void buttonGraph_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
