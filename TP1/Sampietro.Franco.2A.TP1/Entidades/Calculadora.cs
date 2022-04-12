using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        static private char ValidarOperador(char operador)
        {
            if (operador.Equals('+') || operador.Equals('-') || operador.Equals('/') || operador.Equals('*'))
            {
                return operador;
            }
            return '+';
        }

        public static double Operar(Operando num1, Operando num2, char operador)
        {
                switch (ValidarOperador(operador))
                {
                    case '+':
                        return num1 + num2;
                    case '-':
                        return num1 - num2;
                    case '*':
                        return num1 * num2;
                    case '/':
                        return num1 / num2;
                    default:
                        return 0;
                }
        }
    }
}