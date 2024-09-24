using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10
{
    public class Trabajador
    {
        

        public void CalcularSalario(int TipoContrato)
        {
            if (TipoContrato==1)
            {
                Console.WriteLine("Salario Fijo");
            }
            if (TipoContrato == 2)
            {
                Console.WriteLine("Salario por horas");
            }
        }
    }

    public interface ITrabajador
    {
        public void CalcularAlgo();
       
    }

}
        
