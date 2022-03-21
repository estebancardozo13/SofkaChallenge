using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofka_challenge
{
    public class Categoria
    {
        public int Ronda { get; set; }
        public int Puntos { get; set; }
        public List<Pregunta> Preguntas { get; set; }
    }
}
