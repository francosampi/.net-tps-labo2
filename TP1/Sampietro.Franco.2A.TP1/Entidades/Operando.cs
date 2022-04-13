using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public string Numero
        {
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
            for (int i = 0; i < binario.Length; i++)
            {
                char binChar = binario[i];

                foreach(char caracter in binario)
                {
                    if(caracter!='1' && caracter!='0')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public string BinarioDecimal(string binario)
        {
            double resultado = 0;
            int cantidadCaracteres = binario.Length;

            if (EsBinario(binario))
            {
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;
                    if (caracter == '1')
                    {
                        resultado += (int)Math.Pow(2, cantidadCaracteres);
                    }
                }
                return resultado.ToString();
            }
            return "Valor inválido";
        }

        public string DecimalBinario(double numero)
        {
            int resultado = (int)(Math.Abs(numero));
            int restoDiv;
            string valorBinario = string.Empty;

            if (resultado > -1)
            {
                do
                {
                    restoDiv = resultado % 2;

                    resultado/=2;

                    valorBinario = restoDiv.ToString() + valorBinario;
                } while (resultado > 0);

                return valorBinario;
            }
            return "Valor inválido";
        }

        public string DecimalBinario(string numero)
        {
            double res;

            return Double.TryParse(numero, out res) ? DecimalBinario(res) : "Valor inválido";
        }
    }
}
