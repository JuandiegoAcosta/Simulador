namespace Sistema_Bancario.Froms_opciones
{
    partial class Retiros
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
         this.components = new System.ComponentModel.Container();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtMonto = new System.Windows.Forms.TextBox();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.txtDoi = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtNroTargeta = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.txtEstado = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.txtClave = new Sistema_Bancario.Controles.TextBoxViewPassword();
         this.SuspendLayout();
         // 
         // proceder1
         // 
         this.proceder1.Location = new System.Drawing.Point(6, 572);
         this.proceder1.Size = new System.Drawing.Size(862, 40);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(40, 63);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(50, 13);
         this.label1.TabIndex = 8;
         this.label1.Text = "Monto :";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(368, 63);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(39, 13);
         this.label2.TabIndex = 9;
         this.label2.Text = "DOI :";
         // 
         // txtMonto
         // 
         this.txtMonto.Location = new System.Drawing.Point(106, 60);
         this.txtMonto.Name = "txtMonto";
         this.txtMonto.Size = new System.Drawing.Size(201, 20);
         this.txtMonto.TabIndex = 10;
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
         // 
         // txtDoi
         // 
         this.txtDoi.Location = new System.Drawing.Point(413, 60);
         this.txtDoi.Name = "txtDoi";
         this.txtDoi.Size = new System.Drawing.Size(201, 20);
         this.txtDoi.TabIndex = 12;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(357, 90);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(49, 13);
         this.label3.TabIndex = 13;
         this.label3.Text = "Clave :";
         // 
         // txtNroTargeta
         // 
         this.txtNroTargeta.Location = new System.Drawing.Point(106, 87);
         this.txtNroTargeta.Name = "txtNroTargeta";
         this.txtNroTargeta.Size = new System.Drawing.Size(201, 20);
         this.txtNroTargeta.TabIndex = 15;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(10, 87);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(80, 13);
         this.label4.TabIndex = 16;
         this.label4.Text = "Nro Tarjeta :";
         // 
         // txtEstado
         // 
         this.txtEstado.Location = new System.Drawing.Point(106, 34);
         this.txtEstado.Name = "txtEstado";
         this.txtEstado.Size = new System.Drawing.Size(201, 20);
         this.txtEstado.TabIndex = 18;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(36, 37);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(54, 13);
         this.label5.TabIndex = 17;
         this.label5.Text = "Estado :";
         // 
         // txtClave
         // 
         this.txtClave.Location = new System.Drawing.Point(413, 87);
         this.txtClave.Name = "txtClave";
         this.txtClave.PasswordChar = '*';
         this.txtClave.Size = new System.Drawing.Size(201, 20);
         this.txtClave.TabIndex = 19;
         // 
         // Retiros
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Controls.Add(this.txtClave);
         this.Controls.Add(this.txtEstado);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.txtNroTargeta);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtDoi);
         this.Controls.Add(this.txtMonto);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Margin = new System.Windows.Forms.Padding(3);
         this.Name = "Retiros";
         this.Padding = new System.Windows.Forms.Padding(6);
         this.Controls.SetChildIndex(this.proceder1, 0);
         this.Controls.SetChildIndex(this.label1, 0);
         this.Controls.SetChildIndex(this.label2, 0);
         this.Controls.SetChildIndex(this.txtMonto, 0);
         this.Controls.SetChildIndex(this.txtDoi, 0);
         this.Controls.SetChildIndex(this.label3, 0);
         this.Controls.SetChildIndex(this.txtNroTargeta, 0);
         this.Controls.SetChildIndex(this.label4, 0);
         this.Controls.SetChildIndex(this.label5, 0);
         this.Controls.SetChildIndex(this.txtEstado, 0);
         this.Controls.SetChildIndex(this.txtClave, 0);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtMonto;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.TextBox txtDoi;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtNroTargeta;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtEstado;
      private System.Windows.Forms.Label label5;
      private Controles.TextBoxViewPassword txtClave;
   }
}
