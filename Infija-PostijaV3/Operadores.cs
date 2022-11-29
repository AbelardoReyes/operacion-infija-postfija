using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infija_PostijaV3
{
    class Operadores
    {
        public int Jerarquia(char c)
        {
            int valor;
            if (c == '(' || c == ')')
            {
                return valor = 1;
            }
            else if (c == '+' || c == '-')
            {
                return valor = 2;
            }
            else if (c == '*' || c == '/')
            {
                return valor = 3;
            }
            else if (c == '^')
            {
                return valor = 4;
            }
            else
            {
                return valor = 0;
            }
        }
    }
}
