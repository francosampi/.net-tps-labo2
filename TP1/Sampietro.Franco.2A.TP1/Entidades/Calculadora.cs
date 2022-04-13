using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// retorna por defecto el operador suma a menos que no reciba un char correspondiente al resto de operaciones posibles
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        static private char ValidarOperador(char operador)
        {
            if (operador.Equals('+') || operador.Equals('-') || operador.Equals('/') || operador.Equals('*'))
            {
                return operador;
            }
            return '+';
        }

        /// <summary>
        /// obtiene y valida un operador, y, de ser posible, retorna la operacion entre dos Operandos recibidos, sino retorna 0
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
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