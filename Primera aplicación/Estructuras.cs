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
        public static void Ejemplo4() {//Colas (FIFO - First In, First Out)
            Queue<Persona> colaAlBanco = new Queue<Persona>();
            colaAlBanco.Enqueue(new Persona(20,"Pepe"));
            colaAlBanco.Enqueue(new Persona(30, "Ana"));
            colaAlBanco.Enqueue(new Persona(19, "Raul"));
            colaAlBanco.Enqueue(new Persona(24, "Sofia"));
            Persona p_elim = colaAlBanco.Dequeue();
            colaAlBanco.Enqueue(p_elim); //volvió!
            Console.WriteLine("Se eliminó a " + p_elim.nombre);
            if (colaAlBanco.Contains(p_elim))
                Console.WriteLine("Pepe esta en la cola");
            else
                Console.WriteLine("Pepe NO esta en la cola");
        }
        public static void Ejemplo5()
        {//Map: cuenta con una tupla -> llave & valor
            //Para averiguar

            string exp = "( 2 + 3 ) * 6"; //postfix: 2 3 + 6 *
            string[] tokens = exp.Split(' ');
            foreach (string simbolo in tokens)
                Console.WriteLine("Este es un token: " + simbolo);
            Stack<string> pila = new Stack<string>();
            string mano = "";
            while(pila.Count > 0)
            {
                switch (mano)
                {
                    case "(":
                        pila.Push(mano);
                        break;
                    case ")":
                        break;
                    case "+": case "-": case "*": case "/":
                        break;
                    default://es numero

                        break;
                }
            }

            /*
             Sin embargo, vemos que las computadoras evalúan expresiones infix… esto lo hacen mediante una conversión a postfix
            Existe un algoritmo para dicha conversión:
                1. Meter paréntesis de apertura en la pila
                2. Concatenar paréntesis de cierre al final de la expresión infix
                3. Mientras la pila no esté vacía rescatar valores de la expresión infix de izq a Der
	Si el char es dígito: concatenamos a expresión final postfix
	Si el char es paréntesis de apertura: push a pila
	Si el char es operador: Sacamos los operadores (si existen en la cima) solo si son de igual o mayor precedencia que el operador actual y concatenar a la expresión final postfix. Meter el operador actual a la pila.
	Si el char es paréntesis de cierre: Sacar los valores de la pila e ir concatenándolos a la expresión final postfix, hasta que haya un paréntesis de apertura en la cima de la pila. Sacar y eliminar dicho paréntesis de apertura de la pila.

             */
            /*Ejemplo: ( 2 + 3 ) * 6
             * INFIX  
             * PILA:
             * POSTFIX:  2 3 + 6 *
             * MANO:
             */
        }
    }
}
