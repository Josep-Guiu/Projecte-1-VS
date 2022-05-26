using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteGrup
{
    class Avatar
    {
        public String Nombre { get; set; }
        public String Gender { get; set; }
        public int PuntuacionMin { get; set; }
        public int PuntuacionMax { get; set; }
        public String Ruta;


        public Avatar(String Nombre, String Gender, int PuntuacionMin, int PuntuacionMax, String Ruta)
        {
            this.Nombre = Nombre;
            this.Gender = Gender;
            this.PuntuacionMin = PuntuacionMin;
            this.PuntuacionMax = PuntuacionMax;
            this.Ruta = Ruta;
        }






        
    }
}
