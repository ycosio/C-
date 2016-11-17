using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mate
{
    class Medios
    {

        public static double mediaAritmetica(params int[] vals) 
        {
            return vals.Average();
        }

        public static double raizEnesimo(double x, int n)
        {
            return Math.Pow(x,(1/n));
        }

        public static double mediaGeometrica(params int[] vals)
        {
            double multi=1;
            for (int i = 0; i < vals.Length; i++)
                multi *= vals[i];

            return Math.Round(raizEnesimo(multi,vals.Length));
        }

        public static double mediaArmonica(params int[] vals)
        {
            return 0.0;
        }


    }
}
