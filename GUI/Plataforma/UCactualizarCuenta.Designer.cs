namespace Sistema_Bancario.Plataforma
{
    partial class UCactualizarCuenta
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
            this.proceder1 = new Sistema_Bancario.Controles.Proceder();
            this.datosPersona1 = new Sistema_Bancario.Controles.DatosPersona();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(428, 325);
            this.proceder1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.proceder1.Name = "proceder1";
            this.proceder1.Size = new System.Drawing.Size(111, 40);
            this.proceder1.TabIndex = 0;
            // 
            // datosPersona1
            // 
            this.datosPersona1.Location = new System.Drawing.Point(24, 24);
            this.datosPersona1.Name = "datosPersona1";
            this.datosPersona1.Size = new System.Drawing.Size(376, 241);
            this.datosPersona1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(27, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarjeta";
            // 
            // UCactualizarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datosPersona1);
            this.Controls.Add(this.proceder1);
            this.Name = "UCactualizarCuenta";
            this.Size = new System.Drawing.Size(557, 381);
            this.Load += new System.EventHandler(this.UCactualizarCuenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.Proceder proceder1;
        private Controles.DatosPersona datosPersona1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
