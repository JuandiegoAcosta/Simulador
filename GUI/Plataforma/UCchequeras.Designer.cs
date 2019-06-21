namespace Sistema_Bancario.Plataforma
{
    partial class UCchequeras
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
            this.btnNumero = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Num Chequera (*)";
            // 
            // btnNumero
            // 
            this.btnNumero.Location = new System.Drawing.Point(375, 27);
            this.btnNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(49, 28);
            this.btnNumero.TabIndex = 18;
            this.btnNumero.Text = "...";
            this.btnNumero.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(161, 28);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(204, 22);
            this.txtNumero.TabIndex = 17;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Location = new System.Drawing.Point(160, 110);
            this.dtpFechaEmision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(263, 22);
            this.dtpFechaEmision.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha Registro (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha Emision (*)";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(160, 70);
            this.dtpFechaRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(263, 22);
            this.dtpFechaRegistro.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cantidad (*)";
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "150"});
            this.cmbCantidad.Location = new System.Drawing.Point(161, 192);
            this.cmbCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(160, 24);
            this.cmbCantidad.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Estado (*)";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "SOLICITADO",
            "EN ESPERA",
            "EMITIDO"});
            this.cmbEstado.Location = new System.Drawing.Point(161, 148);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(160, 24);
            this.cmbEstado.TabIndex = 24;
            // 
            // UCchequeras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dtpFechaEmision);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNumero);
            this.Controls.Add(this.txtNumero);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCchequeras";
            this.Size = new System.Drawing.Size(455, 375);
            this.Load += new System.EventHandler(this.MantenimientoChequeras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}
