using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practico1_MarcosJalon
{

    /// <summary>
    /// Representa el historial de partidas jugadas.
    /// </summary>
    public class Historial
    {
        // Lista de partidas jugadas.
        private List<Partida> partidas;

        /// <summary>
        /// Inicializa una nueva instancia de la clase "Historial".
        /// </summary>
        public Historial()
        {
            partidas = new List<Partida>();
        }

        /// <summary>
        /// Agrega una partida al historial.
        /// </summary>
        /// <param name="partida"></param>
        public void Añadir(Partida partida)
        {
            partidas.Add(partida);
        }

        
        /// <summary>
        /// Muestra el historial de partidas jugadas.
        /// </summary>
        public void Mostrar()
        {
            Console.WriteLine("\n===== HISTORIAL =====");

            if (partidas.Count == 0)
            {
                Console.WriteLine("Todavía no hay partidas.");
                return;
            }

            for (int i = 0; i < partidas.Count; i++)
            {
                Console.WriteLine(
                    "Partida " + (i + 1) +
                    " - Operación: " + partidas[i].Operacion +
                    " - Puntos: " + partidas[i].Puntos + "/5");
            }
        }
    }
}
