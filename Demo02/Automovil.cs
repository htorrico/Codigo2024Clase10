using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class Automovil : Vehiculo
    {
        public string PantallaTactil { get; set; }
        public override void CalcularPrecioVenta()
        {
            Console.WriteLine("Calculando precio " +
                "venta de Automovil");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine(Marca);
            Console.WriteLine(Modelo);
            Console.WriteLine(PantallaTactil);
        }

    }
}
