namespace Sistema_Bancario.Ventanilla
{
   partial class Depositos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnAhorros = new System.Windows.Forms.RadioButton();
            this.rbtnCorriente = new System.Windows.Forms.RadioButton();
            this.rbtnCredito = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroCuenta = new System.Windows.Forms.TextBox();
            this.txtDoi = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(15, 700);
            this.proceder1.Size = new System.Drawing.Size(1135, 49);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMoneda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbtnAhorros);
            this.groupBox1.Controls.Add(this.rbtnCorriente);
            this.groupBox1.Controls.Add(this.rbtnCredito);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(521, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUENTA";
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(300, 26);
            this.cmbMoneda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(181, 25);
            this.cmbMoneda.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Moneda :";
            // 
            // rbtnAhorros
            // 
            this.rbtnAhorros.AutoSize = true;
            this.rbtnAhorros.Location = new System.Drawing.Point(21, 23);
            this.rbtnAhorros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnAhorros.Name = "rbtnAhorros";
            this.rbtnAhorros.Size = new System.Drawing.Size(86, 21);
            this.rbtnAhorros.TabIndex = 3;
            this.rbtnAhorros.TabStop = true;
            this.rbtnAhorros.Text = "Ahorros";
            this.rbtnAhorros.UseVisualStyleBackColor = true;
            // 
            // rbtnCorriente
            // 
            this.rbtnCorriente.AutoSize = true;
            this.rbtnCorriente.Location = new System.Drawing.Point(21, 80);
            this.rbtnCorriente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnCorriente.Name = "rbtnCorriente";
            this.rbtnCorriente.Size = new System.Drawing.Size(94, 21);
            this.rbtnCorriente.TabIndex = 3;
            this.rbtnCorriente.TabStop = true;
            this.rbtnCorriente.Text = "Corriente";
            this.rbtnCorriente.UseVisualStyleBackColor = true;
            // 
            // rbtnCredito
            // 
            this.rbtnCredito.AutoSize = true;
            this.rbtnCredito.Location = new System.Drawing.Point(21, 52);
            this.rbtnCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnCredito.Name = "rbtnCredito";
            this.rbtnCredito.Size = new System.Drawing.Size(80, 21);
            this.rbtnCredito.TabIndex = 2;
            this.rbtnCredito.TabStop = true;
            this.rbtnCredito.Text = "Credito";
            this.rbtnCredito.UseVisualStyleBackColor = true;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(572, 167);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(267, 22);
            this.txtEstado.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Estado :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nro Cuenta :";
            // 
            // txtNroCuenta
            // 
            this.txtNroCuenta.Location = new System.Drawing.Point(163, 167);
            this.txtNroCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNroCuenta.Name = "txtNroCuenta";
            this.txtNroCuenta.Size = new System.Drawing.Size(267, 22);
            this.txtNroCuenta.TabIndex = 23;
            // 
            // txtDoi
            // 
            this.txtDoi.Location = new System.Drawing.Point(572, 199);
            this.txtDoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoi.Name = "txtDoi";
            this.txtDoi.Size = new System.Drawing.Size(267, 22);
            this.txtDoi.TabIndex = 22;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(163, 199);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(267, 22);
            this.txtMonto.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "DOI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Monto :";
            // 
            // Depositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNroCuenta);
            this.Controls.Add(this.txtDoi);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Depositos";
            this.Padding = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtMonto, 0);
            this.Controls.SetChildIndex(this.txtDoi, 0);
            this.Controls.SetChildIndex(this.txtNroCuenta, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ComboBox cmbMoneda;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.RadioButton rbtnAhorros;
      private System.Windows.Forms.RadioButton rbtnCorriente;
      private System.Windows.Forms.RadioButton rbtnCredito;
      private System.Windows.Forms.TextBox txtEstado;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtNroCuenta;
      private System.Windows.Forms.TextBox txtDoi;
      private System.Windows.Forms.TextBox txtMonto;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
    }
}
