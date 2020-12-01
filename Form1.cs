using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Явный_шаблок_крестик
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            double[,] result = HandlerClass.Calculate();

            double h = 0;

            

            for (int i = 0; i < 10; i++)
            {
                chart1.Series.Add(Convert.ToString(i));
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                for (int j = 0; j< 11; j++)
                {
                    chart1.Series[i].Points.AddXY(h, result[i,j]);
                    h += 0.1;
                    textBox1.Text += "\t" + result[i, j];
                }
                h = 0;
                textBox1.Text += "\r\n";
            }
        }
    }
}
