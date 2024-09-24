using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10
{
    public class CuentaMancomunada: Cuenta
    {
        public override void Depositar(double monto)
        {
            //Lógica para depositar
            Console.WriteLine("Depositando en cuenta mancomunada");

        }
    }
}
