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
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgvRolesUsuario = new System.Windows.Forms.DataGridView();
            this.tbpPermisos = new System.Windows.Forms.TabPage();
            this.dgvPermisosRol = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.chbRolActivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlSecundario.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesUsuario)).BeginInit();
            this.tbpPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosRol)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(15, 19);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(657, 329);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.dgvUsuarios);
            this.pnlPrincipal.Location = new System.Drawing.Point(24, 12);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(690, 374);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // pnlSecundario
            // 
            this.pnlSecundario.Controls.Add(this.tabControl1);
            this.pnlSecundario.Location = new System.Drawing.Point(24, 12);
            this.pnlSecundario.Name = "pnlSecundario";
            this.pnlSecundario.Size = new System.Drawing.Size(690, 374);
            this.pnlSecundario.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpRoles);
            this.tabControl1.Controls.Add(this.tbpPermisos);
            this.tabControl1.Location = new System.Drawing.Point(19, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 355);
            this.tabControl1.TabIndex = 7;
            // 
            // tbpRoles
            // 
            this.tbpRoles.Controls.Add(this.panel1);
            this.tbpRoles.Controls.Add(this.btnAtras);
            this.tbpRoles.Controls.Add(this.dgvRolesUsuario);
            this.tbpRoles.Location = new System.Drawing.Point(4, 22);
            this.tbpRoles.Name = "tbpRoles";
            this.tbpRoles.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRoles.Size = new System.Drawing.Size(609, 329);
            this.tbpRoles.TabIndex = 0;
            this.tbpRoles.Text = "Roles";
            this.tbpRoles.UseVisualStyleBackColor = true;
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
            this.dgvRolesUsuario.Location = new System.Drawing.Point(9, 38);
            this.dgvRolesUsuario.Name = "dgvRolesUsuario";
            this.dgvRolesUsuario.Size = new System.Drawing.Size(258, 280);
            this.dgvRolesUsuario.TabIndex = 0;
            // 
            // tbpPermisos
            // 
            this.tbpPermisos.Controls.Add(this.dgvPermisosRol);
            this.tbpPermisos.Location = new System.Drawing.Point(4, 22);
            this.tbpPermisos.Name = "tbpPermisos";
            this.tbpPermisos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPermisos.Size = new System.Drawing.Size(609, 329);
            this.tbpPermisos.TabIndex = 1;
            this.tbpPermisos.Text = "Permisos";
            this.tbpPermisos.UseVisualStyleBackColor = true;
            // 
            // dgvPermisosRol
            // 
            this.dgvPermisosRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisosRol.Location = new System.Drawing.Point(6, 6);
            this.dgvPermisosRol.Name = "dgvPermisosRol";
            this.dgvPermisosRol.Size = new System.Drawing.Size(595, 327);
            this.dgvPermisosRol.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbRolActivo);
            this.panel1.Controls.Add(this.cmbRoles);
            this.panel1.Controls.Add(this.btnAgregarRol);
            this.panel1.Location = new System.Drawing.Point(324, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 280);
            this.panel1.TabIndex = 8;
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
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSecundario);
            this.Name = "Usuario";
            this.Size = new System.Drawing.Size(1622, 543);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlSecundario.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesUsuario)).EndInit();
            this.tbpPermisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosRol)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPermisosRol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbRolActivo;
        private System.Windows.Forms.ComboBox cmbRoles;
    }
}
