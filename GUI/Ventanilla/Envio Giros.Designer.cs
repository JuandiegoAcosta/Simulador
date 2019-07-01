namespace Sistema_Bancario.Froms_opciones
{
    partial class Envio_Giros
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
         this.txtDNIDestino = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.txtDNIOrigen = new System.Windows.Forms.TextBox();
         this.txtMonto = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.txtClave = new Sistema_Bancario.Controles.TextBoxViewPassword();
         this.SuspendLayout();
         // 
         // proceder1
         // 
         this.proceder1.Location = new System.Drawing.Point(6, 572);
         this.proceder1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.proceder1.Size = new System.Drawing.Size(862, 40);
         // 
         // txtDNIDestino
         // 
         this.txtDNIDestino.Location = new System.Drawing.Point(471, 37);
         this.txtDNIDestino.Name = "txtDNIDestino";
         this.txtDNIDestino.Size = new System.Drawing.Size(201, 20);
         this.txtDNIDestino.TabIndex = 34;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(370, 40);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(95, 13);
         this.label5.TabIndex = 33;
         this.label5.Text = "DNI (Destino) :";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(27, 37);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(90, 13);
         this.label4.TabIndex = 32;
         this.label4.Text = "DNI (Origen) :";
         // 
         // txtDNIOrigen
         // 
         this.txtDNIOrigen.Location = new System.Drawing.Point(133, 37);
         this.txtDNIOrigen.Name = "txtDNIOrigen";
         this.txtDNIOrigen.Size = new System.Drawing.Size(201, 20);
         this.txtDNIOrigen.TabIndex = 31;
         // 
         // txtMonto
         // 
         this.txtMonto.Location = new System.Drawing.Point(133, 63);
         this.txtMonto.Name = "txtMonto";
         this.txtMonto.Size = new System.Drawing.Size(201, 20);
         this.txtMonto.TabIndex = 29;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(416, 66);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(49, 13);
         this.label2.TabIndex = 28;
         this.label2.Text = "Clave :";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(67, 66);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(50, 13);
         this.label3.TabIndex = 27;
         this.label3.Text = "Monto :";
         // 
         // txtClave
         // 
         this.txtClave.Location = new System.Drawing.Point(471, 63);
         this.txtClave.Name = "txtClave";
         this.txtClave.PasswordChar = '*';
         this.txtClave.Size = new System.Drawing.Size(201, 20);
         this.txtClave.TabIndex = 35;
         // 
         // Envio_Giros
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Controls.Add(this.txtClave);
         this.Controls.Add(this.txtDNIDestino);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.txtDNIOrigen);
         this.Controls.Add(this.txtMonto);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label3);
         this.Margin = new System.Windows.Forms.Padding(3);
         this.Name = "Envio_Giros";
         this.Padding = new System.Windows.Forms.Padding(6);
         this.Controls.SetChildIndex(this.proceder1, 0);
         this.Controls.SetChildIndex(this.label3, 0);
         this.Controls.SetChildIndex(this.label2, 0);
         this.Controls.SetChildIndex(this.txtMonto, 0);
         this.Controls.SetChildIndex(this.txtDNIOrigen, 0);
         this.Controls.SetChildIndex(this.label4, 0);
         this.Controls.SetChildIndex(this.label5, 0);
         this.Controls.SetChildIndex(this.txtDNIDestino, 0);
         this.Controls.SetChildIndex(this.txtClave, 0);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.TextBox txtDNIDestino;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtDNIOrigen;
      private System.Windows.Forms.TextBox txtMonto;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private Controles.TextBoxViewPassword txtClave;
   }
}
