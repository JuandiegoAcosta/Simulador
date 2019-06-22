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
            this.BTBuscarCuota = new System.Windows.Forms.Button();
            this.GridPrestamos = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridCuotas = new System.Windows.Forms.DataGridView();
            this.BTFiltrarCuotas = new System.Windows.Forms.Button();
            this.nroCuenta1 = new Sistema_Bancario.Controles.NroCuenta();
            ((System.ComponentModel.ISupportInitialize)(this.GridPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(8, 602);
            this.proceder1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.proceder1.Size = new System.Drawing.Size(868, 49);
            // 
            // BTBuscarCuota
            // 
            this.BTBuscarCuota.BackColor = System.Drawing.Color.ForestGreen;
            this.BTBuscarCuota.FlatAppearance.BorderSize = 0;
            this.BTBuscarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBuscarCuota.ForeColor = System.Drawing.Color.White;
            this.BTBuscarCuota.Location = new System.Drawing.Point(377, 8);
            this.BTBuscarCuota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTBuscarCuota.Name = "BTBuscarCuota";
            this.BTBuscarCuota.Size = new System.Drawing.Size(75, 32);
            this.BTBuscarCuota.TabIndex = 4;
            this.BTBuscarCuota.Text = "Buscar";
            this.BTBuscarCuota.UseVisualStyleBackColor = false;
            this.BTBuscarCuota.Click += new System.EventHandler(this.BTBuscarCuota_Click);
            // 
            // GridPrestamos
            // 
            this.GridPrestamos.AllowUserToAddRows = false;
            this.GridPrestamos.AllowUserToDeleteRows = false;
            this.GridPrestamos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPrestamos.Location = new System.Drawing.Point(11, 86);
            this.GridPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridPrestamos.Name = "GridPrestamos";
            this.GridPrestamos.ReadOnly = true;
            this.GridPrestamos.RowTemplate.Height = 24;
            this.GridPrestamos.Size = new System.Drawing.Size(852, 186);
            this.GridPrestamos.TabIndex = 5;
            this.GridPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPrestamos_CellClick);
            this.GridPrestamos.SelectionChanged += new System.EventHandler(this.GridPrestamos_SelectionChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nro Prestamo";
            // 
            // GridCuotas
            // 
            this.GridCuotas.AllowUserToAddRows = false;
            this.GridCuotas.AllowUserToDeleteRows = false;
            this.GridCuotas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.GridCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCuotas.Location = new System.Drawing.Point(11, 278);
            this.GridCuotas.Margin = new System.Windows.Forms.Padding(4);
            this.GridCuotas.Name = "GridCuotas";
            this.GridCuotas.ReadOnly = true;
            this.GridCuotas.Size = new System.Drawing.Size(852, 294);
            this.GridCuotas.TabIndex = 8;
            // 
            // BTFiltrarCuotas
            // 
            this.BTFiltrarCuotas.BackColor = System.Drawing.Color.ForestGreen;
            this.BTFiltrarCuotas.FlatAppearance.BorderSize = 0;
            this.BTFiltrarCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTFiltrarCuotas.ForeColor = System.Drawing.Color.White;
            this.BTFiltrarCuotas.Location = new System.Drawing.Point(267, 50);
            this.BTFiltrarCuotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTFiltrarCuotas.Name = "BTFiltrarCuotas";
            this.BTFiltrarCuotas.Size = new System.Drawing.Size(75, 32);
            this.BTFiltrarCuotas.TabIndex = 9;
            this.BTFiltrarCuotas.Text = "Filtrar";
            this.BTFiltrarCuotas.UseVisualStyleBackColor = false;
            // 
            // nroCuenta1
            // 
            this.nroCuenta1.Location = new System.Drawing.Point(11, 8);
            this.nroCuenta1.Name = "nroCuenta1";
            this.nroCuenta1.Size = new System.Drawing.Size(360, 37);
            this.nroCuenta1.TabIndex = 10;
            // 
            // Cuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.nroCuenta1);
            this.Controls.Add(this.BTFiltrarCuotas);
            this.Controls.Add(this.GridCuotas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GridPrestamos);
            this.Controls.Add(this.BTBuscarCuota);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cuotas";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(884, 658);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.BTBuscarCuota, 0);
            this.Controls.SetChildIndex(this.GridPrestamos, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.GridCuotas, 0);
            this.Controls.SetChildIndex(this.BTFiltrarCuotas, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.nroCuenta1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GridPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTBuscarCuota;
        private System.Windows.Forms.DataGridView GridPrestamos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridCuotas;
        private System.Windows.Forms.Button BTFiltrarCuotas;
        private Controles.NroCuenta nroCuenta1;
    }
}
