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
        public static string Ejemplo5()//convierte de infix a postfix
        {
            string exp = "( 2 + 3 ) * 6"; //postfix: 2 3 + 6 *
            exp += " )";// ( 2 + 3 ) * 6 )
            Stack<string> pila = new Stack<string>();
            pila.Push("(");

            string[] tokens = exp.Split(' ');
            int indice = 0;
            
            string mano = "";
            string postfix = "";
            while(pila.Count > 0)
            {
                mano = tokens[indice++];
                switch (mano)
                {
                    case "(":
                        pila.Push(mano);
                        break;
                    case ")":
                        //ver si en la cima de la pila hay un "("
                        while (!pila.Peek().Equals("(")) {
                            //Si no hay "(", entonces sacar elemento y concatenar a postfix
                            postfix += " " + pila.Pop();
                        }
                        //sino, sacar y eliminar
                        if(pila.Peek().Equals("("))
                            pila.Pop();
                        break;
                    case "+": case "-": case "*": case "/":
                    case "^": case "%":
                        //Tengo un operador en mi mano
                        //¿Hay un operador en la cima de la pila?
                        while (esOperador(pila.Peek())) {
                            //¿El operador de la pila es mayor al de la mano?
                            if (esOperadorMayor(pila.Peek(), mano))
                            {
                                //Sacamos de la pila y lo concatenamos en postfix
                                string aux = pila.Pop();
                                postfix += " " + aux;
                            }
                            else
                                break;

                        }


                        //agregar operador de la mano a la pila
                        pila.Push(mano);

                        break;
                    default://es numero
                        postfix += " " + mano;
                        break;
                }
            }

            return postfix;
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

        private static bool esOperadorMayor(string op1, string op2)
        {
            /*
             
             ^
             / * %
             + -


             */

            //enum 
            
            //con arrays


            if (op1.Equals("+") || op1.Equals("-"))
                return false;
            if (!((op1.Equals("/") || op1.Equals("*") || op1.Equals("%")) && (op2.Equals("+") || op2.Equals("-"))))
                return false;
            if (op1.Equals("^") && op2.Equals("^"))
                return false;
            return true;

        }

        private static bool esOperador(string caracter)
        {
            string operadores = "+-*/%^";
            return operadores.Contains(caracter);//o invertido

            //if(caracter.Equals("+")||caracter.Equals("-")||caracter.Equals("*")||...)

            /*switch (caracter) {
                case "+": case "-":
                    return true;
                default:
                    return false;
            }*/
        }


        public static int Ejemplo6(string expPostfix) {
            int resultado = 0;
            Stack<int> pila = new Stack<int>();
            string[] simbolos = expPostfix.Trim().Split(" ");// "4,5"
            foreach (string simbolo in simbolos) {
                switch (simbolo) {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    case "^":
                    case "%":
                        // 5 9 * 6 +
                        break;
                    default:
                        //Push a la pila
                        break;
                }
            }
            /*
            Recorremos de izq a der

            

            Ponemos valor acutal en la mano
            Si en mano es un numero: Push a pila
            Si es un operador: Pop en variable B, Pop en variable A y A operacion B en variable C, Push C a la pila

            Hasta que en la pila haya un solo elemento (numero)
             */

            /*Ejemplo: 2 3 + 6 *
             * POSTFIX:
             * PILA:  30
             * RESULTADO:  
             * MANO:  *
             * A: 5
             * B: 6
             * C:
             */
            return resultado;

        }
    }
}
