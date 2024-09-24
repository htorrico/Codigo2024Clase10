using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10
{
    public abstract class Cuenta
    {
        public string NumeroCuenta { get; set; }

        public double Saldo { get; set; }

        //Firma
        public virtual void MostrarInformacion()
        {
            //Implementación (Lógica Negocio)
            Console.WriteLine(NumeroCuenta);
            Console.WriteLine(Saldo);
        }


        //Firma
        public abstract void Depositar(double monto);

        ////Firma
        //public abstract void Retirar(double monto);

        ////Firma
        //public abstract void CambiarPassword(string newPassword);

    }


   
}
