﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class Motocicleta : Vehiculo
    {
        
        public override void CalcularPrecioVenta()
        {
            Console.WriteLine("Calculando precio venta " +
                "de Motocicleta");

        }
    }
}
