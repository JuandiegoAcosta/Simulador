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
            this.proceder1.Location = new System.Drawing.Point(8, 397);
            this.proceder1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.proceder1.Size = new System.Drawing.Size(1033, 49);
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
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Clave :";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(99, 146);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(267, 22);
            this.txtClave.TabIndex = 19;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(373, 104);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(184, 32);
            this.tipoMoneda1.TabIndex = 20;
            // 
            // nroCuenta1
            // 
            this.nroCuenta1.Location = new System.Drawing.Point(8, 10);
            this.nroCuenta1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nroCuenta1.Name = "nroCuenta1";
            this.nroCuenta1.Size = new System.Drawing.Size(1031, 95);
            this.nroCuenta1.TabIndex = 21;
            // 
            // doi1
            // 
            this.doi1.Location = new System.Drawing.Point(31, 177);
            this.doi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doi1.Name = "doi1";
            this.doi1.Size = new System.Drawing.Size(241, 33);
            this.doi1.TabIndex = 22;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(96, 107);
            this.monto1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(272, 27);
            this.monto1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Monto :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(31, 218);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 43, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 43, 0, 0);
            this.panel1.Size = new System.Drawing.Size(905, 0);
            this.panel1.TabIndex = 29;
            // 
            // Retiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.doi1);
            this.Controls.Add(this.nroCuenta1);
            this.Controls.Add(this.tipoMoneda1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Retiros";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(1049, 453);
            this.Tag = "1";
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
