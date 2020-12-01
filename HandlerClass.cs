using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Явный_шаблок_крестик
{
    public class HandlerClass
    {
        static public double[,] Calculate()
        {
            double s = 0.1;
            double h = 0.1;
            double q = 1;
            double a = 1;

            double[,] array = new double[10, 11];

            for (int i = 0; i < 10; i++)
                array[i, 0] = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i == 0)
                    {
                        array[i, j] = 0.2 * (1 - s) * Math.Sin(Math.PI * s);
                        s += 0.1;
                    }
                    else if (i == 1)
                    {
                        s = 0.1;
                        array[i, j] = array[i - 1, j] + s * 0;
                    }
                    else if (i > 1)
                    {
                        array[i, j] = q * (array[i - 1, j - 1] - 2 * array[i - 1, j] + array[i - 1, j + 1]) + 2 * array[i - 1, j] - array[i - 2, j];
                    }
                    
                }
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        if (j + i > 10)
            //            array[i, j] += 1;
            //    }
            //}
                    

            for (int i = 0; i < 10; i++)
                array[i, 10] = 0;

            return array;
        }
    }
}
