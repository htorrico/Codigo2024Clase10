using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public class CuentaAhorro : Cuenta
    {    
        public override void Retirar(decimal monto)
        {
            if (Saldo >= monto)
            {
                Saldo -= monto;
                Console.WriteLine($"Se han retirado {monto:C}. Saldo actual: {Saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar esta operación.");
            }
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Cuenta de Ahorro - Número: {NumeroCuenta}, Titular: {Titular}, Saldo: {Saldo:C}");
        }
    }

}
