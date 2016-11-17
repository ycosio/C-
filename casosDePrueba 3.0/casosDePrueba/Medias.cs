using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casosDePrueba
{
    class Medias
    {
        public static double mediaAritmetica(int[] vals)
        {
            return vals.Average();
        }

        public static double raizEnesimo(double x, int n)
        {
            double y = (double)1 / n;
            return Math.Pow(x, y);
        }

        public static double mediaGeometrica(params int[] vals)
        {
            double multi = 1;
            for (int i = 0; i < vals.Length; i++)
                multi *= vals[i];

            return raizEnesimo(multi, vals.Length);
        }

        public static double mediaArmonica(params int[] vals)
        {
            return 0.0;
        }
    }
}