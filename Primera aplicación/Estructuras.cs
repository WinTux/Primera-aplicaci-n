using Pais;
using System;
using System.Collections.Generic;
using System.Text;

namespace Primera_aplicación
{
    public class Estructuras
    {
        public void Ejemplo1()
        {
            int[] numeros = new int[3];
            numeros[0] = 123;
            numeros[1] = 456;
            numeros[2] = 777;

            numeros = agergarElemento(numeros, 56);
        }

        private int[] agergarElemento(int[] arregloOriginal, int valor)
        {
            int longitud = arregloOriginal.Length;
            int[] arregloNuevo = new int[longitud + 1];
            for(int i = 0; i < arregloOriginal.Length; i++)
                arregloNuevo[i] = arregloOriginal[i];
            arregloNuevo[longitud] = valor;
            return arregloNuevo;
        }

        public static void Ejemplo2() //Listas
        {
            List<int> numeros = new List<int>();
            numeros.Add(123);

            List<Persona> listaPer = new List<Persona>();
            listaPer.Add(new Persona());

            numeros.Add(234);

            foreach (int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }
        }

        public static void Ejemplo3() //Pilas (FILO: First In, Last Out)
        {
            Stack<string> mi_pila = new Stack<string>();
            mi_pila.Push("Pepe");
            mi_pila.Push("Ana");
            mi_pila.Push("Sofia");

            Console.WriteLine($"Espiando primer elemento en la pila: {mi_pila.Peek()}");

            Console.WriteLine($"Retirando el primer elemento en la pila: {mi_pila.Pop()}");

            Console.WriteLine($"Espiando primer elemento en la pila: {mi_pila.Peek()}");

            mi_pila.Push("Otto");

            Console.WriteLine($"Espiando primer elemento en la pila: {mi_pila.Peek()}");

            Console.WriteLine($"Retirando el primer elemento en la pila: {mi_pila.Pop()}");

            Console.WriteLine($"Espiando primer elemento en la pila: {mi_pila.Peek()}");
            Console.WriteLine($"Retirando el primer elemento en la pila: {mi_pila.Pop()}");
            Console.WriteLine($"Retirando el primer elemento en la pila: {mi_pila.Pop()}");


            //Cómo mostrar los elementos?
            mi_pila.Push("Ana");
            mi_pila.Push("Sofia");
            mi_pila.Push("Pepe");
            mi_pila.Push("Otto");

            //while(mi_pila.Count > 0) Console.WriteLine(mi_pila.Pop());

            Stack<string> aux = new Stack<string>();
            while (mi_pila.Count > 0)
            {
                string val = mi_pila.Pop();
                Console.WriteLine(val);
                aux.Push(val);
            }
            mi_pila = aux;
            /*
             * Paso por valor
            int a = 5;
            int b = 2;

            a = b;
            a++;
            b--;
            */

            /*
             Paso por referencia
             */
            Console.WriteLine(aux.Peek());//Ana
            aux.Pop();
            Console.WriteLine(mi_pila.Peek());//Ana
        }
    }
}
