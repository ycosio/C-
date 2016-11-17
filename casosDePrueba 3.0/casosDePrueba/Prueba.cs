using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casosDePrueba
{
    class Prueba
    {
        private string identificador;
        private string metodo;
        private int[] datos;
        private string esperado;
        private string cadenaDatos;

        public Prueba(string id, string method, int[] data, string esp)
        {
            identificador = id;
            metodo = method;
            datos = data;
            esperado = esp;
            cadenaDatos = string.Join(" ", datos);
        }

        public Prueba(string id, string method, string cadenaD, string esp)
        {
            identificador = id;
            metodo = method;
            cadenaDatos = cadenaD;
            esperado = esp;
        }

        public string getIdentificador()
        {
            return identificador;
        }

        public string getMetodo()
        {
            return metodo;
        }

        public string getEsperado()
        {
            return esperado;
        }

        public string getCadenaDatos()
        {
            return cadenaDatos;
        }

        public double getReultado(string operacion)
        {
            if(operacion=="mediaAritmetica")
                return Medias.mediaAritmetica(datos);
            else
                return Medias.mediaGeometrica(datos);
        }
    }
}
