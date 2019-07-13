namespace Sistema_Bancario.Ventanilla
{
    partial class Cheques
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.doi1 = new Sistema_Bancario.Doi();
            this.CKDeposito = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monto1 = new Sistema_Bancario.Monto();
            this.nroCuenta1 = new Sistema_Bancario.Controles.NroCuenta();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 1;
            // 
            // doi1
            // 
            this.doi1.Location = new System.Drawing.Point(323, 22);
            this.doi1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doi1.Name = "doi1";
            this.doi1.Size = new System.Drawing.Size(213, 27);
            this.doi1.TabIndex = 3;
            // 
            // CKDeposito
            // 
            this.CKDeposito.AutoSize = true;
            this.CKDeposito.Location = new System.Drawing.Point(101, 84);
            this.CKDeposito.Name = "CKDeposito";
            this.CKDeposito.Size = new System.Drawing.Size(68, 17);
            this.CKDeposito.TabIndex = 4;
            this.CKDeposito.Text = "Deposito";
            this.CKDeposito.UseVisualStyleBackColor = true;
            this.CKDeposito.CheckedChanged += new System.EventHandler(this.CKDeposito_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nro Cheque";
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(101, 53);
            this.monto1.Margin = new System.Windows.Forms.Padding(2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(205, 25);
            this.monto1.TabIndex = 6;
            // 
            // nroCuenta1
            // 
            this.nroCuenta1.Location = new System.Drawing.Point(10, 106);
            this.nroCuenta1.Margin = new System.Windows.Forms.Padding(2);
            this.nroCuenta1.Name = "nroCuenta1";
            this.nroCuenta1.Size = new System.Drawing.Size(270, 30);
            this.nroCuenta1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Monto";
            // 
            // Cheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nroCuenta1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CKDeposito);
            this.Controls.Add(this.doi1);
            this.Controls.Add(this.textBox1);
            this.Name = "Cheques";
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.doi1, 0);
            this.Controls.SetChildIndex(this.CKDeposito, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.nroCuenta1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private Doi doi1;
        private System.Windows.Forms.CheckBox CKDeposito;
        private System.Windows.Forms.Label label1;
        private Monto monto1;
        private Controles.NroCuenta nroCuenta1;
        private System.Windows.Forms.Label label2;
    }
}
