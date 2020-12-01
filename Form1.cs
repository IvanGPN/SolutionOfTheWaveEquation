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

            DataTable dt = new DataTable();

            for (int j = 0; j < 11; j++)
            {
                dt.Columns.Add(new DataColumn());
            }


            for (int i = 0; i < 10; i++)
                {
                chart1.Series.Add(Convert.ToString(i));
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                DataRow dr = dt.NewRow();
                for (int j = 0; j< 11; j++)
                {
                    chart1.Series[i].Points.AddXY(h, result[i,j]);
                    h += 0.1;
                    dr[j] = result[i, j];
                }
                dt.Rows.Add(dr);
                h = 0;
                
            }
            dataGridView1.DataSource = dt;
        }
    }
}
