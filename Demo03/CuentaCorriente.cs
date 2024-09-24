using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public class CuentaCorriente : Cuenta
    {
        private const decimal Comision = 0.02m; // Comisión del 2%

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Cuenta Corriente - Número: {NumeroCuenta}, Titular: {Titular}, Saldo: {Saldo:C}");
        }


        public override void Retirar(decimal monto)
        {
            decimal montoConComision = monto + (monto * Comision);
            if (Saldo >= montoConComision)
            {
                Saldo -= montoConComision;
                Console.WriteLine($"Se han retirado {monto:C} con una comisión de {Comision * 100}% ({monto * Comision:C}). Saldo actual: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar esta operación.");
            }
        }

    }
}
