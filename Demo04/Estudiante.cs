using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    public class Estudiante
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Codigo { get; set; }

        //Asociación
        //Propiedades de navegación
        public Escuela Escuela{ get; set; }

        public Ciudad Ciudad { get; set; }



    }
}
