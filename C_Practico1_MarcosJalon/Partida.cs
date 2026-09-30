using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practico1_MarcosJalon
{
    /// <summary>
    /// Representa una partida del juego matemático, donde se realizan preguntas de una operación específica y se lleva un registro de los puntos obtenidos.
    /// </summary>
    public class Partida
    {

        private string operacion;
        private int puntos;
        private int preguntas;

        public string Operacion
        {
            get { return operacion; }
        }

        public int Puntos
        {
            get { return puntos; }
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase "Partida" con la operación seleccionada.
        /// </summary>
        /// <param name="operacion"></param>
        public Partida(string operacion)
        {
            this.operacion = operacion;
            puntos = 0;
            preguntas = 5;
        }
        
        /// <summary>
        /// Inicia la partida y muestra las preguntas.
        /// </summary>
        public void Jugar()
        {
            Console.WriteLine("\n===== NUEVA PARTIDA =====");
            Console.WriteLine("Operación: " + operacion);

            for (int i = 1; i <= preguntas; i++)
            {
                /// <summary>
                /// Crea una nueva pregunta según la operación seleccionada.
                /// </summary>
                /// <param name="operacion"></param>
               
                Pregunta pregunta = GeneradorOperaciones.CrearPregunta(operacion);

                Console.WriteLine("\nPregunta " + i + " de " + preguntas);
                Console.WriteLine(pregunta.Texto);

                int respuesta = 0;
                bool respuestaValida = false;


                /// <summary>
                /// Captura la respuesta del usuario y valida que sea un número entero.
                /// </summary>
                while (!respuestaValida)
                {
                    Console.Write("Respuesta: ");
                    string texto = Console.ReadLine();

                    try
                    {
                        respuesta = Convert.ToInt32(texto);
                        respuestaValida = true;
                    }
                    catch
                    {
                        Console.WriteLine("Introduce un número válido.");
                    }
                }

                if (respuesta == pregunta.Resultado)
                {
                    Console.WriteLine("¡Correcto!");
                    puntos++;
                }
                else
                {
                    Console.WriteLine("Incorrecto.");
                    Console.WriteLine("La respuesta era: " + pregunta.Resultado);
                }
            }

            Console.WriteLine("\nPartida terminada.");
            Console.WriteLine("Puntuación: " + puntos + "/" + preguntas);
        }
    }
}

