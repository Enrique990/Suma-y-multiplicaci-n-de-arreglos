namespace Ejercicio_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 51);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtVentas
            // 
            this.txtVentas.Location = new System.Drawing.Point(12, 25);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(100, 20);
            this.txtVentas.TabIndex = 1;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(12, 9);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(88, 13);
            this.lblVentas.TabIndex = 2;
            this.lblVentas.Text = "Ventas Semanales";
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(12, 80);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(260, 160);
            this.lstResultados.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.txtVentas);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Salarios de Vendedores";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.ListBox lstResultados;
    }

    #endregion
}

