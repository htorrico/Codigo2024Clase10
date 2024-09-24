using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public abstract class Cuenta
    {
        public string NumeroCuenta { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get;  set; }

     

        public void Depositar(decimal monto)
        {
            Saldo += monto;
            Console.WriteLine($"Se han depositado {monto:C}. Saldo actual: {Saldo:C}");
        }

        public abstract void Retirar(decimal monto);

        public abstract void MostrarDetalles();
    }

}
