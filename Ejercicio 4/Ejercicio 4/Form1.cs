using Ejercicio_4.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string[] ventasStr = txtVentas.Text.Split(',');
            int[] ventas = Array.ConvertAll(ventasStr, int.Parse);

            int[] rangos = Salarios.CalcularSalarios(ventas);

            lstResultados.Items.Clear();
            lstResultados.Items.Add("$200-$299: " + rangos[0]);
            lstResultados.Items.Add("$300-$399: " + rangos[1]);
            lstResultados.Items.Add("$400-$499: " + rangos[2]);
            lstResultados.Items.Add("$500-$599: " + rangos[3]);
            lstResultados.Items.Add("$600-$699: " + rangos[4]);
            lstResultados.Items.Add("$700-$799: " + rangos[5]);
            lstResultados.Items.Add("$800-$899: " + rangos[6]);
            lstResultados.Items.Add("$900-$999: " + rangos[7]);
            lstResultados.Items.Add("$1000 o superior: " + rangos[8]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
