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

        private const double GX = 800.0 / (Xmax - Xmin);     /* width        */
        private const double GY = -400.0 / (Ymax - Ymin);    /* height       */
        private const int CX = 400;
        private const int CY = 200;

        /*===== initialize =====*/
        public Form1()
        {
            InitializeComponent();
        }


        /*===== paint handler =====*/
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            double a = double.Parse(textBoxA.Text);
            for(double x = Xmin; x < Xmax; x += Xstep)
            {
                double y = Math.Sin(a * x);
            }

        }

        /*===== Graph button click =====*/
        private void buttonGraph_Click(object sender, EventArgs e)
        {

        }
    }
}
