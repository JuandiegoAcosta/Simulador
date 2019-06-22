namespace Sistema_Bancario.Plataforma
{
    partial class UCcuenta
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datosPersona1 = new Sistema_Bancario.Controles.DatosPersona();
            this.tipoCuenta1 = new Sistema_Bancario.Controles.TipoCuenta();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(10, 445);
            this.proceder1.Size = new System.Drawing.Size(891, 49);
            // 
            // datosPersona1
            // 
            this.datosPersona1.DatosValidos = false;
            this.datosPersona1.Location = new System.Drawing.Point(27, 20);
            this.datosPersona1.Margin = new System.Windows.Forms.Padding(5);
            this.datosPersona1.Name = "datosPersona1";
            this.datosPersona1.Size = new System.Drawing.Size(509, 300);
            this.datosPersona1.TabIndex = 3;
            // 
            // tipoCuenta1
            // 
            this.tipoCuenta1.Location = new System.Drawing.Point(27, 326);
            this.tipoCuenta1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoCuenta1.Name = "tipoCuenta1";
            this.tipoCuenta1.Size = new System.Drawing.Size(224, 103);
            this.tipoCuenta1.TabIndex = 4;
            // 
            // UCcuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tipoCuenta1);
            this.Controls.Add(this.datosPersona1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCcuenta";
            this.Size = new System.Drawing.Size(911, 504);
            this.Load += new System.EventHandler(this.UCcuenta_Load);
            this.Controls.SetChildIndex(this.datosPersona1, 0);
            this.Controls.SetChildIndex(this.tipoCuenta1, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.DatosPersona datosPersona1;
        private Controles.TipoCuenta tipoCuenta1;
    }
}
