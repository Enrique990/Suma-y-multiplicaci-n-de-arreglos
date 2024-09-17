using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_2.model;
namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        Reservacion reservacion = new Reservacion ();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSmoking_Click(object sender, EventArgs e)
        {
            AsignarAsiento(true);
        }

        private void btnNonSmoking_Click(object sender, EventArgs e)
        {
            AsignarAsiento(false);
        }

        private void AsignarAsiento(bool isSmoking)
        {
            var resultado = reservacion.AsignarAsiento(isSmoking);
            if (resultado.HasValue)
            {
                lblResult.Text = $"Boarding Pass:\nSeat Number: {resultado.Value.seatNumber}\nSection: {(resultado.Value.isSmoking ? "Smoking" : "Non-Smoking")}";
            }
            else
            {
                if (reservacion.SeccionLlena(isSmoking))
                {
                    var otherSection = !isSmoking;
                    var otherSectionName = otherSection ? "Non-Smoking" : "Smoking";
                    var result = MessageBox.Show($"{(isSmoking ? "Smoking" : "Non-Smoking")} section is full. Would you like to be placed in the {otherSectionName} section?", "Section Full", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        AsignarAsiento(otherSection);
                    }
                    else
                    {
                        lblResult.Text = "Next flight leaves in 3 hours.";
                    }
                }
            }
        }
    }
}