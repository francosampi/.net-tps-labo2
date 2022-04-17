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

        /// <summary>
        /// se asigna un valor al atributo, previa validacion
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// constructores, 0 sin parametros, y puede recibir un double o una cadena
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        public Operando() : this(0)
        {
        }

        /// <summary>
        /// se sobrecarga el operador suma entre dos Operandos
        /// </summary>
        /// <param name="n1"></param> primer operando
        /// <param name="n2"></param> segundo operando
        /// <returns>la suma entre los operandos</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// se sobrecarga el operador resta entre dos Operandos
        /// </summary>
        /// <param name="n1"></param> primer operando
        /// <param name="n2"></param> segundo operando
        /// <returns>la resta entre los operandos</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Se sobrecarga el operador multiplicacion para dos operandos
        /// </summary>
        /// <param name="n1"></param> primer operando
        /// <param name="n2"></param> segundo operando
        /// <returns>el producto entre los operandos</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// En caso de no ser 0 el segundo operando, devuelve el cociente entre ambos, sino double.minValue
        /// </summary>
        /// <param name="n1"></param> primer operando
        /// <param name="n2"></param> segundo operando
        /// <returns>valor del cociente entre los operandos, el minimo valor posible si el denominador es 0</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            return double.MinValue;
        }
        
        /// <summary>
        /// se valida una cadena para que devuelva un double, se usa solo en el constructor
        /// </summary>
        /// <param name="strNumero"></param> cadena a intentar parsear
        /// <returns>de ser posible, el valor del string parseado en double, sino 0</returns>
        private double ValidarOperando(string strNumero)
        {
            double operando;

            return double.TryParse(strNumero, out operando) ? operando : 0;
        }

        /// <summary>
        /// verifica que una cadena solo contenga unos o ceros
        /// </summary>
        /// <param name="binario"></param> cadena a verificar
        /// <returns>falso si no es un string en binario, true si lo es</returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
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

        /// <summary>
        /// recibe una cadena, verifica que sea un numero binario y devuelve el resultado en string, de ser posible
        /// </summary>
        /// <param name="binario"></param> cadena a convertir
        /// <returns>de ser posible, la cadena convertida a decimal, sino error</returns>
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

        /// <summary>
        /// recibe un double, lo parsea a entero, y en caso de ser posible (0 o mayor), lo convierte a numero binario
        /// </summary>
        /// <param name="numero"></param> numero a convertir
        /// <returns>el valor del string pasado convertido en binario en caso de ser posible, sino devuelve error</returns>
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

        /// <summary>
        /// se sobrecarga el conversor, recibe una cadena y no un double, y de ser posible lo convierte a numero binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>el valor del string pasado parseado en double, de no ser posible devuelve error</returns>
        public string DecimalBinario(string numero)
        {
            double res;

            return Double.TryParse(numero, out res) ? DecimalBinario(res) : "Valor inválido";
        }
    }
}
