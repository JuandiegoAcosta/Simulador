﻿namespace Sistema_Bancario.Froms_opciones
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
         this.DNI = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.monto1 = new Sistema_Bancario.Monto();
         this.clave1 = new Sistema_Bancario.Controles.Clave();
         this.dni1 = new Sistema_Bancario.Controles.DNI();
         this.dni2 = new Sistema_Bancario.Controles.DNI();
         this.SuspendLayout();
         // 
         // proceder1
         // 
         this.proceder1.Location = new System.Drawing.Point(6, 572);
         this.proceder1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.proceder1.Size = new System.Drawing.Size(862, 40);
         // 
         // DNI
         // 
         this.DNI.AutoSize = true;
         this.DNI.Location = new System.Drawing.Point(13, 29);
         this.DNI.Name = "DNI";
         this.DNI.Size = new System.Drawing.Size(26, 13);
         this.DNI.TabIndex = 6;
         this.DNI.Text = "DNI";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(184, 29);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(65, 13);
         this.label2.TabIndex = 7;
         this.label2.Text = "DNI Destino";
         // 
         // monto1
         // 
         this.monto1.Location = new System.Drawing.Point(10, 61);
         this.monto1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.monto1.Name = "monto1";
         this.monto1.Size = new System.Drawing.Size(236, 25);
         this.monto1.TabIndex = 10;
         // 
         // clave1
         // 
         this.clave1.Location = new System.Drawing.Point(10, 100);
         this.clave1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.clave1.Name = "clave1";
         this.clave1.Size = new System.Drawing.Size(225, 26);
         this.clave1.TabIndex = 11;
         // 
         // dni1
         // 
         this.dni1.Location = new System.Drawing.Point(38, 24);
         this.dni1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.dni1.Name = "dni1";
         this.dni1.Size = new System.Drawing.Size(147, 25);
         this.dni1.TabIndex = 12;
         // 
         // dni2
         // 
         this.dni2.Location = new System.Drawing.Point(251, 24);
         this.dni2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.dni2.Name = "dni2";
         this.dni2.Size = new System.Drawing.Size(147, 25);
         this.dni2.TabIndex = 13;
         // 
         // Envio_Giros
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Controls.Add(this.dni2);
         this.Controls.Add(this.dni1);
         this.Controls.Add(this.clave1);
         this.Controls.Add(this.monto1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.DNI);
         this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
         this.Name = "Envio_Giros";
         this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
         this.Size = new System.Drawing.Size(874, 618);
         this.Controls.SetChildIndex(this.DNI, 0);
         this.Controls.SetChildIndex(this.label2, 0);
         this.Controls.SetChildIndex(this.monto1, 0);
         this.Controls.SetChildIndex(this.clave1, 0);
         this.Controls.SetChildIndex(this.dni1, 0);
         this.Controls.SetChildIndex(this.dni2, 0);
         this.Controls.SetChildIndex(this.proceder1, 0);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label label2;
        private Monto monto1;
        private Controles.Clave clave1;
        private Controles.DNI dni1;
        private Controles.DNI dni2;
    }
}
