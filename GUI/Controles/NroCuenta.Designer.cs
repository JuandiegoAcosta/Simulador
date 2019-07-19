namespace Sistema_Bancario.Controles
{
    partial class NroCuenta
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
            this.LbTarjeta = new System.Windows.Forms.Label();
            this.TBNroCuenta = new System.Windows.Forms.TextBox();
            this.BtValidar = new System.Windows.Forms.Button();
            this.Lbestado = new System.Windows.Forms.Label();
            this.LbPersona = new System.Windows.Forms.Label();
            this.Lbmoneda = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAhorros = new System.Windows.Forms.RadioButton();
            this.rbtnCorriente = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbTarjeta
            // 
            this.LbTarjeta.AutoSize = true;
            this.LbTarjeta.Location = new System.Drawing.Point(2, 7);
            this.LbTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTarjeta.Name = "LbTarjeta";
            this.LbTarjeta.Size = new System.Drawing.Size(61, 13);
            this.LbTarjeta.TabIndex = 0;
            this.LbTarjeta.Text = "Nro Cuenta";
            // 
            // TBNroCuenta
            // 
            this.TBNroCuenta.Location = new System.Drawing.Point(111, 4);
            this.TBNroCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.TBNroCuenta.MaxLength = 14;
            this.TBNroCuenta.Name = "TBNroCuenta";
            this.TBNroCuenta.Size = new System.Drawing.Size(198, 20);
            this.TBNroCuenta.TabIndex = 1;
            this.TBNroCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNroCuenta_KeyPress);
            // 
            // BtValidar
            // 
            this.BtValidar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtValidar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtValidar.Location = new System.Drawing.Point(314, 3);
            this.BtValidar.Name = "BtValidar";
            this.BtValidar.Size = new System.Drawing.Size(75, 23);
            this.BtValidar.TabIndex = 28;
            this.BtValidar.Text = "Validar";
            this.BtValidar.UseVisualStyleBackColor = false;
            this.BtValidar.Click += new System.EventHandler(this.BtValidar_Click);
            // 
            // Lbestado
            // 
            this.Lbestado.AutoSize = true;
            this.Lbestado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbestado.Location = new System.Drawing.Point(183, 20);
            this.Lbestado.Name = "Lbestado";
            this.Lbestado.Size = new System.Drawing.Size(70, 13);
            this.Lbestado.TabIndex = 26;
            this.Lbestado.Text = "Estado : ??";
            this.Lbestado.Visible = false;
            // 
            // LbPersona
            // 
            this.LbPersona.AutoSize = true;
            this.LbPersona.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LbPersona.Location = new System.Drawing.Point(395, 7);
            this.LbPersona.Name = "LbPersona";
            this.LbPersona.Size = new System.Drawing.Size(64, 13);
            this.LbPersona.TabIndex = 30;
            this.LbPersona.Text = "Persona: ??";
            this.LbPersona.Visible = false;
            // 
            // Lbmoneda
            // 
            this.Lbmoneda.AutoSize = true;
            this.Lbmoneda.Location = new System.Drawing.Point(309, 20);
            this.Lbmoneda.Name = "Lbmoneda";
            this.Lbmoneda.Size = new System.Drawing.Size(72, 13);
            this.Lbmoneda.TabIndex = 31;
            this.Lbmoneda.Text = "Moneda :??";
            this.Lbmoneda.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAhorros);
            this.groupBox1.Controls.Add(this.Lbmoneda);
            this.groupBox1.Controls.Add(this.rbtnCorriente);
            this.groupBox1.Controls.Add(this.Lbestado);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 40);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUENTA";
            // 
            // rbtnAhorros
            // 
            this.rbtnAhorros.AutoSize = true;
            this.rbtnAhorros.Checked = true;
            this.rbtnAhorros.Location = new System.Drawing.Point(12, 20);
            this.rbtnAhorros.Name = "rbtnAhorros";
            this.rbtnAhorros.Size = new System.Drawing.Size(70, 17);
            this.rbtnAhorros.TabIndex = 3;
            this.rbtnAhorros.TabStop = true;
            this.rbtnAhorros.Text = "Ahorros";
            this.rbtnAhorros.UseVisualStyleBackColor = true;
            // 
            // rbtnCorriente
            // 
            this.rbtnCorriente.AutoSize = true;
            this.rbtnCorriente.Location = new System.Drawing.Point(88, 20);
            this.rbtnCorriente.Name = "rbtnCorriente";
            this.rbtnCorriente.Size = new System.Drawing.Size(79, 17);
            this.rbtnCorriente.TabIndex = 3;
            this.rbtnCorriente.Text = "Corriente";
            this.rbtnCorriente.UseVisualStyleBackColor = true;
            // 
            // NroCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbPersona);
            this.Controls.Add(this.BtValidar);
            this.Controls.Add(this.TBNroCuenta);
            this.Controls.Add(this.LbTarjeta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NroCuenta";
            this.Size = new System.Drawing.Size(741, 80);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox TBNroCuenta;
        private System.Windows.Forms.Label Lbestado;
        private System.Windows.Forms.Label LbPersona;
        public System.Windows.Forms.Label Lbmoneda;
        public System.Windows.Forms.Button BtValidar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnAhorros;
        private System.Windows.Forms.RadioButton rbtnCorriente;
        public System.Windows.Forms.Label LbTarjeta;
    }
}
