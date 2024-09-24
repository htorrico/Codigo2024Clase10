using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine(Marca);
            Console.WriteLine(Modelo);    
        }
        //abstract: Obliga a implementar en todos los hijos
        public abstract void CalcularPrecioVenta();
    }
}
