using Pais;
using System;
using System.Collections.Generic;
using System.Text;

namespace mascotas
{
    public class Gato : Animal
    {
        public string color { get; set; }
    }

    public partial class Perro : Animal
    {
        public int cantidadOjos { get; set; }
        public void Ladrar()
        {
            Console.WriteLine("Wau Wau");
        }

        public string esAdulto() {
            /*string msj = "";
            if (edad > 4)
            {
                msj = "Es adulto";
            }
            else
                msj = "Es joven";
            return msj;
            */

            return edad > 4 ? "Es adulto" : "Es joven";
        }
        public bool esCachorro() {
            //return edad <= 3 ? true : false;
            return edad <= 3;
        }
    }

}
