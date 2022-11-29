using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Infija_PostijaV3
{
    class Conversion
    {
        Stack Pila = new Stack();
        char temp, peso = '$';
        int j = 0, top = 0;
        char[] EP { set; get; }

        public void Inicializar()
        {
            EP = new char[30];
        }
        public void conversion()
        {
            Operadores operador = new Operadores();
            Pila.Push(peso);
            //Pedir la operacion
            Console.Write("Ingresa la notacion infija: ");
            string EI = Console.ReadLine(); ;
            for (int i = 0; i < EI.Length; i++)
            {
                char c = EI[i];
                //Seccion de signos
                if (c == '+' || c == '*' || c == '$' || c == '-' || c == '/' || c == '^')
                {
                    temp = ((char)Pila.Pop());
                    //Obtener que simbolo es de mayor jerarquia
                    while (operador.Jerarquia(c) <= operador.Jerarquia(temp))
                    {
                        //vaciar la pila
                        EP[j] = temp;
                        j++;
                        temp = ((char)Pila.Pop());
                        top--;
                    }
                    //Insertar en la pila
                    //Console.WriteLine("temp es: " + temp);
                    Pila.Push(temp);
                    Pila.Push(c);
                    top++;
                }
                //Si es un parentesis de apertura insertar en la pila
                else if (c == '(')
                {
                    Pila.Push(c);
                    top++;
                }
                //Si es un parentesis de cierre
                else if (c == ')')
                {
                    //Extraer los valores de la pila hasta encontrar un '('
                    temp = ((char)Pila.Pop());
                    top--;
                    while (temp != '(')
                    {
                        EP[j] = temp;
                        j++;
                        temp = ((char)Pila.Pop());
                        top--;
                    }
                }
                //Inserccion normal
                else
                {
                    EP[j] = c;
                    j++;
                }
            }
            //Extraer los valores que hayan quedado en la pila hasta que top sea 0
            while (top != 0)
            {
                temp = ((char)Pila.Pop());
                EP[j] = temp;
                j++;
                top--;
            }
            //Impresion de la operacion
            Console.Write("Postija: ");
            for (int i = 0; i < EP.Length; i++)
            {
                Console.Write(EP[i]);
            }
            Console.WriteLine();
            //Console.WriteLine("Al final top vale: " + top);
        }
    }
}