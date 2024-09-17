using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.models
{
    internal class Venta
    {
        public int Vendedor { get; set; }
        public int Producto { get; set; }
        public decimal Valor { get; set; }

        public Venta(int vendedor, int producto, decimal valor)
        {
            Vendedor = vendedor;
            Producto = producto;
            Valor = valor;
        }
    }
}