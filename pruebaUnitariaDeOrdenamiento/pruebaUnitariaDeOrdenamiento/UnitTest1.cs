using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.IO;

namespace pruebaUnitariaDeOrdenamiento
{
    [TestClass]
    public class UnitTest1
    {
        private int[] resultado = new int[] {1,2,3,4,5};
        private Burbuja ordena = new Burbuja();
        private string[,] datos = Lector.leer("pruebasArreglos.txt");
        private char[] delimitador = { ' ' };
        private int x = 0;
        private string file = Lector.crearArchivo();

        [TestMethod]
        public void ordenado()
        {
            int[] entrada = (datos[0, 2].Split(delimitador)).Select(s => int.TryParse(s, out x) ? x : 0).ToArray();
            ordena.ordenar(entrada);
            Lector.ejecutar(0, file, !resultado.Equals(entrada));
            CollectionAssert.AreEqual(resultado,entrada);
        }

        [TestMethod]
        public void pruebaUltimo()
        {
            int[] entrada = (datos[1, 2].Split(delimitador)).Select(s => int.TryParse(s, out x) ? x : 0).ToArray();
            ordena.ordenar(entrada);
            Lector.ejecutar(1, file, !resultado.Equals(entrada));
            CollectionAssert.AreEqual(resultado, entrada);
        }

        [TestMethod]
        public void contiguos()
        {
            int[] entrada = (datos[2, 2].Split(delimitador)).Select(s => int.TryParse(s, out x) ? x : 0).ToArray();
            ordena.ordenar(entrada);
            Lector.ejecutar(2, file, !resultado.Equals(entrada));
            CollectionAssert.AreEqual(resultado, entrada);
        }

        [TestMethod]
        public void AlFinal()
        {
            int[] entrada = (datos[3, 2].Split(delimitador)).Select(s => int.TryParse(s, out x) ? x : 0).ToArray();
            ordena.ordenar(entrada);
            Lector.ejecutar(3, file, !resultado.Equals(entrada));
            CollectionAssert.AreEqual(resultado, entrada);
        }

        [TestMethod]
        public void inverso()
        {
            int[] entrada = (datos[4, 2].Split(delimitador)).Select(s => int.TryParse(s, out x) ? x : 0).ToArray();
            ordena.ordenar(entrada);
            Lector.ejecutar(4, file, !resultado.Equals(entrada));
            CollectionAssert.AreEqual(resultado, entrada);
        }

        [TestMethod]
        public void repetido()
        {
            int[] salida2 = new int[] { 1, 2, 2, 3, 5 };
            int[] entrada = (datos[5, 2].Split(delimitador)).Select(s => int.TryParse(s, out x) ? x : 0).ToArray();
            ordena.ordenar(entrada);
            Lector.ejecutar(5, file, !resultado.Equals(entrada));
            CollectionAssert.AreEqual(salida2, entrada);
        }
    }
}
