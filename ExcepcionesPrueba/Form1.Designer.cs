namespace ExcepcionesPrueba
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
            this.txtUno = new System.Windows.Forms.TextBox();
            this.txtDos = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUno
            // 
            this.txtUno.Location = new System.Drawing.Point(49, 55);
            this.txtUno.Name = "txtUno";
            this.txtUno.Size = new System.Drawing.Size(200, 20);
            this.txtUno.TabIndex = 0;
            // 
            // txtDos
            // 
            this.txtDos.Location = new System.Drawing.Point(49, 121);
            this.txtDos.Name = "txtDos";
            this.txtDos.Size = new System.Drawing.Size(200, 20);
            this.txtDos.TabIndex = 1;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(109, 188);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 2;
            this.btnResultado.Text = "Calcular";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(126, 273);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 388);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtDos);
            this.Controls.Add(this.txtUno);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUno;
        private System.Windows.Forms.TextBox txtDos;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}

