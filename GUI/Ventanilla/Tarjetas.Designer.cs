namespace Sistema_Bancario.Froms_opciones
{
    partial class Tarjetas
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
            this.nroTarjeta1 = new Sistema_Bancario.Controles.NroTarjeta();
            this.monto1 = new Sistema_Bancario.Monto();
            this.tipoMoneda1 = new Sistema_Bancario.Controles.TipoMoneda();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(6, 353);
            this.proceder1.Size = new System.Drawing.Size(644, 40);
            // 
            // nroTarjeta1
            // 
            this.nroTarjeta1.Location = new System.Drawing.Point(26, 22);
            this.nroTarjeta1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nroTarjeta1.Name = "nroTarjeta1";
            this.nroTarjeta1.Size = new System.Drawing.Size(260, 28);
            this.nroTarjeta1.TabIndex = 2;
            // 
            // monto1
            // 
            this.monto1.Location = new System.Drawing.Point(26, 249);
            this.monto1.Margin = new System.Windows.Forms.Padding(2);
            this.monto1.Name = "monto1";
            this.monto1.Size = new System.Drawing.Size(298, 25);
            this.monto1.TabIndex = 3;
            // 
            // tipoMoneda1
            // 
            this.tipoMoneda1.Location = new System.Drawing.Point(26, 215);
            this.tipoMoneda1.Margin = new System.Windows.Forms.Padding(2);
            this.tipoMoneda1.Name = "tipoMoneda1";
            this.tipoMoneda1.Size = new System.Drawing.Size(260, 24);
            this.tipoMoneda1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Tarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tipoMoneda1);
            this.Controls.Add(this.monto1);
            this.Controls.Add(this.nroTarjeta1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "Tarjetas";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(656, 399);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.nroTarjeta1, 0);
            this.Controls.SetChildIndex(this.monto1, 0);
            this.Controls.SetChildIndex(this.tipoMoneda1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.NroTarjeta nroTarjeta1;
        private Monto monto1;
        private Controles.TipoMoneda tipoMoneda1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}
