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
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(6, 572);
            this.proceder1.Size = new System.Drawing.Size(862, 40);
            this.proceder1.Click += new System.EventHandler(this.BTProceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(22, 27);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(81, 13);
         this.label1.TabIndex = 19;
         this.label1.Text = "Num Chequera ";
         // 
         // btnNumero
         // 
         this.btnNumero.Location = new System.Drawing.Point(281, 22);
         this.btnNumero.Name = "btnNumero";
         this.btnNumero.Size = new System.Drawing.Size(37, 23);
         this.btnNumero.TabIndex = 18;
         this.btnNumero.Text = "...";
         this.btnNumero.UseVisualStyleBackColor = true;
         // 
         // txtNumero
         // 
         this.txtNumero.Location = new System.Drawing.Point(121, 23);
         this.txtNumero.Name = "txtNumero";
         this.txtNumero.Size = new System.Drawing.Size(154, 20);
         this.txtNumero.TabIndex = 17;
         // 
         // dtpFechaEmision
         // 
         this.dtpFechaEmision.Location = new System.Drawing.Point(120, 89);
         this.dtpFechaEmision.Name = "dtpFechaEmision";
         this.dtpFechaEmision.Size = new System.Drawing.Size(198, 20);
         this.dtpFechaEmision.TabIndex = 23;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(22, 93);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(82, 13);
         this.label3.TabIndex = 22;
         this.label3.Text = "Fecha Registro ";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(22, 61);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(79, 13);
         this.label2.TabIndex = 21;
         this.label2.Text = "Fecha Emision ";
         // 
         // dtpFechaRegistro
         // 
         this.dtpFechaRegistro.Location = new System.Drawing.Point(120, 57);
         this.dtpFechaRegistro.Name = "dtpFechaRegistro";
         this.dtpFechaRegistro.Size = new System.Drawing.Size(198, 20);
         this.dtpFechaRegistro.TabIndex = 20;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(23, 159);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(52, 13);
         this.label5.TabIndex = 27;
         this.label5.Text = "Cantidad ";
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
         this.cmbCantidad.Location = new System.Drawing.Point(121, 156);
         this.cmbCantidad.Name = "cmbCantidad";
         this.cmbCantidad.Size = new System.Drawing.Size(121, 21);
         this.cmbCantidad.TabIndex = 26;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(22, 127);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(43, 13);
         this.label4.TabIndex = 25;
         this.label4.Text = "Estado ";
         // 
         // cmbEstado
         // 
         this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbEstado.FormattingEnabled = true;
         this.cmbEstado.Items.AddRange(new object[] {
            "SOLICITADO",
            "EN ESPERA",
            "EMITIDO"});
         this.cmbEstado.Location = new System.Drawing.Point(121, 124);
         this.cmbEstado.Name = "cmbEstado";
         this.cmbEstado.Size = new System.Drawing.Size(121, 21);
         this.cmbEstado.TabIndex = 24;
         // 
         // UCchequeras
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
         this.Margin = new System.Windows.Forms.Padding(3);
         this.Name = "UCchequeras";
         this.Padding = new System.Windows.Forms.Padding(6);
         this.Size = new System.Drawing.Size(874, 618);
         this.Load += new System.EventHandler(this.MantenimientoChequeras_Load);
         this.Controls.SetChildIndex(this.txtNumero, 0);
         this.Controls.SetChildIndex(this.btnNumero, 0);
         this.Controls.SetChildIndex(this.label1, 0);
         this.Controls.SetChildIndex(this.dtpFechaRegistro, 0);
         this.Controls.SetChildIndex(this.label2, 0);
         this.Controls.SetChildIndex(this.label3, 0);
         this.Controls.SetChildIndex(this.dtpFechaEmision, 0);
         this.Controls.SetChildIndex(this.cmbEstado, 0);
         this.Controls.SetChildIndex(this.label4, 0);
         this.Controls.SetChildIndex(this.cmbCantidad, 0);
         this.Controls.SetChildIndex(this.label5, 0);
         this.Controls.SetChildIndex(this.proceder1, 0);
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
