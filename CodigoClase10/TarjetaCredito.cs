using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10
{
    public class TarjetaCredito : Cuenta
    {

        public override void Depositar(double monto)
        {
            //Lógica para el depósito
            Console.WriteLine("Depositando en tarjeta crédito");

        }
    }
}
