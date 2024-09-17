namespace Ejercicio_1
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
            this.btnLanzar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProbabilidad = new System.Windows.Forms.TextBox();
            this.tbProb7 = new System.Windows.Forms.TextBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(373, 290);
            this.btnLanzar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(318, 45);
            this.btnLanzar.TabIndex = 2;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 80);
            this.label3.TabIndex = 4;
            this.label3.Text = "Verificacion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbProbabilidad
            // 
            this.tbProbabilidad.Location = new System.Drawing.Point(356, 132);
            this.tbProbabilidad.Multiline = true;
            this.tbProbabilidad.Name = "tbProbabilidad";
            this.tbProbabilidad.Size = new System.Drawing.Size(347, 58);
            this.tbProbabilidad.TabIndex = 5;
            // 
            // tbProb7
            // 
            this.tbProb7.Location = new System.Drawing.Point(356, 219);
            this.tbProb7.Multiline = true;
            this.tbProb7.Name = "tbProb7";
            this.tbProb7.Size = new System.Drawing.Size(356, 54);
            this.tbProb7.TabIndex = 6;
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvResultados.Location = new System.Drawing.Point(32, 41);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersWidth = 62;
            this.dgvResultados.Size = new System.Drawing.Size(265, 294);
            this.dgvResultados.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvResultados);
            this.groupBox1.Controls.Add(this.tbProb7);
            this.groupBox1.Controls.Add(this.tbProbabilidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnLanzar);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(763, 375);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(829, 403);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lanzamiento de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProbabilidad;
        private System.Windows.Forms.TextBox tbProb7;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

