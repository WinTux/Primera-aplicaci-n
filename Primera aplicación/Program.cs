using mascotas;
using Pais;
using EstudianteUniv = Universidad.Estudiante;
using System;
using Primera_aplicación;

namespace ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejemplos iniciales
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
            #endregion
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
            snoopy.Ladrar();
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

            #region Eejemplo de tipado débil
            //Tipado debil
            string txt = "texto";
            var txt2 = "otro texto";
            var es = est2aux;
            #endregion

            EstudianteUniv estU = new EstudianteUniv(23,"Pepe","Perales",123456,"pepep@universidad.wow.bo");
            Gato g = new Gato();



            Console.WriteLine("Por favor, introduzca un número:");
            try
            {
                int nn = int.Parse(Console.ReadLine());
                Console.WriteLine(10 / nn);
            }
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Por favor, no ponga el número 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor escriba un número!");
            }


            //Estructuras de datos
            //Estructuras.Ejemplo2();
            //Estructuras.Ejemplo3();
            //Estructuras.Ejemplo4();
            Estructuras.Ejemplo5();
            Console.ReadKey();
        }

        private static void Saludo() {
            Console.WriteLine("Hola");
        }
    }
}
