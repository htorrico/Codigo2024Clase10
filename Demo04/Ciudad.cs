using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    public class Ciudad
    {
        public string Nombre { get; set; }
        public int CantidadHabitantes { get; set; }
        public DateTime FechaFundacion { get; set; }
        public Pais Pais { get; set; }
    }
}
