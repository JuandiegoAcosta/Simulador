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
            this.label1 = new System.Windows.Forms.Label();
            this.TBNroCuenta = new System.Windows.Forms.TextBox();
            this.lbTipocuenta = new System.Windows.Forms.Label();
            this.BtValidar = new System.Windows.Forms.Button();
            this.Lbestado = new System.Windows.Forms.Label();
            this.LbPersona = new System.Windows.Forms.Label();
            this.Lbmoneda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro Cuenta";
            // 
            // TBNroCuenta
            // 
            this.TBNroCuenta.Location = new System.Drawing.Point(67, 4);
            this.TBNroCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.TBNroCuenta.MaxLength = 20;
            this.TBNroCuenta.Name = "TBNroCuenta";
            this.TBNroCuenta.Size = new System.Drawing.Size(198, 20);
            this.TBNroCuenta.TabIndex = 1;
            this.TBNroCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNroCuenta_KeyPress);
            // 
            // lbTipocuenta
            // 
            this.lbTipocuenta.AutoSize = true;
            this.lbTipocuenta.Location = new System.Drawing.Point(559, 8);
            this.lbTipocuenta.Name = "lbTipocuenta";
            this.lbTipocuenta.Size = new System.Drawing.Size(85, 13);
            this.lbTipocuenta.TabIndex = 29;
            this.lbTipocuenta.Text = "Tipo cuenta : ??";
            this.lbTipocuenta.Visible = false;
            // 
            // BtValidar
            // 
            this.BtValidar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtValidar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtValidar.Location = new System.Drawing.Point(270, 3);
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
            this.Lbestado.Location = new System.Drawing.Point(440, 8);
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
            this.LbPersona.Location = new System.Drawing.Point(3, 29);
            this.LbPersona.Name = "LbPersona";
            this.LbPersona.Size = new System.Drawing.Size(64, 13);
            this.LbPersona.TabIndex = 30;
            this.LbPersona.Text = "Persona: ??";
            this.LbPersona.Visible = false;
            // 
            // Lbmoneda
            // 
            this.Lbmoneda.AutoSize = true;
            this.Lbmoneda.Location = new System.Drawing.Point(358, 7);
            this.Lbmoneda.Name = "Lbmoneda";
            this.Lbmoneda.Size = new System.Drawing.Size(64, 13);
            this.Lbmoneda.TabIndex = 31;
            this.Lbmoneda.Text = "Moneda :??";
            this.Lbmoneda.Visible = false;
            // 
            // NroCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbmoneda);
            this.Controls.Add(this.LbPersona);
            this.Controls.Add(this.lbTipocuenta);
            this.Controls.Add(this.BtValidar);
            this.Controls.Add(this.Lbestado);
            this.Controls.Add(this.TBNroCuenta);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NroCuenta";
            this.Size = new System.Drawing.Size(704, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TBNroCuenta;
        private System.Windows.Forms.Label lbTipocuenta;
        private System.Windows.Forms.Label Lbestado;
        private System.Windows.Forms.Label LbPersona;
        public System.Windows.Forms.Label Lbmoneda;
        public System.Windows.Forms.Button BtValidar;
    }
}
