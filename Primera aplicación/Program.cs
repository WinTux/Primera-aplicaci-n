using mascotas;
using Pais;
using System;

namespace ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 4;
            string texto = "Pepe";
            bool interruptor = true;
            Console.WriteLine(4.56 - 7.0 * 2.0 / 3.0 + 2.678f);//float - double
            float num1 = 2.8f;
            int b = (int)2.5;
            Console.WriteLine(b);
            float otroNum = b;
            Saludo();
            Persona per = new Persona();
            per.edad = 20;
            per.nombre = "Pepe";
            Persona pp = null;
            pp = new Persona();
            //pp.nombre = "ana";

            Persona p = new Persona(23, "Sofía", "Loza");
            Persona z = new Persona(20, "Rocha","Sofía");

            Perro snoopy = new Perro();
            snoopy.patas = 4;
            snoopy.nombre = "Batuque";
            mascotas.pequeños.Loro lorito = new mascotas.pequeños.Loro();
            
            Console.WriteLine(per.edad + "; " + per.nombre);
            Console.WriteLine(pp.nombre);

            //constructores en clases heredadas

            Estudiante est1 = new Estudiante();

            Estudiante est2 = new Estudiante(19, "Arturo", "Roca", 401);

            Persona ppp = est2;
            //Estudiante eee = (Estudiante)p;

            Console.WriteLine(est2.matricula + "-" + est2.nombre);
            
            Console.WriteLine( ppp.apellido + "-" + ppp.nombre);

            Estudiante est2aux = (Estudiante)ppp;
            Console.WriteLine(est2aux.matricula + "-" + est2aux.nombre);

            Console.ReadKey();
        }

        private static void Saludo() {
            Console.WriteLine("Hola");
        }
    }
}
