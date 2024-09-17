using Ejercicio_3.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        private List<Venta> ventas;

        public Form1()
        {
            InitializeComponent();
            ventas = new List<Venta>();
            // Aquí puedes agregar las ventas del mes anterior
            ventas.Add(new Venta(1, 1, 100));
            ventas.Add(new Venta(2, 2, 200));
            ventas.Add(new Venta(3, 3, 300));
            ventas.Add(new Venta(4, 4, 400));
            ventas.Add(new Venta(1, 5, 500));
            // Agrega más ventas según sea necesario
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            decimal[,] sales = new decimal[5, 4];

            foreach (var venta in ventas)
            {
                sales[venta.Producto - 1, venta.Vendedor - 1] += venta.Valor;
            }

            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 6;

            // Agregar encabezados de columna
            dataGridView1.Columns[0].HeaderText = "Vendedor 1";
            dataGridView1.Columns[1].HeaderText = "Vendedor 2";
            dataGridView1.Columns[2].HeaderText = "Vendedor 3";
            dataGridView1.Columns[3].HeaderText = "Vendedor 4";
            dataGridView1.Columns[4].HeaderText = "Total Producto";

            // Agregar encabezados de fila
            dataGridView1.Rows[0].HeaderCell.Value = "Producto 1";
            dataGridView1.Rows[1].HeaderCell.Value = "Producto 2";
            dataGridView1.Rows[2].HeaderCell.Value = "Producto 3";
            dataGridView1.Rows[3].HeaderCell.Value = "Producto 4";
            dataGridView1.Rows[4].HeaderCell.Value = "Producto 5";
            dataGridView1.Rows[5].HeaderCell.Value = "Total Vendedor";

            for (int i = 0; i < 5; i++)
            {
                decimal totalProducto = 0;
                for (int j = 0; j < 4; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = sales[i, j];
                    totalProducto += sales[i, j];
                }
                dataGridView1.Rows[i].Cells[4].Value = totalProducto;
            }

            for (int j = 0; j < 4; j++)
            {
                decimal totalVendedor = 0;
                for (int i = 0; i < 5; i++)
                {
                    totalVendedor += sales[i, j];
                }
                dataGridView1.Rows[5].Cells[j].Value = totalVendedor;
            }

            decimal totalGeneral = 0;
            for (int i = 0; i < 4; i++)
            {
                totalGeneral += (decimal)dataGridView1.Rows[5].Cells[i].Value;
            }
            dataGridView1.Rows[5].Cells[4].Value = totalGeneral;
        }
    }
}
