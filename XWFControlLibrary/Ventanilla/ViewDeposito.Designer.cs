namespace XWFControlLibrary.Ventanilla
{
   partial class ViewDeposito
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
         this.panel3 = new System.Windows.Forms.Panel();
         this.btnProceder = new System.Windows.Forms.Button();
         this.label15 = new System.Windows.Forms.Label();
         this.txtValue = new XWFControlLibrary.UI.control.DecimalTextBox();
         this.txtMonto = new XWFControlLibrary.UI.control.MoneyTextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.txtDOI = new XWFControlLibrary.UI.control.NumberTextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.txtDocumento = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.txtNombre = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txtNroCuenta = new XWFControlLibrary.UI.control.NumberTextBox();
         this.exChange1 = new XWFControlLibrary.UI.control.ExChange();
         this.panel3.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel3
         // 
         this.panel3.Controls.Add(this.btnProceder);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel3.Location = new System.Drawing.Point(0, 526);
         this.panel3.Name = "panel3";
         this.panel3.Padding = new System.Windows.Forms.Padding(10);
         this.panel3.Size = new System.Drawing.Size(802, 69);
         this.panel3.TabIndex = 17;
         // 
         // btnProceder
         // 
         this.btnProceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(96)))), ((int)(((byte)(147)))));
         this.btnProceder.Dock = System.Windows.Forms.DockStyle.Right;
         this.btnProceder.FlatAppearance.BorderSize = 0;
         this.btnProceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
         this.btnProceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
         this.btnProceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnProceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
         this.btnProceder.ForeColor = System.Drawing.SystemColors.Window;
         this.btnProceder.Location = new System.Drawing.Point(658, 10);
         this.btnProceder.Margin = new System.Windows.Forms.Padding(2);
         this.btnProceder.Name = "btnProceder";
         this.btnProceder.Size = new System.Drawing.Size(134, 49);
         this.btnProceder.TabIndex = 1;
         this.btnProceder.Text = "Proceder";
         this.btnProceder.UseVisualStyleBackColor = false;
         // 
         // label15
         // 
         this.label15.AutoSize = true;
         this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label15.Location = new System.Drawing.Point(35, 93);
         this.label15.Name = "label15";
         this.label15.Size = new System.Drawing.Size(67, 13);
         this.label15.TabIndex = 27;
         this.label15.Text = "pre monto :";
         // 
         // txtValue
         // 
         this.txtValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtValue.Location = new System.Drawing.Point(108, 89);
         this.txtValue.Name = "txtValue";
         this.txtValue.ShortcutsEnabled = false;
         this.txtValue.Size = new System.Drawing.Size(197, 22);
         this.txtValue.TabIndex = 26;
         this.txtValue.TextChanged += new System.EventHandler(this.TxtValue_TextChanged);
         // 
         // txtMonto
         // 
         this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtMonto.Location = new System.Drawing.Point(108, 121);
         this.txtMonto.Name = "txtMonto";
         this.txtMonto.ReadOnly = true;
         this.txtMonto.ShortcutsEnabled = false;
         this.txtMonto.Size = new System.Drawing.Size(197, 22);
         this.txtMonto.TabIndex = 25;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(69, 60);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(33, 13);
         this.label7.TabIndex = 24;
         this.label7.Text = "DOI :";
         // 
         // txtDOI
         // 
         this.txtDOI.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDOI.Location = new System.Drawing.Point(108, 56);
         this.txtDOI.Name = "txtDOI";
         this.txtDOI.ShortcutsEnabled = false;
         this.txtDOI.Size = new System.Drawing.Size(197, 22);
         this.txtDOI.TabIndex = 23;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(54, 125);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(48, 13);
         this.label6.TabIndex = 22;
         this.label6.Text = "Monto :";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(30, 26);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(72, 13);
         this.label5.TabIndex = 21;
         this.label5.Text = "Nro Cuenta :";
         // 
         // panel1
         // 
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Controls.Add(this.txtDocumento);
         this.panel1.Controls.Add(this.label4);
         this.panel1.Controls.Add(this.txtNombre);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Location = new System.Drawing.Point(329, 23);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(316, 50);
         this.panel1.TabIndex = 19;
         // 
         // txtDocumento
         // 
         this.txtDocumento.AutoSize = true;
         this.txtDocumento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDocumento.Location = new System.Drawing.Point(82, 26);
         this.txtDocumento.Name = "txtDocumento";
         this.txtDocumento.Size = new System.Drawing.Size(12, 13);
         this.txtDocumento.TabIndex = 5;
         this.txtDocumento.Text = "?";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(3, 26);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(73, 13);
         this.label4.TabIndex = 3;
         this.label4.Text = "Documento :";
         // 
         // txtNombre
         // 
         this.txtNombre.AutoSize = true;
         this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNombre.Location = new System.Drawing.Point(82, 9);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(12, 13);
         this.txtNombre.TabIndex = 2;
         this.txtNombre.Text = "?";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(22, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(54, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Nombre :";
         // 
         // txtNroCuenta
         // 
         this.txtNroCuenta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNroCuenta.Location = new System.Drawing.Point(108, 23);
         this.txtNroCuenta.Name = "txtNroCuenta";
         this.txtNroCuenta.ShortcutsEnabled = false;
         this.txtNroCuenta.Size = new System.Drawing.Size(197, 22);
         this.txtNroCuenta.TabIndex = 18;
         // 
         // exChange1
         // 
         this.exChange1.Location = new System.Drawing.Point(329, 79);
         this.exChange1.Name = "exChange1";
         this.exChange1.Size = new System.Drawing.Size(323, 104);
         this.exChange1.TabIndex = 18;
         // 
         // ViewDeposito
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.exChange1);
         this.Controls.Add(this.label15);
         this.Controls.Add(this.txtValue);
         this.Controls.Add(this.txtMonto);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.txtDOI);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.txtNroCuenta);
         this.Controls.Add(this.panel3);
         this.Name = "ViewDeposito";
         this.Size = new System.Drawing.Size(802, 595);
         this.panel3.ResumeLayout(false);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel panel3;
      public System.Windows.Forms.Button btnProceder;
      private System.Windows.Forms.Label label15;
      private UI.control.DecimalTextBox txtValue;
      private UI.control.MoneyTextBox txtMonto;
      private System.Windows.Forms.Label label7;
      private UI.control.NumberTextBox txtDOI;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label txtDocumento;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label txtNombre;
      private System.Windows.Forms.Label label1;
      private UI.control.NumberTextBox txtNroCuenta;
      private UI.control.ExChange exChange1;
   }
}
