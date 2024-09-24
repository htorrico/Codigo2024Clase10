using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10
{
    public class CuentaFacilito : Cuenta
    {
        public string AnnioPromocion { get; set; }
        public override void Depositar(double monto)
        {
            throw new NotImplementedException();
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine(AnnioPromocion);
            Console.WriteLine(NumeroCuenta);
            Console.WriteLine(Saldo);

        }
    }
}
