using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mate
{
    class Lector
    {
        public Lector()
        {
        }

        public void calis()
        {
            Console.WriteLine("funcionaaaaaaaa");
        }

        public void leer()
        {
            try {
                string archivo;

                Console.WriteLine("Ubicacion del archivo: ");
                archivo = Console.ReadLine();

                int counter = 0;
                string line;

                System.IO.StreamReader file = new System.IO.StreamReader(archivo);

                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    counter++;
                }

                file.Close();
                System.Console.WriteLine("There were {0} lines.", counter);
                System.Console.ReadLine();

            }
            catch (Exception e){
                Console.WriteLine(e);
            }
        }
    }
}
