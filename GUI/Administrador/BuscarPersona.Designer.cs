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
            this.pnlBusquedaPersona.Location = new System.Drawing.Point(21, 28);
            this.pnlBusquedaPersona.Name = "pnlBusquedaPersona";
            this.pnlBusquedaPersona.Size = new System.Drawing.Size(640, 340);
            this.pnlBusquedaPersona.TabIndex = 8;
            // 
            // lblBusquedaApellidos
            // 
            this.lblBusquedaApellidos.AutoSize = true;
            this.lblBusquedaApellidos.Location = new System.Drawing.Point(327, 66);
            this.lblBusquedaApellidos.Name = "lblBusquedaApellidos";
            this.lblBusquedaApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblBusquedaApellidos.TabIndex = 8;
            this.lblBusquedaApellidos.Text = "Apellidos";
            // 
            // lblBusquedaUsuarioNombres
            // 
            this.lblBusquedaUsuarioNombres.AutoSize = true;
            this.lblBusquedaUsuarioNombres.Location = new System.Drawing.Point(82, 67);
            this.lblBusquedaUsuarioNombres.Name = "lblBusquedaUsuarioNombres";
            this.lblBusquedaUsuarioNombres.Size = new System.Drawing.Size(49, 13);
            this.lblBusquedaUsuarioNombres.TabIndex = 7;
            this.lblBusquedaUsuarioNombres.Text = "Nombres";
            // 
            // btnBuscarEnBusqueda
            // 
            this.btnBuscarEnBusqueda.Location = new System.Drawing.Point(526, 66);
            this.btnBuscarEnBusqueda.Name = "btnBuscarEnBusqueda";
            this.btnBuscarEnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEnBusqueda.TabIndex = 6;
            this.btnBuscarEnBusqueda.Text = "Buscar";
            this.btnBuscarEnBusqueda.UseVisualStyleBackColor = true;
            this.btnBuscarEnBusqueda.Click += new System.EventHandler(this.btnBuscarEnBusqueda_Click);
            // 
            // txtBusquedaApellidos
            // 
            this.txtBusquedaApellidos.Location = new System.Drawing.Point(407, 67);
            this.txtBusquedaApellidos.Name = "txtBusquedaApellidos";
            this.txtBusquedaApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaApellidos.TabIndex = 5;
            // 
            // txtBusquedaNombres
            // 
            this.txtBusquedaNombres.Location = new System.Drawing.Point(155, 66);
            this.txtBusquedaNombres.Name = "txtBusquedaNombres";
            this.txtBusquedaNombres.Size = new System.Drawing.Size(100, 20);
            this.txtBusquedaNombres.TabIndex = 4;
            // 
            // btnCancelarBusqueda
            // 
            this.btnCancelarBusqueda.Location = new System.Drawing.Point(344, 269);
            this.btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            this.btnCancelarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBusqueda.TabIndex = 3;
            this.btnCancelarBusqueda.Text = "Cancelar";
            this.btnCancelarBusqueda.UseVisualStyleBackColor = true;
            this.btnCancelarBusqueda.Click += new System.EventHandler(this.btnCancelarBusqueda_Click);
            // 
            // btnAceptarBusqueda
            // 
            this.btnAceptarBusqueda.Location = new System.Drawing.Point(180, 269);
            this.btnAceptarBusqueda.Name = "btnAceptarBusqueda";
            this.btnAceptarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarBusqueda.TabIndex = 2;
            this.btnAceptarBusqueda.Text = "Aceptar";
            this.btnAceptarBusqueda.UseVisualStyleBackColor = true;
            this.btnAceptarBusqueda.Click += new System.EventHandler(this.btnAceptarBusqueda_Click);
            // 
            // lblBusquedaPersona
            // 
            this.lblBusquedaPersona.AutoSize = true;
            this.lblBusquedaPersona.Location = new System.Drawing.Point(274, 20);
            this.lblBusquedaPersona.Name = "lblBusquedaPersona";
            this.lblBusquedaPersona.Size = new System.Drawing.Size(97, 13);
            this.lblBusquedaPersona.TabIndex = 1;
            this.lblBusquedaPersona.Text = "Busqueda Persona";
            // 
            // dgvBusquedaUsuarios
            // 
            this.dgvBusquedaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaUsuarios.Location = new System.Drawing.Point(63, 94);
            this.dgvBusquedaUsuarios.Name = "dgvBusquedaUsuarios";
            this.dgvBusquedaUsuarios.Size = new System.Drawing.Size(444, 141);
            this.dgvBusquedaUsuarios.TabIndex = 0;
            this.dgvBusquedaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusquedaUsuarios_CellClick);
            // 
            // BuscarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 380);
            this.Controls.Add(this.pnlBusquedaPersona);
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
    }
}