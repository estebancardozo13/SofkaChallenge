using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sofka_challenge
{
    public class Pregunta
    {
        public string TextoPregunta { get; set; }
        public List<Opcion> Opciones { get; set; }


        public static bool VerificarRespuesta(Opcion opcionEscogida)
        {
            if (opcionEscogida.EsCorrecta)
            {
                return true; 
                
            }
            return false;
        }

 
    }
}
