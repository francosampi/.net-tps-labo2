using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Calculadora
    {
        static private char ValidarOperador(char operador)
        {
            if(operador.Equals('+') || operador.Equals('-') || operador.Equals('/') || operador.Equals('*'))
            {
                return operador;
            }
            return '+';
        }

        double Operar(Operando num1, Operando num2, char operador)
        {
            return 0;
        }
    }
}
