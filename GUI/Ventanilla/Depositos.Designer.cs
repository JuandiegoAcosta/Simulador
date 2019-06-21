namespace Sistema_Bancario.Froms_opciones
{
    partial class Depositos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tipoCuenta1 = new Sistema_Bancario.Controles.TipoCuenta();
            this.nroCuenta1 = new Sistema_Bancario.Controles.NroCuenta();
            this.disponible1 = new Sistema_Bancario.Controles.Disponible();
            this.monto1 = new Sistema_Bancario.Monto();
            this.dni1 = new Sistema_Bancario.Dni();
            this.SuspendLayout();
         
            // 
            // tipoCuenta1
            // 
            this.tipoCuenta1.Location = new System.Drawing.Point(11, 9);
            this.tipoCuenta1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoCuenta1.Name = "tipoCuenta1";
            this.tipoCuenta1.Size = new System.Drawing.Size(232, 107);
            this.tipoCuenta1.TabIndex = 2;
            // 
            // nroCuenta1
            // 
            this.nroCuenta1.Location = new System.Drawing.Point(11, 135);
            this.nroCuenta1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nroCuenta1.Name = "nroCuenta1";
            this.nroCuenta1.Size = new System.Drawing.Size(360, 37);
            this.nroCuenta1.TabIndex = 3;
            // 
            // disponible1
            // 
            this.disponible1.Location = new System.Drawing.Point(394, 135);
            this.disponible1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disponible1.Name = "disponible1";
            this.disponible1.Size = new System.Drawing.Size(219, 34);
            this.disponible1.TabIndex = 4;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(11, 179);
            this.monto1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(321, 31);
            this.monto1.TabIndex = 5;
            // 
            // dni1
            // 
            this.dni1.Location = new System.Drawing.Point(394, 177);
            this.dni1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dni1.Name = "dni1";
            this.dni1.Size = new System.Drawing.Size(235, 33);
            this.dni1.TabIndex = 6;
            // 
            // Depositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.dni1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.disponible1);
            this.Controls.Add(this.nroCuenta1);
            this.Controls.Add(this.tipoCuenta1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Depositos";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(671, 312);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.tipoCuenta1, 0);
            this.Controls.SetChildIndex(this.nroCuenta1, 0);
            this.Controls.SetChildIndex(this.disponible1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.dni1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.TipoCuenta tipoCuenta1;
        private Controles.NroCuenta nroCuenta1;
        private Controles.Disponible disponible1;
        private Monto monto1;
        private Dni dni1;
    }
}
