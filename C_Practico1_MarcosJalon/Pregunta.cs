using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practico1_MarcosJalon
{
    /// <summary>
    /// Representa una pregunta de matemáticas con su texto y resultado esperado.
    /// </summary>
    public class Pregunta
    {
        private string texto;
        private int resultado;

        public string Texto
        {
            get { return texto; }
        }

        public int Resultado
        {
            get { return resultado; }
        }

        public Pregunta(string texto, int resultado)
        {
            this.texto = texto;
            this.resultado = resultado;
        }
    }
}
