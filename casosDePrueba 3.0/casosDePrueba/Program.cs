using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casosDePrueba
{
    class Program
    {
        public static ArrayList casos = new ArrayList();
        public static string resultado="Exitoso";
        public static int exitosos = 0;
        public static int fallidos = 0;

        static void Main(string[] args)
        {
            leer();
        }

        public static void leer()
        {
            try
            {
                string archivo;
                Console.Write("Ubicacion del archivo: ");
                archivo = Console.ReadLine();
                System.Console.WriteLine();
                int n = 0;
                int x = 0;
                string line;
                char[] delimitador = { ':' };

                string nombre = "Prueba echa el " + DateTime.Now.ToString() + "txt";
                nombre = nombre.Replace("/", "-").Replace(":", ",");
                Console.WriteLine(nombre);
                StreamWriter file2 = File.CreateText(@"C:\Users\ycosio\Documents\Visual Studio 2015\Projects\casosDePrueba 3.0\" + nombre);

                System.IO.StreamReader file = new System.IO.StreamReader(archivo);

                while ((line = file.ReadLine()) != null)
                {
                    string[] parametro = line.Split(delimitador);

                    char[] delimitador2 = { ' ' };
                    string[] elementos2 = parametro[2].Split(delimitador2);
                    int[] elementos = new int[0];

                    if (parametro[1] != "mediaGeometrica" && parametro[1] != "mediaAritmetica")
                    {
                        resultado = "Prueba fallida(Metodo no implementado)";
                        fallidos++;
                    }
                    else
                    {  
                        elementos = new int[elementos2.Length];

                        for (int j = 0; j < (elementos2).Length; j++)
                        {
                            if (int.TryParse(elementos2[j], out x))
                                elementos[j] = System.Convert.ToInt16(elementos2[j]);
                            else if (String.IsNullOrEmpty(elementos2[j]) || elementos2[j] == "NULL")
                                elementos[j] = 0;
                            else
                            {
                                elementos2[j] = "'" + elementos2[j] + "'";
                                resultado = "Prueba fallida(Datos no numericos)";
                                fallidos++;
                            }
                        }
                    }

                    if (resultado == "Exitoso")
                        casos.Add(new Prueba(parametro[0], parametro[1], elementos, parametro[3]));
                    else
                        casos.Add(new Prueba(parametro[0], parametro[1], string.Join(" ", elementos2),parametro[3]));

                    Console.ForegroundColor = ConsoleColor.Green;
                    resolver((Prueba)casos[n],n);

                    file2.WriteLine("Indentificador: " + ((Prueba)casos[n]).getIdentificador());
                    file2.WriteLine("Operacion: " + ((Prueba)casos[n]).getMetodo());
                    file2.WriteLine("Datos: " + ((Prueba)casos[n]).getCadenaDatos());
                    file2.WriteLine("Resultado: " + resultado);
                    //file2.WriteLine("Tiempo transcurrido: " + temporizador.Elapsed.ToString());
                    file2.WriteLine("Esperado: " + ((Prueba)casos[n]).getEsperado());

                    file2.WriteLine();
                    n++;
                    resultado = "Exitoso";
                }

                Console.WriteLine("Exitosos: " + exitosos + ", Fallidos: " + fallidos);
                Console.ReadLine();

                file2.WriteLine("Exitosos: " + exitosos + ", Fallidos: " + fallidos);
                file2.WriteLine();
                file.Close();
                file2.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void resolver(Prueba prueba, int i)
        {
            Stopwatch temporizador = new Stopwatch();
            decimal x = 0;

            if (resultado == "Exitoso")
            {
                temporizador.Start();
                resultado = decimal.Round(System.Convert.ToDecimal(((Prueba)casos[i]).getReultado(((Prueba)casos[i]).getMetodo())), 2).ToString();
                temporizador.Stop();

                if (decimal.TryParse(((Prueba)casos[i]).getEsperado(), out x))
                {
                    if (System.Convert.ToDecimal(resultado) != decimal.Round(System.Convert.ToDecimal(((Prueba)casos[i]).getEsperado()), 2))
                    {
                        resultado = "Prueba fallida(Resultado esperado equivocado)";
                        fallidos++;
                    }
                    else
                        exitosos++;
                }
                else
                {
                    resultado = "Prueba fallida(Resultado esperado equivocado)";
                    fallidos++;
                }

            }
          
            if (!decimal.TryParse(resultado, out x))
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Indentificador: " + ((Prueba)casos[i]).getIdentificador());
            Console.WriteLine("Operacion: " + ((Prueba)casos[i]).getMetodo());
            Console.WriteLine("Datos: " + ((Prueba)casos[i]).getCadenaDatos());
            Console.WriteLine("Resultado: " + resultado);
            Console.WriteLine("Tiempo transcurrido: " + temporizador.Elapsed.ToString()); 
            Console.WriteLine("Esperado: " + ((Prueba)casos[i]).getEsperado());
            Console.WriteLine();
        }

    }
}
