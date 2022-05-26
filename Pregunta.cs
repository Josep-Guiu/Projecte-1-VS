using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteGrup
{
    class Pregunta
    {
        public String PreguntaTexto { get; set; }
        public List<Respuesta> Respuestas { get; set; }
        public String Dificult { get; set; }
        public String Gender { get; set; }

        public Pregunta() { }
        public Pregunta(String preguntaTexto, List<Respuesta> respuestas, String dificult, String gender) {
            this.PreguntaTexto = preguntaTexto;
            this.Respuestas = respuestas;
            this.Dificult = dificult;
            this.Gender = gender;
        }
    }
}
