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
            this.tipo1 = new Sistema_Bancario.Controles.Tipo();
            this.monto1 = new Sistema_Bancario.Monto();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.tipoMoneda2 = new Sistema_Bancario.Controles.TipoMoneda();
            this.conversion2 = new Sistema_Bancario.Controles.Conversion();
            this.fecha1 = new Sistema_Bancario.Controles.Fecha();
            this.precios1 = new Sistema_Bancario.Controles.Precios();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(6, 239);
            this.proceder1.Size = new System.Drawing.Size(572, 40);
            // 
            // tipo1
            // 
            this.tipo1.Location = new System.Drawing.Point(8, 7);
            this.tipo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(157, 46);
            this.tipo1.TabIndex = 3;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(5, 69);
            this.monto1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(239, 25);
            this.monto1.TabIndex = 4;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(249, 69);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(171, 28);
            this.tipoMoneda1.TabIndex = 5;
            // 
            // tipoMoneda2
            // 
            this.tipoMoneda2.Location = new System.Drawing.Point(249, 101);
            this.tipoMoneda2.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMoneda2.Name = "tipoMoneda2";
            this.tipoMoneda2.Size = new System.Drawing.Size(160, 24);
            this.tipoMoneda2.TabIndex = 7;
            // 
            // conversion2
            // 
            this.conversion2.Location = new System.Drawing.Point(5, 101);
            this.conversion2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conversion2.Name = "conversion2";
            this.conversion2.Size = new System.Drawing.Size(224, 24);
            this.conversion2.TabIndex = 10;
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(184, 17);
            this.fecha1.Margin = new System.Windows.Forms.Padding(2);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(211, 28);
            this.fecha1.TabIndex = 11;
            // 
            // precios1
            // 
            this.precios1.Dock = System.Windows.Forms.DockStyle.Right;
            this.precios1.Location = new System.Drawing.Point(426, 6);
            this.precios1.Margin = new System.Windows.Forms.Padding(2);
            this.precios1.Name = "precios1";
            this.precios1.Size = new System.Drawing.Size(152, 233);
            this.precios1.TabIndex = 12;
            // 
            // Tipo_de_Cambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.precios1);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.conversion2);
            this.Controls.Add(this.tipoMoneda2);
            this.Controls.Add(this.tipoMoneda1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.tipo1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "Tipo_de_Cambio";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(584, 285);
            this.Controls.SetChildIndex(this.tipo1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.tipoMoneda1, 0);
            this.Controls.SetChildIndex(this.tipoMoneda2, 0);
            this.Controls.SetChildIndex(this.conversion2, 0);
            this.Controls.SetChildIndex(this.fecha1, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.precios1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.Tipo tipo1;
        private Monto monto1;
        private Controles.TipoMoneda tipoMoneda1;
        private Controles.TipoMoneda tipoMoneda2;
        private Controles.Conversion conversion2;
        private Controles.Fecha fecha1;
        private Controles.Precios precios1;
    }
}
