using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_1.models;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Repetidor repetidor = new Repetidor();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            repetidor.Tiradas(36000);
            int[] frecuencias = repetidor.GetFrecuencias();

            LimpiarElementos();

            if (dgvResultados.Columns.Count == 0)
            {
                dgvResultados.Columns.Add("Suma", "Suma");
                dgvResultados.Columns.Add("Frecuencia", "Frecuencia");
            }

            for (int i = 2; i < frecuencias.Length; i++)
            {
                dgvResultados.Rows.Add(i, frecuencias[i]);
            }

            double probabilidad7 = (double)frecuencias[7] / 36000;
            tbProbabilidad.Text = $"\nFrecuencia estimada de la suma 7: {frecuencias[7]} veces.\n";
            tbProb7.Text = $"\nProbabilidad estimada de la suma 7: {probabilidad7:P2} (Debe ser aprox. 16.67%)";
        }

        public void LimpiarElementos()
        {
            dgvResultados.Rows.Clear();
            tbProbabilidad.Clear();
            tbProb7.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}