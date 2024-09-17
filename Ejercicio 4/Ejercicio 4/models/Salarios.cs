using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4.models
{
    internal class Salarios
    {
        public static int[] CalcularSalarios(int[] ventas)
        {
            int[] rangos = new int[9];

            foreach (int venta in ventas)
            {
                int salario = 200 + (int)(0.09 * venta);

                if (salario >= 200 && salario <= 299)
                    rangos[0]++;
                else if (salario >= 300 && salario <= 399)
                    rangos[1]++;
                else if (salario >= 400 && salario <= 499)
                    rangos[2]++;
                else if (salario >= 500 && salario <= 599)
                    rangos[3]++;
                else if (salario >= 600 && salario <= 699)
                    rangos[4]++;
                else if (salario >= 700 && salario <= 799)
                    rangos[5]++;
                else if (salario >= 800 && salario <= 899)
                    rangos[6]++;
                else if (salario >= 900 && salario <= 999)
                    rangos[7]++;
                else if (salario >= 1000)
                    rangos[8]++;
            }

            return rangos;
        }
    }
}
