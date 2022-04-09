using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Operando
    {
        private double numero;

        public string Numero
        {
            get
            {
                return this.numero.ToString();
            }
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            return double.MinValue;
        }

        private double ValidarOperando(string strNumero)
        {
            double operando;

            return double.TryParse(strNumero, out operando) ? operando : 0;
        }

        private bool EsBinario(string binario)
        {
            for(int i=0; i<binario.Length; i++)
            {
                if(!i.Equals('0') || !i.Equals('1'))
                {
                    return false;
                }
            }
            return true;
        }

        public string BinarioDecimal(string binario)
        {
            string numeroInvertido = "";
            int resultadoDecimal = 0;

            if (EsBinario(binario))
            {
                for (int i = binario.Length - 1; i > 0; i--)
                {
                    numeroInvertido += binario[i];
                }
            
                for (int i = 0; i < numeroInvertido.Length - 1; i++)
                {
                    if (String.Equals(numeroInvertido[i], "1"))
                    {
                        resultadoDecimal += (int)(Math.Pow(Int32.Parse(Char.ToString(numeroInvertido[i])), 2));
                    }
                }
                return resultadoDecimal.ToString();
            }
            return "Valor inválido";
        }

        public string DecimalBinario(double numero)
        {
            string resultado = "";
            string resultadoInvertido = "";

            if (numero > 0)
            {
                while (numero > 0)
                {
                    resultado += numero % 2;

                    numero/=2;

                    Console.WriteLine(numero);
                }

                for (int i = resultado.Length - 1; i > 0; i--)
                {
                    resultadoInvertido += resultado[i];
                }

                return resultadoInvertido.ToString();
            }
            return "Valor inválido";
        }
    }
}
