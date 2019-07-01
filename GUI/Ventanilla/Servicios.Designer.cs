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
         ((System.ComponentModel.ISupportInitialize)(this.GEmpresas)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.GNroContrato)).BeginInit();
         this.SuspendLayout();
         // 
         // proceder1
         // 
         this.proceder1.Location = new System.Drawing.Point(6, 572);
         this.proceder1.Size = new System.Drawing.Size(862, 40);
         // 
         // empresa1
         // 
         this.empresa1.Location = new System.Drawing.Point(10, 11);
         this.empresa1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.empresa1.Name = "empresa1";
         this.empresa1.Size = new System.Drawing.Size(261, 26);
         this.empresa1.TabIndex = 3;
         // 
         // nroContrato1
         // 
         this.nroContrato1.Location = new System.Drawing.Point(10, 219);
         this.nroContrato1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.nroContrato1.Name = "nroContrato1";
         this.nroContrato1.Size = new System.Drawing.Size(273, 28);
         this.nroContrato1.TabIndex = 4;
         // 
         // GEmpresas
         // 
         this.GEmpresas.AllowUserToAddRows = false;
         this.GEmpresas.AllowUserToDeleteRows = false;
         this.GEmpresas.BackgroundColor = System.Drawing.SystemColors.Control;
         this.GEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.GEmpresas.Location = new System.Drawing.Point(10, 41);
         this.GEmpresas.Margin = new System.Windows.Forms.Padding(2);
         this.GEmpresas.Name = "GEmpresas";
         this.GEmpresas.ReadOnly = true;
         this.GEmpresas.RowTemplate.Height = 24;
         this.GEmpresas.Size = new System.Drawing.Size(585, 174);
         this.GEmpresas.TabIndex = 5;
         // 
         // GNroContrato
         // 
         this.GNroContrato.AllowUserToAddRows = false;
         this.GNroContrato.AllowUserToDeleteRows = false;
         this.GNroContrato.BackgroundColor = System.Drawing.SystemColors.Control;
         this.GNroContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.GNroContrato.Location = new System.Drawing.Point(10, 251);
         this.GNroContrato.Margin = new System.Windows.Forms.Padding(2);
         this.GNroContrato.Name = "GNroContrato";
         this.GNroContrato.ReadOnly = true;
         this.GNroContrato.RowTemplate.Height = 24;
         this.GNroContrato.Size = new System.Drawing.Size(585, 197);
         this.GNroContrato.TabIndex = 6;
         // 
         // BTBuscarEmpresa
         // 
         this.BTBuscarEmpresa.Location = new System.Drawing.Point(276, 11);
         this.BTBuscarEmpresa.Margin = new System.Windows.Forms.Padding(2);
         this.BTBuscarEmpresa.Name = "BTBuscarEmpresa";
         this.BTBuscarEmpresa.Size = new System.Drawing.Size(88, 25);
         this.BTBuscarEmpresa.TabIndex = 7;
         this.BTBuscarEmpresa.Text = "Buscar";
         this.BTBuscarEmpresa.UseVisualStyleBackColor = true;
         this.BTBuscarEmpresa.Click += new System.EventHandler(this.BTBuscarEmpresa_Click);
         // 
         // BTNroContrato
         // 
         this.BTNroContrato.Location = new System.Drawing.Point(287, 219);
         this.BTNroContrato.Margin = new System.Windows.Forms.Padding(2);
         this.BTNroContrato.Name = "BTNroContrato";
         this.BTNroContrato.Size = new System.Drawing.Size(88, 28);
         this.BTNroContrato.TabIndex = 8;
         this.BTNroContrato.Text = "Buscar";
         this.BTNroContrato.UseVisualStyleBackColor = true;
         this.BTNroContrato.Click += new System.EventHandler(this.BTNroContrato_Click);
         // 
         // Servicios
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Controls.Add(this.BTNroContrato);
         this.Controls.Add(this.BTBuscarEmpresa);
         this.Controls.Add(this.GNroContrato);
         this.Controls.Add(this.GEmpresas);
         this.Controls.Add(this.nroContrato1);
         this.Controls.Add(this.empresa1);
         this.Margin = new System.Windows.Forms.Padding(3);
         this.Name = "Servicios";
         this.Padding = new System.Windows.Forms.Padding(6);
         this.Size = new System.Drawing.Size(874, 618);
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
    }
}
