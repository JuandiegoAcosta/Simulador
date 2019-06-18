namespace Sistema_Bancario.Froms_opciones
{
    partial class Servicios
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
            this.empresa1 = new Sistema_Bancario.Controles.Empresa();
            this.nroContrato1 = new Sistema_Bancario.Controles.NroContrato();
            this.GEmpresas = new System.Windows.Forms.DataGridView();
            this.GNroContrato = new System.Windows.Forms.DataGridView();
            this.BTBuscarEmpresa = new System.Windows.Forms.Button();
            this.BTNroContrato = new System.Windows.Forms.Button();
            this.Nombre_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Recaudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNroContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(8, 377);
            this.proceder1.Size = new System.Drawing.Size(672, 49);
            // 
            // empresa1
            // 
            this.empresa1.Location = new System.Drawing.Point(13, 14);
            this.empresa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empresa1.Name = "empresa1";
            this.empresa1.Size = new System.Drawing.Size(348, 32);
            this.empresa1.TabIndex = 3;
            // 
            // nroContrato1
            // 
            this.nroContrato1.Location = new System.Drawing.Point(13, 178);
            this.nroContrato1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nroContrato1.Name = "nroContrato1";
            this.nroContrato1.Size = new System.Drawing.Size(364, 34);
            this.nroContrato1.TabIndex = 4;
            // 
            // GEmpresas
            // 
            this.GEmpresas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Empresa});
            this.GEmpresas.Location = new System.Drawing.Point(13, 50);
            this.GEmpresas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GEmpresas.Name = "GEmpresas";
            this.GEmpresas.RowTemplate.Height = 24;
            this.GEmpresas.Size = new System.Drawing.Size(647, 121);
            this.GEmpresas.TabIndex = 5;
            // 
            // GNroContrato
            // 
            this.GNroContrato.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GNroContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GNroContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Empresa,
            this.Monto,
            this.Fecha_Vencimiento,
            this.Estado_Recaudo});
            this.GNroContrato.Location = new System.Drawing.Point(13, 218);
            this.GNroContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GNroContrato.Name = "GNroContrato";
            this.GNroContrato.RowTemplate.Height = 24;
            this.GNroContrato.Size = new System.Drawing.Size(647, 142);
            this.GNroContrato.TabIndex = 6;
            // 
            // BTBuscarEmpresa
            // 
            this.BTBuscarEmpresa.Location = new System.Drawing.Point(368, 14);
            this.BTBuscarEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTBuscarEmpresa.Name = "BTBuscarEmpresa";
            this.BTBuscarEmpresa.Size = new System.Drawing.Size(117, 31);
            this.BTBuscarEmpresa.TabIndex = 7;
            this.BTBuscarEmpresa.Text = "Buscar";
            this.BTBuscarEmpresa.UseVisualStyleBackColor = true;
            this.BTBuscarEmpresa.Click += new System.EventHandler(this.BTBuscarEmpresa_Click);
            // 
            // BTNroContrato
            // 
            this.BTNroContrato.Location = new System.Drawing.Point(383, 178);
            this.BTNroContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNroContrato.Name = "BTNroContrato";
            this.BTNroContrato.Size = new System.Drawing.Size(117, 34);
            this.BTNroContrato.TabIndex = 8;
            this.BTNroContrato.Text = "Buscar";
            this.BTNroContrato.UseVisualStyleBackColor = true;
            this.BTNroContrato.Click += new System.EventHandler(this.BTNroContrato_Click);
            // 
            // Nombre_Empresa
            // 
            this.Nombre_Empresa.HeaderText = "Empresa";
            this.Nombre_Empresa.Name = "Nombre_Empresa";
            // 
            // ID_Empresa
            // 
            this.ID_Empresa.HeaderText = "ID";
            this.ID_Empresa.Name = "ID_Empresa";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // Fecha_Vencimiento
            // 
            this.Fecha_Vencimiento.HeaderText = "Fecha Vencimiento";
            this.Fecha_Vencimiento.Name = "Fecha_Vencimiento";
            this.Fecha_Vencimiento.Width = 200;
            // 
            // Estado_Recaudo
            // 
            this.Estado_Recaudo.HeaderText = "Pagado";
            this.Estado_Recaudo.Name = "Estado_Recaudo";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.BTNroContrato);
            this.Controls.Add(this.BTBuscarEmpresa);
            this.Controls.Add(this.GNroContrato);
            this.Controls.Add(this.GEmpresas);
            this.Controls.Add(this.nroContrato1);
            this.Controls.Add(this.empresa1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Servicios";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(688, 433);
            this.Controls.SetChildIndex(this.empresa1, 0);
            this.Controls.SetChildIndex(this.nroContrato1, 0);
            this.Controls.SetChildIndex(this.GEmpresas, 0);
            this.Controls.SetChildIndex(this.GNroContrato, 0);
            this.Controls.SetChildIndex(this.BTBuscarEmpresa, 0);
            this.Controls.SetChildIndex(this.BTNroContrato, 0);
            this.Controls.SetChildIndex(this.proceder1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GNroContrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.Empresa empresa1;
        private Controles.NroContrato nroContrato1;
        private System.Windows.Forms.DataGridView GEmpresas;
        private System.Windows.Forms.DataGridView GNroContrato;
        private System.Windows.Forms.Button BTBuscarEmpresa;
        private System.Windows.Forms.Button BTNroContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Recaudo;
    }
}
