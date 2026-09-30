using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practico1_MarcosJalon
{
    public class GeneradorOperaciones
    {
        /// <summary>
        /// Generador de números aleatorios para crear las preguntas.
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// Crea una pregunta de matemáticas basada en la operación especificada.
        /// </summary>
        /// <param name="operacion"></param>
        public static Pregunta CrearPregunta(string operacion)
        {
            int numero1;
            int numero2;
            int resultado;

            switch (operacion)
            {
                case "+":
                    numero1 = random.Next(0, 101);
                    numero2 = random.Next(0, 101);
                    resultado = numero1 + numero2;

                    return new Pregunta(
                        numero1 + " + " + numero2 + " = ?",
                        resultado);

                case "-":
                    numero1 = random.Next(0, 101);
                    numero2 = random.Next(0, 101);
                    resultado = numero1 - numero2;

                    return new Pregunta(
                        numero1 + " - " + numero2 + " = ?",
                        resultado);

                case "*":
                    numero1 = random.Next(0, 101);
                    numero2 = random.Next(0, 11);
                    resultado = numero1 * numero2;

                    return new Pregunta(
                        numero1 + " x " + numero2 + " = ?",
                        resultado);

                case "/":
                    return CrearDivision();

                default:
                    return new Pregunta("0 + 0 = ?", 0);
            }
        }
        /// <summary>
        /// Crea una pregunta de división asegurando que el dividendo sea un múltiplo del divisor y que el resultado sea un número entero.
        /// </summary>
        /// <returns></returns>
        private static Pregunta CrearDivision()
        {
            int divisor;
            int resultado;
            int dividendo;

            do
            {
                divisor = random.Next(1, 11);
                resultado = random.Next(0, 11);
                dividendo = divisor * resultado;

            } while (dividendo > 100);

            return new Pregunta(
                dividendo + " / " + divisor + " = ?",
                resultado);
        }
    }
}
