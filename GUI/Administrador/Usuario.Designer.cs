namespace Sistema_Bancario.Administrador
{
    partial class Usuario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlSecundario = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpRoles = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbRolActivo = new System.Windows.Forms.CheckBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgvRolesUsuario = new System.Windows.Forms.DataGridView();
            this.tbpPermisos = new System.Windows.Forms.TabPage();
            this.dgvPermisosRol = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoUsuario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlSecundario.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpRoles.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesUsuario)).BeginInit();
            this.tbpPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosRol)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.NombreUsuario,
            this.ApellidosUsuario,
            this.EstadoUsuario,
            this.Editar,
            this.Eliminar});
            this.dgvUsuarios.Location = new System.Drawing.Point(25, 48);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(795, 499);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            this.dgvUsuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUsuarios_CellPainting);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.btnAgregarUsuario);
            this.pnlPrincipal.Controls.Add(this.dgvUsuarios);
            this.pnlPrincipal.Location = new System.Drawing.Point(180, 53);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(920, 566);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // pnlSecundario
            // 
            this.pnlSecundario.Controls.Add(this.tabControl1);
            this.pnlSecundario.Location = new System.Drawing.Point(184, 142);
            this.pnlSecundario.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSecundario.Name = "pnlSecundario";
            this.pnlSecundario.Size = new System.Drawing.Size(920, 460);
            this.pnlSecundario.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpRoles);
            this.tabControl1.Controls.Add(this.tbpPermisos);
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(823, 437);
            this.tabControl1.TabIndex = 7;
            // 
            // tbpRoles
            // 
            this.tbpRoles.Controls.Add(this.panel1);
            this.tbpRoles.Controls.Add(this.btnAtras);
            this.tbpRoles.Controls.Add(this.dgvRolesUsuario);
            this.tbpRoles.Location = new System.Drawing.Point(4, 25);
            this.tbpRoles.Margin = new System.Windows.Forms.Padding(4);
            this.tbpRoles.Name = "tbpRoles";
            this.tbpRoles.Padding = new System.Windows.Forms.Padding(4);
            this.tbpRoles.Size = new System.Drawing.Size(815, 408);
            this.tbpRoles.TabIndex = 0;
            this.tbpRoles.Text = "Roles";
            this.tbpRoles.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbRolActivo);
            this.panel1.Controls.Add(this.cmbRoles);
            this.panel1.Controls.Add(this.btnAgregarRol);
            this.panel1.Location = new System.Drawing.Point(432, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 345);
            this.panel1.TabIndex = 8;
            // 
            // chbRolActivo
            // 
            this.chbRolActivo.AutoSize = true;
            this.chbRolActivo.Location = new System.Drawing.Point(133, 169);
            this.chbRolActivo.Margin = new System.Windows.Forms.Padding(4);
            this.chbRolActivo.Name = "chbRolActivo";
            this.chbRolActivo.Size = new System.Drawing.Size(68, 21);
            this.chbRolActivo.TabIndex = 9;
            this.chbRolActivo.Text = "Activo";
            this.chbRolActivo.UseVisualStyleBackColor = true;
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(95, 111);
            this.cmbRoles.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(160, 24);
            this.cmbRoles.TabIndex = 8;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Location = new System.Drawing.Point(117, 274);
            this.btnAgregarRol.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(123, 28);
            this.btnAgregarRol.TabIndex = 7;
            this.btnAgregarRol.Text = "Agregar Rol";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 11);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 28);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgvRolesUsuario
            // 
            this.dgvRolesUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolesUsuario.Location = new System.Drawing.Point(12, 47);
            this.dgvRolesUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRolesUsuario.Name = "dgvRolesUsuario";
            this.dgvRolesUsuario.Size = new System.Drawing.Size(344, 345);
            this.dgvRolesUsuario.TabIndex = 0;
            // 
            // tbpPermisos
            // 
            this.tbpPermisos.Controls.Add(this.dgvPermisosRol);
            this.tbpPermisos.Location = new System.Drawing.Point(4, 25);
            this.tbpPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.tbpPermisos.Name = "tbpPermisos";
            this.tbpPermisos.Padding = new System.Windows.Forms.Padding(4);
            this.tbpPermisos.Size = new System.Drawing.Size(815, 408);
            this.tbpPermisos.TabIndex = 1;
            this.tbpPermisos.Text = "Permisos";
            this.tbpPermisos.UseVisualStyleBackColor = true;
            // 
            // dgvPermisosRol
            // 
            this.dgvPermisosRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisosRol.Location = new System.Drawing.Point(8, 7);
            this.dgvPermisosRol.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPermisosRol.Name = "dgvPermisosRol";
            this.dgvPermisosRol.Size = new System.Drawing.Size(793, 402);
            this.dgvPermisosRol.TabIndex = 0;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Visible = false;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "Nombres";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 200;
            // 
            // ApellidosUsuario
            // 
            this.ApellidosUsuario.HeaderText = "Apellidos";
            this.ApellidosUsuario.Name = "ApellidosUsuario";
            this.ApellidosUsuario.ReadOnly = true;
            this.ApellidosUsuario.Width = 200;
            // 
            // EstadoUsuario
            // 
            this.EstadoUsuario.HeaderText = "Estado";
            this.EstadoUsuario.Name = "EstadoUsuario";
            this.EstadoUsuario.Width = 60;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 60;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 60;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Image = global::Sistema_Bancario.Properties.Resources.icons8_agregar_administrador_26;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(773, 3);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(47, 38);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSecundario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Usuario";
            this.Size = new System.Drawing.Size(2163, 668);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlSecundario.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpRoles.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesUsuario)).EndInit();
            this.tbpPermisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlSecundario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpRoles;
        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dgvRolesUsuario;
        private System.Windows.Forms.TabPage tbpPermisos;
        private System.Windows.Forms.DataGridView dgvPermisosRol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbRolActivo;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosUsuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EstadoUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button btnAgregarUsuario;
    }
}
