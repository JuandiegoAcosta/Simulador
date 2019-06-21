namespace Sistema_Bancario
{
    partial class Cuotas
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
            this.nro_Documento1 = new Sistema_Bancario.Nro_Documento();
            this.BTBuscarCuota = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BTFiltrarCuotas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(6, 388);
            this.proceder1.Size = new System.Drawing.Size(497, 40);
            // 
            // nro_Documento1
            // 
            this.nro_Documento1.Location = new System.Drawing.Point(8, 11);
            this.nro_Documento1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nro_Documento1.Name = "nro_Documento1";
            this.nro_Documento1.Size = new System.Drawing.Size(334, 26);
            this.nro_Documento1.TabIndex = 3;
            // 
            // BTBuscarCuota
            // 
            this.BTBuscarCuota.BackColor = System.Drawing.Color.ForestGreen;
            this.BTBuscarCuota.FlatAppearance.BorderSize = 0;
            this.BTBuscarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBuscarCuota.ForeColor = System.Drawing.Color.White;
            this.BTBuscarCuota.Location = new System.Drawing.Point(346, 11);
            this.BTBuscarCuota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTBuscarCuota.Name = "BTBuscarCuota";
            this.BTBuscarCuota.Size = new System.Drawing.Size(56, 26);
            this.BTBuscarCuota.TabIndex = 4;
            this.BTBuscarCuota.Text = "Buscar";
            this.BTBuscarCuota.UseVisualStyleBackColor = false;
            this.BTBuscarCuota.Click += new System.EventHandler(this.BTBuscarCuota_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(486, 71);
            this.dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nro Prestamo";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 150);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(486, 213);
            this.dataGridView2.TabIndex = 8;
            // 
            // BTFiltrarCuotas
            // 
            this.BTFiltrarCuotas.BackColor = System.Drawing.Color.ForestGreen;
            this.BTFiltrarCuotas.FlatAppearance.BorderSize = 0;
            this.BTFiltrarCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTFiltrarCuotas.ForeColor = System.Drawing.Color.White;
            this.BTFiltrarCuotas.Location = new System.Drawing.Point(200, 41);
            this.BTFiltrarCuotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTFiltrarCuotas.Name = "BTFiltrarCuotas";
            this.BTFiltrarCuotas.Size = new System.Drawing.Size(56, 26);
            this.BTFiltrarCuotas.TabIndex = 9;
            this.BTFiltrarCuotas.Text = "Filtrar";
            this.BTFiltrarCuotas.UseVisualStyleBackColor = false;
            // 
            // Cuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.BTFiltrarCuotas);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTBuscarCuota);
            this.Controls.Add(this.nro_Documento1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "Cuotas";
            this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Size = new System.Drawing.Size(509, 434);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.nro_Documento1, 0);
            this.Controls.SetChildIndex(this.BTBuscarCuota, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.BTFiltrarCuotas, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Nro_Documento nro_Documento1;
        private System.Windows.Forms.Button BTBuscarCuota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BTFiltrarCuotas;
    }
}
