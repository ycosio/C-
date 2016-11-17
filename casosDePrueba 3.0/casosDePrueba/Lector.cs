using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casosDePrueba
{
    class Lector
    {
        private string[,] datos = new string[15, 4];



        public void ejecutar()
        {
            //    string[] elementos2;
            //    char[] delimitador = { ' ' };
            //    string resultado="";
            //    int x=0;

            //    decimal esperado = 0;
            //    decimal y = 0;

            //    int exitosos = 0;
            //    int fallidos = 0;
            //string nombre = "Prueba echa el " + DateTime.Now.ToString() + "txt";
            //nombre = nombre.Replace("/", "-").Replace(":", ",");
            //Console.WriteLine(nombre);
            //StreamWriter file = File.CreateText(@"C:\Users\ycosio\Documents\Visual Studio 2015\Projects\casosDePrueba 2.0\" + nombre);

            //    for (int i=0; i<filas; i++)
            //    {
            //        System.Diagnostics.Stopwatch temporizador = new Stopwatch();
            //        temporizador.Start();

            //        resultado = "";
            //        elementos2 = datos[i, 2].Split(delimitador);
            //        int[] elementos = new int[elementos2.Length];

            //            for (int j = 0; j < (elementos2).Length; j++)
            //            {
            //                if (int.TryParse(elementos2[j], out x))
            //                    elementos[j] = System.Convert.ToInt16(elementos2[j]);
            //                else if(String.IsNullOrEmpty(elementos2[j]) || elementos2[j]=="NULL")
            //                    elementos[j] = 0;
            //                else
            //                {
            //                    elementos2[j] = "'" + elementos2[j] + "'";
            //                    resultado = "error";
            //                }
            //            }



            //        if (decimal.TryParse(datos[i, 3], out y))
            //            esperado = decimal.Round(System.Convert.ToDecimal(datos[i, 3]), 2);

            //        System.Console.ForegroundColor = ConsoleColor.Green;
            //        if (resultado == "error")
            //        {
            //            System.Console.ForegroundColor = ConsoleColor.Red; 
            //            resultado="Prueba fallida(Elementos no numericos)";
            //            fallidos++;
            //        }
            //        else
            //        {
            //            switch (datos[i, 1])
            //            {
            //                case "mediaAritmetica":
            //                    resultado = Medias.mediaAritmetica(elementos).ToString();
            //                    if (decimal.Round(System.Convert.ToDecimal(Medias.mediaAritmetica(elementos)), 2) != esperado)
            //                    {
            //                        System.Console.ForegroundColor = ConsoleColor.Red;
            //                        resultado = System.Convert.ToDecimal(Medias.mediaAritmetica(elementos)) + " :Prueba fallida(Resultado esperado equivocado)";
            //                        fallidos++;
            //                    }
            //                    else
            //                        exitosos++;
            //                    break;
            //                case "mediaGeometrica":
            //                    resultado = Medias.mediaGeometrica(elementos).ToString();
            //                    if (decimal.Round(System.Convert.ToDecimal(Medias.mediaGeometrica(elementos)), 2) != esperado)
            //                    {
            //                        System.Console.ForegroundColor = ConsoleColor.Red;
            //                        resultado = resultado + " :Prueba fallida(Resultado esperado equivocado)";
            //                        fallidos++;
            //                    }
            //                    else
            //                        exitosos++;
            //                    break;
            //                default:
            //                    System.Console.ForegroundColor = ConsoleColor.Red;
            //                    resultado = "Prueba fallifa(Metodo no implementado)";
            //                    fallidos++;
            //                    break;
            //            }
            //        }
            //        temporizador.Stop();

            //        System.Console.WriteLine("Caso de prueba: " + datos[i, 0]);
            //        file.WriteLine("Caso de prueba: " + datos[i, 0]);
            //        System.Console.WriteLine("Operacion: " + datos[i, 1]);
            //        file.WriteLine("Operacion: " + datos[i, 1]);
            //        System.Console.WriteLine("Datos: " + string.Join(" ", elementos2));
            //        file.WriteLine("Datos: " + string.Join(" ", elementos2));
            //        System.Console.WriteLine("Tiempo transcurrido: " + temporizador.Elapsed.ToString());
            //        file.WriteLine("Tiempo transcurrido: " + temporizador.Elapsed.ToString());
            //        System.Console.WriteLine("Resultado: " + resultado);
            //        file.WriteLine("Resultado: " + resultado);
            //        System.Console.WriteLine("Esperado: " + datos[i,3]);
            //        file.WriteLine("Esperado: " + datos[i,3]);
            //        System.Console.WriteLine();
            //        file.WriteLine();
            //    }

            //    System.Console.WriteLine("Exitosos: " + exitosos + " Fallidos: " + fallidos);
            //    file.WriteLine("Exitosos: " + exitosos + " Fallidos: " + fallidos);
            //    System.Console.WriteLine();
            //    file.WriteLine();
            //    file.Close();
            //    System.Console.ReadLine();
            //}


        }
    }
}