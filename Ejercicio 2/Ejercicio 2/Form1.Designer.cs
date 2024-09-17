namespace Ejercicio_2
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

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSmoking = new System.Windows.Forms.Button();
            this.btnNonSmoking = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSmoking
            // 
            this.btnSmoking.Location = new System.Drawing.Point(50, 30);
            this.btnSmoking.Name = "btnSmoking";
            this.btnSmoking.Size = new System.Drawing.Size(100, 30);
            this.btnSmoking.TabIndex = 0;
            this.btnSmoking.Text = "Smoking";
            this.btnSmoking.UseVisualStyleBackColor = true;
            this.btnSmoking.Click += new System.EventHandler(this.btnSmoking_Click);
            // 
            // btnNonSmoking
            // 
            this.btnNonSmoking.Location = new System.Drawing.Point(200, 30);
            this.btnNonSmoking.Name = "btnNonSmoking";
            this.btnNonSmoking.Size = new System.Drawing.Size(100, 30);
            this.btnNonSmoking.TabIndex = 1;
            this.btnNonSmoking.Text = "Non-Smoking";
            this.btnNonSmoking.UseVisualStyleBackColor = true;
            this.btnNonSmoking.Click += new System.EventHandler(this.btnNonSmoking_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(50, 80);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnNonSmoking);
            this.Controls.Add(this.btnSmoking);
            this.Name = "Form1";
            this.Text = "Sistema de Reservaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSmoking;
        private System.Windows.Forms.Button btnNonSmoking;
        private System.Windows.Forms.Label lblResult;
    }
}

