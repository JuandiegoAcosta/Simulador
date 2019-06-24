namespace Sistema_Bancario.Plataforma
{
    partial class UCPrestamos
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
            this.groupPrestamo = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textInteres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.textMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSeguro = new System.Windows.Forms.ComboBox();
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(8, 643);
            this.proceder1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.proceder1.Size = new System.Drawing.Size(536, 49);
            // 
            // datosPersona1
            // 
            this.datosPersona1.DatosValidos = false;
            this.datosPersona1.Location = new System.Drawing.Point(19, 27);
            this.datosPersona1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.datosPersona1.Name = "datosPersona1";
            this.datosPersona1.Size = new System.Drawing.Size(517, 299);
            this.datosPersona1.TabIndex = 15;
            // 
            // groupPrestamo
            // 
            this.groupPrestamo.Controls.Add(this.textBox2);
            this.groupPrestamo.Controls.Add(this.textInteres);
            this.groupPrestamo.Controls.Add(this.label7);
            this.groupPrestamo.Controls.Add(this.label6);
            this.groupPrestamo.Controls.Add(this.label5);
            this.groupPrestamo.Controls.Add(this.numericUpDown1);
            this.groupPrestamo.Controls.Add(this.label4);
            this.groupPrestamo.Controls.Add(this.tipoMoneda1);
            this.groupPrestamo.Controls.Add(this.textMonto);
            this.groupPrestamo.Controls.Add(this.label3);
            this.groupPrestamo.Controls.Add(this.cmbSeguro);
            this.groupPrestamo.Controls.Add(this.cmbCuenta);
            this.groupPrestamo.Controls.Add(this.label2);
            this.groupPrestamo.Location = new System.Drawing.Point(21, 290);
            this.groupPrestamo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPrestamo.Name = "groupPrestamo";
            this.groupPrestamo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPrestamo.Size = new System.Drawing.Size(503, 311);
            this.groupPrestamo.TabIndex = 16;
            this.groupPrestamo.TabStop = false;
            this.groupPrestamo.Text = "Préstamo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 260);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 22);
            this.textBox2.TabIndex = 26;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textInteres
            // 
            this.textInteres.Location = new System.Drawing.Point(180, 185);
            this.textInteres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textInteres.Name = "textInteres";
            this.textInteres.Size = new System.Drawing.Size(199, 22);
            this.textInteres.TabIndex = 26;
            this.textInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Porcentaje de moratorios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Seguro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Porcentaje de interés";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(145, 145);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 22);
            this.numericUpDown1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Plazo en meses";
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(27, 71);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(243, 30);
            this.tipoMoneda1.TabIndex = 21;
            // 
            // textMonto
            // 
            this.textMonto.Location = new System.Drawing.Point(104, 110);
            this.textMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textMonto.Name = "textMonto";
            this.textMonto.Size = new System.Drawing.Size(144, 22);
            this.textMonto.TabIndex = 20;
            this.textMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Monto";
            // 
            // cmbSeguro
            // 
            this.cmbSeguro.FormattingEnabled = true;
            this.cmbSeguro.Items.AddRange(new object[] {
            "DNI",
            "PASAPORTE"});
            this.cmbSeguro.Location = new System.Drawing.Point(104, 222);
            this.cmbSeguro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSeguro.Name = "cmbSeguro";
            this.cmbSeguro.Size = new System.Drawing.Size(275, 24);
            this.cmbSeguro.TabIndex = 18;
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Items.AddRange(new object[] {
            "DNI",
            "PASAPORTE"});
            this.cmbCuenta.Location = new System.Drawing.Point(104, 39);
            this.cmbCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(275, 24);
            this.cmbCuenta.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cuenta";
            // 
            // UCPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupPrestamo);
            this.Controls.Add(this.datosPersona1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCPrestamos";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(552, 699);
            this.Load += new System.EventHandler(this.UCPrestamos_Load);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.datosPersona1, 0);
            this.Controls.SetChildIndex(this.groupPrestamo, 0);
            this.groupPrestamo.ResumeLayout(false);
            this.groupPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.DatosPersona datosPersona1;
        private System.Windows.Forms.GroupBox groupPrestamo;
        private System.Windows.Forms.TextBox textMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.Label label2;
        private Controles.TipoMoneda tipoMoneda1;
        private System.Windows.Forms.TextBox textInteres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSeguro;
    }
}
