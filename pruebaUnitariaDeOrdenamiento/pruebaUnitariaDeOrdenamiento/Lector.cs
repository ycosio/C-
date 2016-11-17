using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaUnitariaDeOrdenamiento
{
    class Lector
    {
        private static string[,] datos = new string[6, 4];
        private static int filas = 0;

        public static string[,] leer(string archivo)
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
                return datos;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return datos;
            }
        }

        public static void ejecutar(int prueba, string file2, bool resultado)
        {
            string[] elementos2;
            Burbuja ordenado = new Burbuja();
            char[] delimitador = { ' ' };
            int x = 0;
            StreamWriter file = File.AppendText(file2);
            System.Diagnostics.Stopwatch temporizador = new Stopwatch();

            elementos2 = datos[prueba, 2].Split(delimitador);
            int[] elementos = elementos2.Select(s => int.TryParse(s, out x) ? x : 0).ToArray();
            temporizador.Start();
            ordenado.ordenar(elementos);
            temporizador.Stop();
            int[] esperado = Array.ConvertAll(datos[prueba, 3].Split(delimitador), int.Parse);

            file.WriteLine("Caso de prueba: " + datos[prueba, 0]);
            file.WriteLine("Operacion: " + datos[prueba, 1]);
            file.WriteLine("Datos: " + string.Join(" ", elementos2));
            file.WriteLine("Tiempo transcurrido: " + temporizador.Elapsed.ToString());
            file.WriteLine("Resultado: " + resultado);
            file.WriteLine("Esperado: " + datos[prueba, 3]);
            file.WriteLine();
            //file.WriteLine("Exitosos: " + exitosos + " Fallidos: " + fallidos);
            //file.WriteLine();
            file.Close();
        }

        public static string crearArchivo()
        {
            string nombre = "Prueba echa el " + DateTime.Now.ToString() + "txt";
            nombre = nombre.Replace("/", "-").Replace(":", ",");
            string ruta = @"C:\Users\ycosio\Documents\Visual Studio 2015\Projects\pruebaUnitariaDeOrdenamiento\" + nombre;
            return ruta;
        }
    }
}
