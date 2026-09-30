using System;

namespace C_Practico1_MarcosJalon
{
    /// <summary>
    /// Controla el menú principal del juego.
    /// </summary>
    public class Juego
    {
        private Historial historial;

        /// <summary>
        /// Inicializa una nueva instancia de la clase "Juego".
        /// </summary>
        public Juego()
        {
            historial = new Historial();
        }
        /// <summary>
        /// Inicia el juego y muestra el menú principal.
        /// </summary>
        public void Iniciar()
        {
            int opcion = -1;

            do
            {
                Console.WriteLine("\n===== JUEGO MATEMÁTICO =====");
                Console.WriteLine("1. Sumas");
                Console.WriteLine("2. Restas");
                Console.WriteLine("3. Multiplicaciones");
                Console.WriteLine("4. Divisiones");
                Console.WriteLine("5. Ver historial");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                string texto = Console.ReadLine();

                try
                {
                    // La opción solo puede ser un número entero.
                    opcion = Convert.ToInt32(texto);

                    switch (opcion)
                    {
                        case 1:
                            Jugar("+");
                            break;

                        case 2:
                            Jugar("-");
                            break;

                        case 3:
                            Jugar("*");
                            break;

                        case 4:
                            Jugar("/");
                            break;

                        case 5:
                            historial.Mostrar();
                            break;

                        case 0:
                            Console.WriteLine("Programa finalizado.");
                            break;

                        default:
                            Console.WriteLine("Opción incorrecta.");
                            break;
                    }
                }
                catch
                {
                    // Si el usuario escribe letras o una frase,
                    // se muestra este mensaje y vuelve al menú.
                    Console.WriteLine("Error: solo puedes introducir un número entero.");
                }

            } while (opcion != 0);
        }

        /// <summary>
        /// Crea una nueva partida con la operación seleccionada y la añade al historial.
        /// </summary>
        /// <param name="operacion"></param>
        private void Jugar(string operacion)
        {
            
            Partida partida = new Partida(operacion);

            partida.Jugar();

            historial.Añadir(partida);
        }
    }
}