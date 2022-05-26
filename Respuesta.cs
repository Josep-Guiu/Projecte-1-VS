using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteGrup
{
    class Respuesta
    {
        public String Texto { get; set; }
        public bool IsTrue { get; set; }

        public Respuesta() { }
        public Respuesta(String texto, bool isTrue) {
            this.Texto = texto;
            this.IsTrue = isTrue;
        }
    }
}
