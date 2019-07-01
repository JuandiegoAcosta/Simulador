namespace Sistema_Bancario.Froms_opciones
{
    partial class Transferencias
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
         this.disponible1 = new Sistema_Bancario.Controles.Disponible();
         this.monto1 = new Sistema_Bancario.Monto();
         this.nroCuenta1 = new Sistema_Bancario.Controles.NroCuenta();
         this.nroCuenta2 = new Sistema_Bancario.Controles.NroCuenta();
         this.Destino = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // proceder1
         // 
         this.proceder1.Location = new System.Drawing.Point(6, 572);
         this.proceder1.Size = new System.Drawing.Size(862, 40);
         // 
         // disponible1
         // 
         this.disponible1.Location = new System.Drawing.Point(282, 10);
         this.disponible1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.disponible1.Name = "disponible1";
         this.disponible1.Size = new System.Drawing.Size(161, 28);
         this.disponible1.TabIndex = 2;
         // 
         // monto1
         // 
         this.monto1.Location = new System.Drawing.Point(10, 43);
         this.monto1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.monto1.Name = "monto1";
         this.monto1.Size = new System.Drawing.Size(303, 25);
         this.monto1.TabIndex = 3;
         // 
         // nroCuenta1
         // 
         this.nroCuenta1.Location = new System.Drawing.Point(8, 11);
         this.nroCuenta1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.nroCuenta1.Name = "nroCuenta1";
         this.nroCuenta1.Size = new System.Drawing.Size(270, 30);
         this.nroCuenta1.TabIndex = 4;
         // 
         // nroCuenta2
         // 
         this.nroCuenta2.Location = new System.Drawing.Point(10, 73);
         this.nroCuenta2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.nroCuenta2.Name = "nroCuenta2";
         this.nroCuenta2.Size = new System.Drawing.Size(271, 30);
         this.nroCuenta2.TabIndex = 5;
         // 
         // Destino
         // 
         this.Destino.AutoSize = true;
         this.Destino.Location = new System.Drawing.Point(285, 80);
         this.Destino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.Destino.Name = "Destino";
         this.Destino.Size = new System.Drawing.Size(43, 13);
         this.Destino.TabIndex = 6;
         this.Destino.Text = "Destino";
         // 
         // Transferencias
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Controls.Add(this.Destino);
         this.Controls.Add(this.nroCuenta2);
         this.Controls.Add(this.nroCuenta1);
         this.Controls.Add(this.monto1);
         this.Controls.Add(this.disponible1);
         this.Name = "Transferencias";
         this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
         this.Size = new System.Drawing.Size(874, 618);
         this.Controls.SetChildIndex(this.proceder1, 0);
         this.Controls.SetChildIndex(this.disponible1, 0);
         this.Controls.SetChildIndex(this.monto1, 0);
         this.Controls.SetChildIndex(this.nroCuenta1, 0);
         this.Controls.SetChildIndex(this.nroCuenta2, 0);
         this.Controls.SetChildIndex(this.Destino, 0);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private Controles.Disponible disponible1;
        private Monto monto1;
        private Controles.NroCuenta nroCuenta1;
        private Controles.NroCuenta nroCuenta2;
        private System.Windows.Forms.Label Destino;
    }
}
