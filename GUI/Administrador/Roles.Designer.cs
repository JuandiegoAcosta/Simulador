namespace Sistema_Bancario.Administrador
{
    partial class Roles
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
            this.lblRol = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditarRol = new System.Windows.Forms.Button();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlSecundario = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpUsuarios = new System.Windows.Forms.TabPage();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tbpPermisos = new System.Windows.Forms.TabPage();
            this.pnlAgregarUsuario = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertarUsuario = new System.Windows.Forms.Button();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlSecundario.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlAgregarUsuario.SuspendLayout();
            this.pnlBusquedaPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(455, 49);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(73, 13);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Nombre de rol";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(458, 65);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(100, 20);
            this.txtRol.TabIndex = 1;
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(22, 33);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(343, 283);
            this.dgvRoles.TabIndex = 2;
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick);
            this.dgvRoles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(458, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar rol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // btnEditarRol
            // 
            this.btnEditarRol.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRol.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditarRol.Location = new System.Drawing.Point(458, 183);
            this.btnEditarRol.Name = "btnEditarRol";
            this.btnEditarRol.Size = new System.Drawing.Size(100, 40);
            this.btnEditarRol.TabIndex = 4;
            this.btnEditarRol.Text = "Editar rol";
            this.btnEditarRol.UseVisualStyleBackColor = false;
            this.btnEditarRol.Click += new System.EventHandler(this.btnEditarRol_Click);
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRol.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminarRol.Location = new System.Drawing.Point(458, 260);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(100, 40);
            this.btnEliminarRol.TabIndex = 5;
            this.btnEliminarRol.Text = "Eliminar rol";
            this.btnEliminarRol.UseVisualStyleBackColor = false;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.button1);
            this.pnlPrincipal.Controls.Add(this.dgvRoles);
            this.pnlPrincipal.Controls.Add(this.btnEliminarRol);
            this.pnlPrincipal.Controls.Add(this.txtRol);
            this.pnlPrincipal.Controls.Add(this.lblRol);
            this.pnlPrincipal.Controls.Add(this.btnEditarRol);
            this.pnlPrincipal.Location = new System.Drawing.Point(3, 15);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(640, 340);
            this.pnlPrincipal.TabIndex = 6;
            // 
            // pnlSecundario
            // 
            this.pnlSecundario.Controls.Add(this.tabControl1);
            this.pnlSecundario.Location = new System.Drawing.Point(3, 15);
            this.pnlSecundario.Name = "pnlSecundario";
            this.pnlSecundario.Size = new System.Drawing.Size(640, 340);
            this.pnlSecundario.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpUsuarios);
            this.tabControl1.Controls.Add(this.tbpPermisos);
            this.tabControl1.Location = new System.Drawing.Point(10, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 301);
            this.tabControl1.TabIndex = 7;
            // 
            // tbpUsuarios
            // 
            this.tbpUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.tbpUsuarios.Controls.Add(this.btnAtras);
            this.tbpUsuarios.Controls.Add(this.dgvUsuarios);
            this.tbpUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tbpUsuarios.Name = "tbpUsuarios";
            this.tbpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUsuarios.Size = new System.Drawing.Size(609, 275);
            this.tbpUsuarios.TabIndex = 0;
            this.tbpUsuarios.Text = "Usuarios";
            this.tbpUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(485, 21);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(92, 23);
            this.btnAgregarUsuario.TabIndex = 7;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
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
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(9, 50);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(568, 204);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // tbpPermisos
            // 
            this.tbpPermisos.Location = new System.Drawing.Point(4, 22);
            this.tbpPermisos.Name = "tbpPermisos";
            this.tbpPermisos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPermisos.Size = new System.Drawing.Size(609, 275);
            this.tbpPermisos.TabIndex = 1;
            this.tbpPermisos.Text = "Permisos";
            this.tbpPermisos.UseVisualStyleBackColor = true;
            // 
            // pnlAgregarUsuario
            // 
            this.pnlAgregarUsuario.Controls.Add(this.btnCancelar);
            this.pnlAgregarUsuario.Controls.Add(this.btnInsertarUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.chbEstado);
            this.pnlAgregarUsuario.Controls.Add(this.lblNuevoUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.txtContraseña);
            this.pnlAgregarUsuario.Controls.Add(this.lblContraseña);
            this.pnlAgregarUsuario.Controls.Add(this.lblUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.txtUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.btnBuscarUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.lblBuscarUsuario);
            this.pnlAgregarUsuario.Controls.Add(this.textBox1);
            this.pnlAgregarUsuario.Location = new System.Drawing.Point(3, 15);
            this.pnlAgregarUsuario.Name = "pnlAgregarUsuario";
            this.pnlAgregarUsuario.Size = new System.Drawing.Size(640, 340);
            this.pnlAgregarUsuario.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(344, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInsertarUsuario
            // 
            this.btnInsertarUsuario.Location = new System.Drawing.Point(208, 270);
            this.btnInsertarUsuario.Name = "btnInsertarUsuario";
            this.btnInsertarUsuario.Size = new System.Drawing.Size(99, 23);
            this.btnInsertarUsuario.TabIndex = 10;
            this.btnInsertarUsuario.Text = "Agregar Usuario";
            this.btnInsertarUsuario.UseVisualStyleBackColor = true;
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Location = new System.Drawing.Point(284, 233);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(59, 17);
            this.chbEstado.TabIndex = 9;
            this.chbEstado.Text = "Estado";
            this.chbEstado.UseVisualStyleBackColor = true;
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Location = new System.Drawing.Point(36, 28);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(78, 13);
            this.lblNuevoUsuario.TabIndex = 7;
            this.lblNuevoUsuario.Text = "Nuevo Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(264, 197);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 6;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(264, 181);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(264, 122);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(264, 138);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(370, 74);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(30, 23);
            this.btnBuscarUsuario.TabIndex = 2;
            this.btnBuscarUsuario.Text = "...";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Location = new System.Drawing.Point(261, 57);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(82, 13);
            this.lblBuscarUsuario.TabIndex = 1;
            this.lblBuscarUsuario.Text = "Buscar Usuario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
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
            this.pnlBusquedaPersona.Location = new System.Drawing.Point(3, 15);
            this.pnlBusquedaPersona.Name = "pnlBusquedaPersona";
            this.pnlBusquedaPersona.Size = new System.Drawing.Size(640, 340);
            this.pnlBusquedaPersona.TabIndex = 7;
            // 
            // lblBusquedaApellidos
            // 
            this.lblBusquedaApellidos.AutoSize = true;
            this.lblBusquedaApellidos.Location = new System.Drawing.Point(228, 60);
            this.lblBusquedaApellidos.Name = "lblBusquedaApellidos";
            this.lblBusquedaApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblBusquedaApellidos.TabIndex = 8;
            this.lblBusquedaApellidos.Text = "Apellidos";
            // 
            // lblBusquedaUsuarioNombres
            // 
            this.lblBusquedaUsuarioNombres.AutoSize = true;
            this.lblBusquedaUsuarioNombres.Location = new System.Drawing.Point(39, 60);
            this.lblBusquedaUsuarioNombres.Name = "lblBusquedaUsuarioNombres";
            this.lblBusquedaUsuarioNombres.Size = new System.Drawing.Size(49, 13);
            this.lblBusquedaUsuarioNombres.TabIndex = 7;
            this.lblBusquedaUsuarioNombres.Text = "Nombres";
            // 
            // btnBuscarEnBusqueda
            // 
            this.btnBuscarEnBusqueda.Location = new System.Drawing.Point(547, 60);
            this.btnBuscarEnBusqueda.Name = "btnBuscarEnBusqueda";
            this.btnBuscarEnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEnBusqueda.TabIndex = 6;
            this.btnBuscarEnBusqueda.Text = "Buscar";
            this.btnBuscarEnBusqueda.UseVisualStyleBackColor = true;
            this.btnBuscarEnBusqueda.Click += new System.EventHandler(this.btnBuscarEnBusqueda_Click);
            // 
            // txtBusquedaApellidos
            // 
            this.txtBusquedaApellidos.Location = new System.Drawing.Point(293, 60);
            this.txtBusquedaApellidos.Name = "txtBusquedaApellidos";
            this.txtBusquedaApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaApellidos.TabIndex = 5;
            // 
            // txtBusquedaNombres
            // 
            this.txtBusquedaNombres.Location = new System.Drawing.Point(94, 60);
            this.txtBusquedaNombres.Name = "txtBusquedaNombres";
            this.txtBusquedaNombres.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaNombres.TabIndex = 4;
            // 
            // btnCancelarBusqueda
            // 
            this.btnCancelarBusqueda.Location = new System.Drawing.Point(396, 277);
            this.btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            this.btnCancelarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBusqueda.TabIndex = 3;
            this.btnCancelarBusqueda.Text = "Cancelar";
            this.btnCancelarBusqueda.UseVisualStyleBackColor = true;
            this.btnCancelarBusqueda.Click += new System.EventHandler(this.btnCancelarBusqueda_Click);
            // 
            // btnAceptarBusqueda
            // 
            this.btnAceptarBusqueda.Location = new System.Drawing.Point(202, 277);
            this.btnAceptarBusqueda.Name = "btnAceptarBusqueda";
            this.btnAceptarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarBusqueda.TabIndex = 2;
            this.btnAceptarBusqueda.Text = "Aceptar";
            this.btnAceptarBusqueda.UseVisualStyleBackColor = true;
            // 
            // lblBusquedaPersona
            // 
            this.lblBusquedaPersona.AutoSize = true;
            this.lblBusquedaPersona.Location = new System.Drawing.Point(290, 18);
            this.lblBusquedaPersona.Name = "lblBusquedaPersona";
            this.lblBusquedaPersona.Size = new System.Drawing.Size(97, 13);
            this.lblBusquedaPersona.TabIndex = 1;
            this.lblBusquedaPersona.Text = "Busqueda Persona";
            // 
            // dgvBusquedaUsuarios
            // 
            this.dgvBusquedaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaUsuarios.Location = new System.Drawing.Point(42, 99);
            this.dgvBusquedaUsuarios.Name = "dgvBusquedaUsuarios";
            this.dgvBusquedaUsuarios.Size = new System.Drawing.Size(580, 141);
            this.dgvBusquedaUsuarios.TabIndex = 0;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSecundario);
            this.Controls.Add(this.pnlAgregarUsuario);
            this.Controls.Add(this.pnlBusquedaPersona);
            this.Name = "Roles";
            this.Size = new System.Drawing.Size(2181, 926);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlSecundario.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlAgregarUsuario.ResumeLayout(false);
            this.pnlAgregarUsuario.PerformLayout();
            this.pnlBusquedaPersona.ResumeLayout(false);
            this.pnlBusquedaPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditarRol;
        private System.Windows.Forms.Button btnEliminarRol;
        public System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlSecundario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TabPage tbpPermisos;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Panel pnlAgregarUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertarUsuario;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}
