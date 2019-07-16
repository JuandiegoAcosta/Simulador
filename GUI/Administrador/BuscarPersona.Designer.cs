namespace Sistema_Bancario.Administrador
{
    partial class BuscarPersona
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
            this.pnlBusquedaPersona = new System.Windows.Forms.Panel();
            this.lblBusquedaApellidos = new System.Windows.Forms.Label();
            this.lblBusquedaUsuarioNombres = new System.Windows.Forms.Label();
            this.btnBuscarEnBusqueda = new System.Windows.Forms.Button();
            this.txtBusquedaApellidos = new System.Windows.Forms.TextBox();
            this.txtBusquedaNombres = new System.Windows.Forms.TextBox();
            this.btnCancelarBusqueda = new System.Windows.Forms.Button();
            this.btnAceptarBusqueda = new System.Windows.Forms.Button();
            this.lblBusquedaPersona = new System.Windows.Forms.Label();
            this.dgvBusquedaUsuarios = new System.Windows.Forms.DataGridView();
            this.IdPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBusquedaPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusquedaPersona
            // 
            this.pnlBusquedaPersona.Controls.Add(this.lblBusquedaApellidos);
            this.pnlBusquedaPersona.Controls.Add(this.lblBusquedaUsuarioNombres);
            this.pnlBusquedaPersona.Controls.Add(this.btnBuscarEnBusqueda);
            this.pnlBusquedaPersona.Controls.Add(this.txtBusquedaApellidos);
            this.pnlBusquedaPersona.Controls.Add(this.txtBusquedaNombres);
            this.pnlBusquedaPersona.Controls.Add(this.btnCancelarBusqueda);
            this.pnlBusquedaPersona.Controls.Add(this.btnAceptarBusqueda);
            this.pnlBusquedaPersona.Controls.Add(this.lblBusquedaPersona);
            this.pnlBusquedaPersona.Controls.Add(this.dgvBusquedaUsuarios);
            this.pnlBusquedaPersona.Location = new System.Drawing.Point(28, 34);
            this.pnlBusquedaPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBusquedaPersona.Name = "pnlBusquedaPersona";
            this.pnlBusquedaPersona.Size = new System.Drawing.Size(853, 418);
            this.pnlBusquedaPersona.TabIndex = 8;
            // 
            // lblBusquedaApellidos
            // 
            this.lblBusquedaApellidos.AutoSize = true;
            this.lblBusquedaApellidos.Location = new System.Drawing.Point(436, 81);
            this.lblBusquedaApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusquedaApellidos.Name = "lblBusquedaApellidos";
            this.lblBusquedaApellidos.Size = new System.Drawing.Size(65, 17);
            this.lblBusquedaApellidos.TabIndex = 8;
            this.lblBusquedaApellidos.Text = "Apellidos";
            // 
            // lblBusquedaUsuarioNombres
            // 
            this.lblBusquedaUsuarioNombres.AutoSize = true;
            this.lblBusquedaUsuarioNombres.Location = new System.Drawing.Point(109, 82);
            this.lblBusquedaUsuarioNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusquedaUsuarioNombres.Name = "lblBusquedaUsuarioNombres";
            this.lblBusquedaUsuarioNombres.Size = new System.Drawing.Size(65, 17);
            this.lblBusquedaUsuarioNombres.TabIndex = 7;
            this.lblBusquedaUsuarioNombres.Text = "Nombres";
            // 
            // btnBuscarEnBusqueda
            // 
            this.btnBuscarEnBusqueda.Location = new System.Drawing.Point(701, 81);
            this.btnBuscarEnBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarEnBusqueda.Name = "btnBuscarEnBusqueda";
            this.btnBuscarEnBusqueda.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarEnBusqueda.TabIndex = 6;
            this.btnBuscarEnBusqueda.Text = "Buscar";
            this.btnBuscarEnBusqueda.UseVisualStyleBackColor = true;
            this.btnBuscarEnBusqueda.Click += new System.EventHandler(this.btnBuscarEnBusqueda_Click);
            // 
            // txtBusquedaApellidos
            // 
            this.txtBusquedaApellidos.Location = new System.Drawing.Point(543, 82);
            this.txtBusquedaApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBusquedaApellidos.Name = "txtBusquedaApellidos";
            this.txtBusquedaApellidos.Size = new System.Drawing.Size(132, 22);
            this.txtBusquedaApellidos.TabIndex = 5;
            // 
            // txtBusquedaNombres
            // 
            this.txtBusquedaNombres.Location = new System.Drawing.Point(207, 81);
            this.txtBusquedaNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBusquedaNombres.Name = "txtBusquedaNombres";
            this.txtBusquedaNombres.Size = new System.Drawing.Size(132, 22);
            this.txtBusquedaNombres.TabIndex = 4;
            // 
            // btnCancelarBusqueda
            // 
            this.btnCancelarBusqueda.Location = new System.Drawing.Point(459, 331);
            this.btnCancelarBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            this.btnCancelarBusqueda.Size = new System.Drawing.Size(100, 28);
            this.btnCancelarBusqueda.TabIndex = 3;
            this.btnCancelarBusqueda.Text = "Cancelar";
            this.btnCancelarBusqueda.UseVisualStyleBackColor = true;
            this.btnCancelarBusqueda.Click += new System.EventHandler(this.btnCancelarBusqueda_Click);
            // 
            // btnAceptarBusqueda
            // 
            this.btnAceptarBusqueda.Location = new System.Drawing.Point(240, 331);
            this.btnAceptarBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptarBusqueda.Name = "btnAceptarBusqueda";
            this.btnAceptarBusqueda.Size = new System.Drawing.Size(100, 28);
            this.btnAceptarBusqueda.TabIndex = 2;
            this.btnAceptarBusqueda.Text = "Aceptar";
            this.btnAceptarBusqueda.UseVisualStyleBackColor = true;
            this.btnAceptarBusqueda.Click += new System.EventHandler(this.btnAceptarBusqueda_Click);
            // 
            // lblBusquedaPersona
            // 
            this.lblBusquedaPersona.AutoSize = true;
            this.lblBusquedaPersona.Location = new System.Drawing.Point(365, 25);
            this.lblBusquedaPersona.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusquedaPersona.Name = "lblBusquedaPersona";
            this.lblBusquedaPersona.Size = new System.Drawing.Size(129, 17);
            this.lblBusquedaPersona.TabIndex = 1;
            this.lblBusquedaPersona.Text = "Busqueda Persona";
            // 
            // dgvBusquedaUsuarios
            // 
            this.dgvBusquedaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPersona,
            this.NombresPersona,
            this.ApellidosPersona,
            this.TipoDocPersona,
            this.NroDocPersona});
            this.dgvBusquedaUsuarios.Location = new System.Drawing.Point(84, 116);
            this.dgvBusquedaUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBusquedaUsuarios.Name = "dgvBusquedaUsuarios";
            this.dgvBusquedaUsuarios.Size = new System.Drawing.Size(644, 174);
            this.dgvBusquedaUsuarios.TabIndex = 0;
            this.dgvBusquedaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusquedaUsuarios_CellClick);
            // 
            // IdPersona
            // 
            this.IdPersona.HeaderText = "Id";
            this.IdPersona.Name = "IdPersona";
            this.IdPersona.Visible = false;
            // 
            // NombresPersona
            // 
            this.NombresPersona.HeaderText = "Nombres";
            this.NombresPersona.Name = "NombresPersona";
            this.NombresPersona.ReadOnly = true;
            this.NombresPersona.Width = 200;
            // 
            // ApellidosPersona
            // 
            this.ApellidosPersona.HeaderText = "Apellidos";
            this.ApellidosPersona.Name = "ApellidosPersona";
            this.ApellidosPersona.ReadOnly = true;
            this.ApellidosPersona.Width = 200;
            // 
            // TipoDocPersona
            // 
            this.TipoDocPersona.HeaderText = "Tipo documento";
            this.TipoDocPersona.Name = "TipoDocPersona";
            this.TipoDocPersona.ReadOnly = true;
            // 
            // NroDocPersona
            // 
            this.NroDocPersona.HeaderText = "Nro documento";
            this.NroDocPersona.Name = "NroDocPersona";
            this.NroDocPersona.ReadOnly = true;
            // 
            // BuscarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 468);
            this.Controls.Add(this.pnlBusquedaPersona);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BuscarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPersona";
            this.pnlBusquedaPersona.ResumeLayout(false);
            this.pnlBusquedaPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBusquedaPersona;
        private System.Windows.Forms.Label lblBusquedaApellidos;
        private System.Windows.Forms.Label lblBusquedaUsuarioNombres;
        private System.Windows.Forms.Button btnBuscarEnBusqueda;
        private System.Windows.Forms.TextBox txtBusquedaApellidos;
        private System.Windows.Forms.TextBox txtBusquedaNombres;
        private System.Windows.Forms.Button btnCancelarBusqueda;
        private System.Windows.Forms.Button btnAceptarBusqueda;
        private System.Windows.Forms.Label lblBusquedaPersona;
        private System.Windows.Forms.DataGridView dgvBusquedaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocPersona;
    }
}