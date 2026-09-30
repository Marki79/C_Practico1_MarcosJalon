using C_Practico1_MarcosJalon;
using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto1;
/// <summary>
/// 
//Debéis crear un juego que consista en preguntarle al jugador cuál es el resultado de una
//operación matemá8ca(p.ej., ¿9 x 9 = ?), recoger la respuesta y añadir un punto en caso
//de que sea correcta.Algunas consideraciones:

    //• Un juego debe tener al menos 5 preguntas.

    //• Las divisiones deben dar únicamente NÚMEROS ENTEROS como resultado y los
    //dividendos deben ir de 0 a 100. Ejemplo: Tu aplicación no debería presentarle la
    //división 7/2 al usuario, ya que no da un número entero como resultado.

    //• Se le debe mostrar un menú a los usuarios para que elijan una operación.

    //• Debes registrar los juegos anteriores en una lista y debe haber una opción en el
    //menú para que el usuario pueda visualizar el historial de juegos anteriores.

    //• No necesitas guardar los resultados en una base de datos. Una vez que se cierre
    //el programa, los resultados se eliminarán.

/// </summary>


public class Principal
{
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    public static void Main(string[] args)
    {
        Juego juego = new Juego();

        // Inicia el juego: a partir de aquí el control pasa a la clase Juego
        juego.Iniciar();


    }
}





