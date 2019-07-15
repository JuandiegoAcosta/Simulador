namespace Sistema_Bancario.Administrador
{
    partial class AgregarNuevoUsuario
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
            this.txtUsuarioBuscado = new System.Windows.Forms.TextBox();
            this.pnlAgregarUsuario.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlAgregarUsuario.Controls.Add(this.txtUsuarioBuscado);
            this.pnlAgregarUsuario.Location = new System.Drawing.Point(26, 15);
            this.pnlAgregarUsuario.Name = "pnlAgregarUsuario";
            this.pnlAgregarUsuario.Size = new System.Drawing.Size(640, 340);
            this.pnlAgregarUsuario.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(344, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnInsertarUsuario
            // 
            this.btnInsertarUsuario.Location = new System.Drawing.Point(208, 270);
            this.btnInsertarUsuario.Name = "btnInsertarUsuario";
            this.btnInsertarUsuario.Size = new System.Drawing.Size(99, 23);
            this.btnInsertarUsuario.TabIndex = 10;
            this.btnInsertarUsuario.Text = "Agregar Usuario";
            this.btnInsertarUsuario.UseVisualStyleBackColor = true;
            this.btnInsertarUsuario.Click += new System.EventHandler(this.btnInsertarUsuario_Click);
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
            // txtUsuarioBuscado
            // 
            this.txtUsuarioBuscado.Location = new System.Drawing.Point(264, 76);
            this.txtUsuarioBuscado.Name = "txtUsuarioBuscado";
            this.txtUsuarioBuscado.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioBuscado.TabIndex = 0;
            // 
            // AgregarNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 370);
            this.Controls.Add(this.pnlAgregarUsuario);
            this.Name = "AgregarNuevoUsuario";
            this.Text = "frmAgregarNuevoUsuario";
            this.pnlAgregarUsuario.ResumeLayout(false);
            this.pnlAgregarUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInsertarUsuario;
        private System.Windows.Forms.CheckBox chbEstado;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Label lblBuscarUsuario;
        public System.Windows.Forms.Panel pnlAgregarUsuario;
        public System.Windows.Forms.TextBox txtUsuarioBuscado;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.TextBox txtUsuario;
    }
}