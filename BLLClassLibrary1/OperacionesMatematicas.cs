using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLClassLibrary1
{

    // traducir  los documentados del codigo de (///)

    /// <summary>
    /// exponer metodos para una calculadora basica  que realice operaciones aritmeticas 
    /// <autor> Daniel Olarte-Jorge Urmendez </autor>
    /// <autor> cristian camilo barrera avila </autor>
    /// <fechaCreacion> 29/01/24 </fechaCreacion>
    /// </summary>
    public static class OperacionesMatematicas
    {
        /// <summary>
        /// Retorna la suma de dos numeros
        /// </summary>
        /// <param name="a"> Primer numero </param>
        /// <param name="b"> Segundo numero </param>
        /// <returns> Suma de los dos numeros </returns>
        public static double suma(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// Retorna la resta de dos numeros
        /// </summary>
        /// <param name="a"> Primer numero </param>
        /// <param name="b"> Segundo numero </param>
        /// <returns> resta de los dos numeros </returns>
        public static double resta(double a, double b)
        {
            return a - b;
        }
        /// <summary>
        /// Retorna la multiplicacion de dos numeros
        /// </summary>
        /// <param name="a"> Primer numero </param>
        /// <param name="b"> Segundo numero </param>
        /// <returns> multiplicacion de los dos numeros </returns>
        public static double multiplicacion(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        /// Retorna la division de dos numeros
        /// </summary>
        /// <param name="a"> Primer numero </param>
        /// <param name="b"> Segundo numero </param>
        /// <returns> division de los dos numeros </returns>
        public static double division(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("No se puede dividir por cero");
            }
            return a / b;
        }
        /// <summary>
        /// retorna la exponenciacion de un numero elevado a su base 
        /// </summary>
        /// <param name="baseValue"></param>
        /// <param name="exponente"></param>
        /// <returns> potencia de un numero elevado a su base </returns>
        public static double Exponenciacion(double baseValue, double exponente)
        {
            return Math.Pow(baseValue, exponente);
        }
        /// <summary>
        /// Retorna el porcentaje de un numero 
        /// </summary>
        /// <param name="a"> Primer numero </param>
        /// <param name="b"> Segundo numero </param>
        /// <returns> porcentaje de un numero  </returns>
        public static double porcentaje(double total, double porcentaje)
        {
            return (porcentaje / 100) * total;

        }
        /// <summary>
        /// Retorna  verdadero o falso si el numero es par
        /// </summary>
        /// <param name="a"> Primer numero </param>
        /// <returns> boleano </returns>
        public static bool espar(int numero)
        {
            return numero % 2 == 0;
        }
        /// <summary>
        /// Retorna  verdadero o falso si el numero es impar
        /// </summary>
        /// <param name="a"> Primer numero </param>
        /// <returns> boleano </returns>
        public static bool esimpar(int numero)
        {
            return numero % 2 != 0;
        }




    }
}