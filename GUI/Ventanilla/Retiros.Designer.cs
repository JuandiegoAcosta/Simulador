namespace Sistema_Bancario.Froms_opciones
{
    partial class Retiros
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new Sistema_Bancario.Controles.TextBoxViewPassword();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.nroCuenta1 = new Sistema_Bancario.Controles.NroCuenta();
            this.doi1 = new Sistema_Bancario.Doi();
            this.monto1 = new Sistema_Bancario.Monto();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(6, 322);
            this.proceder1.Size = new System.Drawing.Size(716, 40);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Clave :";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(78, 95);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(201, 20);
            this.txtClave.TabIndex = 19;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(288, 63);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(138, 26);
            this.tipoMoneda1.TabIndex = 20;
            // 
            // nroCuenta1
            // 
            this.nroCuenta1.Location = new System.Drawing.Point(6, 8);
            this.nroCuenta1.Margin = new System.Windows.Forms.Padding(2);
            this.nroCuenta1.Name = "nroCuenta1";
            this.nroCuenta1.Size = new System.Drawing.Size(714, 51);
            this.nroCuenta1.TabIndex = 21;
            // 
            // doi1
            // 
            this.doi1.Location = new System.Drawing.Point(18, 120);
            this.doi1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doi1.Name = "doi1";
            this.doi1.Size = new System.Drawing.Size(181, 27);
            this.doi1.TabIndex = 22;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(75, 63);
            this.monto1.Margin = new System.Windows.Forms.Padding(2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(204, 22);
            this.monto1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Monto :";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(451, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 133);
            this.panel1.TabIndex = 25;
            // 
            // Retiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.doi1);
            this.Controls.Add(this.nroCuenta1);
            this.Controls.Add(this.tipoMoneda1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label3);
            this.Name = "Retiros";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(728, 368);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.tipoMoneda1, 0);
            this.Controls.SetChildIndex(this.nroCuenta1, 0);
            this.Controls.SetChildIndex(this.doi1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.Label label3;
      private Controles.TextBoxViewPassword txtClave;
        private Controles.TipoMoneda tipoMoneda1;
        private Controles.NroCuenta nroCuenta1;
        private Doi doi1;
        private Monto monto1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
