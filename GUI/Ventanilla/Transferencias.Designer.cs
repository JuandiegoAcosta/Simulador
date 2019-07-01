namespace Sistema_Bancario.Froms_opciones
{
    partial class Transferencias
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
         this.txtEstado = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.txtNroCuentaOrigen = new System.Windows.Forms.TextBox();
         this.txtMonto = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txtNroCuentaDestino = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // proceder1
         // 
         this.proceder1.Location = new System.Drawing.Point(6, 572);
         this.proceder1.Size = new System.Drawing.Size(862, 40);
         // 
         // txtEstado
         // 
         this.txtEstado.Location = new System.Drawing.Point(551, 33);
         this.txtEstado.Name = "txtEstado";
         this.txtEstado.Size = new System.Drawing.Size(201, 20);
         this.txtEstado.TabIndex = 32;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(491, 36);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(54, 13);
         this.label5.TabIndex = 31;
         this.label5.Text = "Estado :";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(40, 62);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(133, 13);
         this.label4.TabIndex = 30;
         this.label4.Text = "Nro Cuenta (Origen) :";
         // 
         // txtNroCuentaOrigen
         // 
         this.txtNroCuentaOrigen.Location = new System.Drawing.Point(189, 59);
         this.txtNroCuentaOrigen.Name = "txtNroCuentaOrigen";
         this.txtNroCuentaOrigen.Size = new System.Drawing.Size(201, 20);
         this.txtNroCuentaOrigen.TabIndex = 29;
         // 
         // txtMonto
         // 
         this.txtMonto.Location = new System.Drawing.Point(189, 33);
         this.txtMonto.Name = "txtMonto";
         this.txtMonto.Size = new System.Drawing.Size(201, 20);
         this.txtMonto.TabIndex = 28;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(123, 36);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(50, 13);
         this.label3.TabIndex = 27;
         this.label3.Text = "Monto :";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(407, 59);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(138, 13);
         this.label1.TabIndex = 34;
         this.label1.Text = "Nro Cuenta (Destino) :";
         // 
         // txtNroCuentaDestino
         // 
         this.txtNroCuentaDestino.Location = new System.Drawing.Point(551, 59);
         this.txtNroCuentaDestino.Name = "txtNroCuentaDestino";
         this.txtNroCuentaDestino.Size = new System.Drawing.Size(201, 20);
         this.txtNroCuentaDestino.TabIndex = 33;
         // 
         // Transferencias
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtNroCuentaDestino);
         this.Controls.Add(this.txtEstado);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.txtNroCuentaOrigen);
         this.Controls.Add(this.txtMonto);
         this.Controls.Add(this.label3);
         this.Name = "Transferencias";
         this.Padding = new System.Windows.Forms.Padding(6);
         this.Controls.SetChildIndex(this.proceder1, 0);
         this.Controls.SetChildIndex(this.label3, 0);
         this.Controls.SetChildIndex(this.txtMonto, 0);
         this.Controls.SetChildIndex(this.txtNroCuentaOrigen, 0);
         this.Controls.SetChildIndex(this.label4, 0);
         this.Controls.SetChildIndex(this.label5, 0);
         this.Controls.SetChildIndex(this.txtEstado, 0);
         this.Controls.SetChildIndex(this.txtNroCuentaDestino, 0);
         this.Controls.SetChildIndex(this.label1, 0);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.TextBox txtEstado;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtNroCuentaOrigen;
      private System.Windows.Forms.TextBox txtMonto;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtNroCuentaDestino;
   }
}
