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
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoUsuario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.pnlSecundario = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpRoles = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgvRolesUsuario = new System.Windows.Forms.DataGridView();
            this.IdRolUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoRol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EditarRol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarRol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbpPermisos = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPermisosUsuario = new System.Windows.Forms.DataGridView();
            this.IdPermisoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Componente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoPermiso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EditarPermiso = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarPermiso = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbRolActivo = new System.Windows.Forms.CheckBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlSecundario.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesUsuario)).BeginInit();
            this.tbpPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosUsuario)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dgvUsuarios.Location = new System.Drawing.Point(19, 39);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(596, 405);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            this.dgvUsuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUsuarios_CellPainting);
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
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.btnAgregarUsuario);
            this.pnlPrincipal.Controls.Add(this.dgvUsuarios);
            this.pnlPrincipal.Location = new System.Drawing.Point(137, 474);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(690, 460);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Image = global::Sistema_Bancario.Properties.Resources.icons8_agregar_administrador_26;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(580, 2);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(35, 31);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // pnlSecundario
            // 
            this.pnlSecundario.Controls.Add(this.tabControl1);
            this.pnlSecundario.Location = new System.Drawing.Point(118, 29);
            this.pnlSecundario.Name = "pnlSecundario";
            this.pnlSecundario.Size = new System.Drawing.Size(690, 447);
            this.pnlSecundario.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpRoles);
            this.tabControl1.Controls.Add(this.tbpPermisos);
            this.tabControl1.Location = new System.Drawing.Point(19, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 428);
            this.tabControl1.TabIndex = 7;
            // 
            // tbpRoles
            // 
            this.tbpRoles.Controls.Add(this.button2);
            this.tbpRoles.Controls.Add(this.btnAtras);
            this.tbpRoles.Controls.Add(this.dgvRolesUsuario);
            this.tbpRoles.Location = new System.Drawing.Point(4, 22);
            this.tbpRoles.Name = "tbpRoles";
            this.tbpRoles.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpRoles.Size = new System.Drawing.Size(640, 402);
            this.tbpRoles.TabIndex = 0;
            this.tbpRoles.Text = "Roles";
            this.tbpRoles.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Sistema_Bancario.Properties.Resources.add_rol;
            this.button2.Location = new System.Drawing.Point(490, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 31);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(9, 9);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgvRolesUsuario
            // 
            this.dgvRolesUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolesUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRolUsuario,
            this.Rol,
            this.EstadoRol,
            this.EditarRol,
            this.EliminarRol});
            this.dgvRolesUsuario.Location = new System.Drawing.Point(114, 86);
            this.dgvRolesUsuario.Name = "dgvRolesUsuario";
            this.dgvRolesUsuario.Size = new System.Drawing.Size(412, 280);
            this.dgvRolesUsuario.TabIndex = 0;
            this.dgvRolesUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRolesUsuario_CellClick);
            this.dgvRolesUsuario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvRolesUsuario_CellPainting);
            // 
            // IdRolUsuario
            // 
            this.IdRolUsuario.HeaderText = "IdRolUsuario";
            this.IdRolUsuario.Name = "IdRolUsuario";
            this.IdRolUsuario.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 200;
            // 
            // EstadoRol
            // 
            this.EstadoRol.HeaderText = "Estado";
            this.EstadoRol.Name = "EstadoRol";
            this.EstadoRol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EstadoRol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EstadoRol.Width = 60;
            // 
            // EditarRol
            // 
            this.EditarRol.HeaderText = "EditarRol";
            this.EditarRol.Name = "EditarRol";
            this.EditarRol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditarRol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditarRol.Width = 60;
            // 
            // EliminarRol
            // 
            this.EliminarRol.HeaderText = "Eliminar";
            this.EliminarRol.Name = "EliminarRol";
            this.EliminarRol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EliminarRol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EliminarRol.Width = 60;
            // 
            // tbpPermisos
            // 
            this.tbpPermisos.Controls.Add(this.button1);
            this.tbpPermisos.Controls.Add(this.dgvPermisosUsuario);
            this.tbpPermisos.Location = new System.Drawing.Point(4, 22);
            this.tbpPermisos.Name = "tbpPermisos";
            this.tbpPermisos.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpPermisos.Size = new System.Drawing.Size(640, 402);
            this.tbpPermisos.TabIndex = 1;
            this.tbpPermisos.Text = "Permisos";
            this.tbpPermisos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Sistema_Bancario.Properties.Resources.add_permiso;
            this.button1.Location = new System.Drawing.Point(555, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 31);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvPermisosUsuario
            // 
            this.dgvPermisosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisosUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPermisoUsuario,
            this.Componente,
            this.EstadoPermiso,
            this.EditarPermiso,
            this.EliminarPermiso});
            this.dgvPermisosUsuario.Location = new System.Drawing.Point(58, 41);
            this.dgvPermisosUsuario.Name = "dgvPermisosUsuario";
            this.dgvPermisosUsuario.Size = new System.Drawing.Size(532, 327);
            this.dgvPermisosUsuario.TabIndex = 0;
            this.dgvPermisosUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisosUsuario_CellClick);
            this.dgvPermisosUsuario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPermisosUsuario_CellPainting);
            // 
            // IdPermisoUsuario
            // 
            this.IdPermisoUsuario.HeaderText = "Id";
            this.IdPermisoUsuario.Name = "IdPermisoUsuario";
            this.IdPermisoUsuario.Visible = false;
            // 
            // Componente
            // 
            this.Componente.HeaderText = "Componente";
            this.Componente.Name = "Componente";
            this.Componente.ReadOnly = true;
            this.Componente.Width = 200;
            // 
            // EstadoPermiso
            // 
            this.EstadoPermiso.HeaderText = "Estado";
            this.EstadoPermiso.Name = "EstadoPermiso";
            this.EstadoPermiso.Width = 60;
            // 
            // EditarPermiso
            // 
            this.EditarPermiso.HeaderText = "Editar";
            this.EditarPermiso.Name = "EditarPermiso";
            this.EditarPermiso.Width = 60;
            // 
            // EliminarPermiso
            // 
            this.EliminarPermiso.HeaderText = "Eliminar";
            this.EliminarPermiso.Name = "EliminarPermiso";
            this.EliminarPermiso.Width = 60;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbRolActivo);
            this.panel1.Controls.Add(this.cmbRoles);
            this.panel1.Controls.Add(this.btnAgregarRol);
            this.panel1.Location = new System.Drawing.Point(851, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 280);
            this.panel1.TabIndex = 8;
            // 
            // chbRolActivo
            // 
            this.chbRolActivo.AutoSize = true;
            this.chbRolActivo.Location = new System.Drawing.Point(100, 137);
            this.chbRolActivo.Name = "chbRolActivo";
            this.chbRolActivo.Size = new System.Drawing.Size(56, 17);
            this.chbRolActivo.TabIndex = 9;
            this.chbRolActivo.Text = "Activo";
            this.chbRolActivo.UseVisualStyleBackColor = true;
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(71, 90);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(121, 21);
            this.cmbRoles.TabIndex = 8;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Location = new System.Drawing.Point(88, 223);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(92, 23);
            this.btnAgregarRol.TabIndex = 7;
            this.btnAgregarRol.Text = "Agregar Rol";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSecundario);
            this.Name = "Usuario";
            this.Size = new System.Drawing.Size(1622, 873);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlSecundario.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesUsuario)).EndInit();
            this.tbpPermisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvPermisosUsuario;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRolUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EstadoRol;
        private System.Windows.Forms.DataGridViewButtonColumn EditarRol;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPermisoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Componente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EstadoPermiso;
        private System.Windows.Forms.DataGridViewButtonColumn EditarPermiso;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarPermiso;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
