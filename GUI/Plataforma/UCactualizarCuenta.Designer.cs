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
            this.datosPersona1 = new Sistema_Bancario.Controles.DatosPersona();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(10, 481);
            this.proceder1.Size = new System.Drawing.Size(548, 49);
            // 
            // datosPersona1
            // 
            this.datosPersona1.DatosValidos = false;
            this.datosPersona1.Location = new System.Drawing.Point(36, 20);
            this.datosPersona1.Margin = new System.Windows.Forms.Padding(5);
            this.datosPersona1.Name = "datosPersona1";
            this.datosPersona1.Size = new System.Drawing.Size(521, 297);
            this.datosPersona1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(46, 302);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(497, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarjeta";
            // 
            // UCactualizarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datosPersona1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCactualizarCuenta";
            this.Size = new System.Drawing.Size(568, 540);
            this.Load += new System.EventHandler(this.UCactualizarCuenta_Load);
            this.Controls.SetChildIndex(this.datosPersona1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.DatosPersona datosPersona1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
