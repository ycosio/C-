using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mate
{
    class Prueba
    {
<<<<<<< HEAD:mate/mate/prueba.cs
=======

        private static string[,] datos = new string[6, 4];
        private static int filas = 0;
        private static string archivo = "pruebasArreglos.txt";

        static void Main(string[] args)
        {

            try
            {

                string line;
                char[] delimitador = { ':' };

                System.IO.StreamReader file = new System.IO.StreamReader(archivo);

                while ((line = file.ReadLine()) != null)
                {
                    datos[filas, 0] = line.Split(delimitador)[0];
                    datos[filas, 1] = line.Split(delimitador)[1];
                    datos[filas, 2] = line.Split(delimitador)[2];
                    datos[filas, 3] = line.Split(delimitador)[3];

                    filas++;
                }

                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


>>>>>>> 27b2bbc5307278d272dd61a67be64d7c286bbdf2:tddparaburbuja/Program.cs
    }
}
