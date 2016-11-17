using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaUnitariaDeOrdenamiento
{
    class Burbuja
    {
        public void ordenar(int[] arr)
        {
            Console.ReadLine();
            bool cambio = true;
            while(cambio)
            {
                cambio = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        cambio = true;
                    }
                }
            }
        }

        public void ultimo(int[] arr)
        {

        }
    }
}
