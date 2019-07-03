namespace Sistema_Bancario.Froms_opciones
{
    partial class Tipo_de_Cambio
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
         this.precios1 = new Sistema_Bancario.Controles.Precios();
         this.label4 = new System.Windows.Forms.Label();
         this.txtMonto = new System.Windows.Forms.TextBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.cmbMonedaOrigen = new System.Windows.Forms.ComboBox();
         this.rbtnCompra = new System.Windows.Forms.RadioButton();
         this.rbtnVenta = new System.Windows.Forms.RadioButton();
         this.dtpFecha = new System.Windows.Forms.DateTimePicker();
         this.label1 = new System.Windows.Forms.Label();
         this.txtConversion = new System.Windows.Forms.TextBox();
         this.cmbMonedaDestino = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // proceder1
         // 
         this.proceder1.Location = new System.Drawing.Point(6, 572);
         this.proceder1.Size = new System.Drawing.Size(710, 40);
         // 
         // precios1
         // 
         this.precios1.Dock = System.Windows.Forms.DockStyle.Right;
         this.precios1.Location = new System.Drawing.Point(716, 6);
         this.precios1.Margin = new System.Windows.Forms.Padding(2);
         this.precios1.Name = "precios1";
         this.precios1.Size = new System.Drawing.Size(152, 606);
         this.precios1.TabIndex = 12;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(329, 92);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(50, 13);
         this.label4.TabIndex = 27;
         this.label4.Text = "Monto :";
         // 
         // txtMonto
         // 
         this.txtMonto.Location = new System.Drawing.Point(394, 89);
         this.txtMonto.Name = "txtMonto";
         this.txtMonto.Size = new System.Drawing.Size(201, 20);
         this.txtMonto.TabIndex = 26;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.rbtnCompra);
         this.groupBox1.Controls.Add(this.rbtnVenta);
         this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.Location = new System.Drawing.Point(16, 17);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(163, 50);
         this.groupBox1.TabIndex = 25;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "PROCESO";
         // 
         // cmbMonedaOrigen
         // 
         this.cmbMonedaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbMonedaOrigen.FormattingEnabled = true;
         this.cmbMonedaOrigen.Location = new System.Drawing.Point(144, 89);
         this.cmbMonedaOrigen.Name = "cmbMonedaOrigen";
         this.cmbMonedaOrigen.Size = new System.Drawing.Size(137, 21);
         this.cmbMonedaOrigen.TabIndex = 5;
         // 
         // rbtnCompra
         // 
         this.rbtnCompra.AutoSize = true;
         this.rbtnCompra.Location = new System.Drawing.Point(16, 19);
         this.rbtnCompra.Name = "rbtnCompra";
         this.rbtnCompra.Size = new System.Drawing.Size(71, 17);
         this.rbtnCompra.TabIndex = 3;
         this.rbtnCompra.TabStop = true;
         this.rbtnCompra.Text = "Compra";
         this.rbtnCompra.UseVisualStyleBackColor = true;
         // 
         // rbtnVenta
         // 
         this.rbtnVenta.AutoSize = true;
         this.rbtnVenta.Location = new System.Drawing.Point(100, 20);
         this.rbtnVenta.Name = "rbtnVenta";
         this.rbtnVenta.Size = new System.Drawing.Size(57, 17);
         this.rbtnVenta.TabIndex = 2;
         this.rbtnVenta.TabStop = true;
         this.rbtnVenta.Text = "Venta";
         this.rbtnVenta.UseVisualStyleBackColor = true;
         // 
         // dtpFecha
         // 
         this.dtpFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dtpFecha.Location = new System.Drawing.Point(213, 44);
         this.dtpFecha.Name = "dtpFecha";
         this.dtpFecha.Size = new System.Drawing.Size(105, 20);
         this.dtpFecha.TabIndex = 28;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(298, 115);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(81, 13);
         this.label1.TabIndex = 30;
         this.label1.Text = "Conversión :";
         // 
         // txtConversion
         // 
         this.txtConversion.Location = new System.Drawing.Point(394, 115);
         this.txtConversion.Name = "txtConversion";
         this.txtConversion.Size = new System.Drawing.Size(201, 20);
         this.txtConversion.TabIndex = 29;
         // 
         // cmbMonedaDestino
         // 
         this.cmbMonedaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbMonedaDestino.FormattingEnabled = true;
         this.cmbMonedaDestino.Location = new System.Drawing.Point(144, 115);
         this.cmbMonedaDestino.Name = "cmbMonedaDestino";
         this.cmbMonedaDestino.Size = new System.Drawing.Size(137, 21);
         this.cmbMonedaDestino.TabIndex = 31;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(18, 92);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(112, 13);
         this.label2.TabIndex = 32;
         this.label2.Text = "Moneda (Origen) :";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(18, 118);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(117, 13);
         this.label3.TabIndex = 33;
         this.label3.Text = "Moneda (Destino) :";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(210, 24);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(49, 13);
         this.label5.TabIndex = 34;
         this.label5.Text = "Fecha :";
         // 
         // Tipo_de_Cambio
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.cmbMonedaDestino);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtConversion);
         this.Controls.Add(this.dtpFecha);
         this.Controls.Add(this.cmbMonedaOrigen);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.txtMonto);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.precios1);
         this.Margin = new System.Windows.Forms.Padding(3);
         this.Name = "Tipo_de_Cambio";
         this.Padding = new System.Windows.Forms.Padding(6);
         this.Controls.SetChildIndex(this.precios1, 0);
         this.Controls.SetChildIndex(this.groupBox1, 0);
         this.Controls.SetChildIndex(this.txtMonto, 0);
         this.Controls.SetChildIndex(this.label4, 0);
         this.Controls.SetChildIndex(this.cmbMonedaOrigen, 0);
         this.Controls.SetChildIndex(this.dtpFecha, 0);
         this.Controls.SetChildIndex(this.proceder1, 0);
         this.Controls.SetChildIndex(this.txtConversion, 0);
         this.Controls.SetChildIndex(this.label1, 0);
         this.Controls.SetChildIndex(this.cmbMonedaDestino, 0);
         this.Controls.SetChildIndex(this.label2, 0);
         this.Controls.SetChildIndex(this.label3, 0);
         this.Controls.SetChildIndex(this.label5, 0);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion
        private Controles.Precios precios1;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtMonto;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton rbtnCompra;
      private System.Windows.Forms.RadioButton rbtnVenta;
      private System.Windows.Forms.ComboBox cmbMonedaOrigen;
      private System.Windows.Forms.DateTimePicker dtpFecha;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtConversion;
      private System.Windows.Forms.ComboBox cmbMonedaDestino;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label5;
   }
}
