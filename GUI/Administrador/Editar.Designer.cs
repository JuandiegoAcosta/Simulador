namespace Sistema_Bancario.Administrador
{
    partial class Editar
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
            this.txtUsuarioEditar = new System.Windows.Forms.TextBox();
            this.lblUsuarioEditar = new System.Windows.Forms.Label();
            this.cmbRolesEditar = new System.Windows.Forms.ComboBox();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.idRolUsuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuarioEditar
            // 
            this.txtUsuarioEditar.Location = new System.Drawing.Point(77, 32);
            this.txtUsuarioEditar.Name = "txtUsuarioEditar";
            this.txtUsuarioEditar.Size = new System.Drawing.Size(156, 20);
            this.txtUsuarioEditar.TabIndex = 0;
            // 
            // lblUsuarioEditar
            // 
            this.lblUsuarioEditar.AutoSize = true;
            this.lblUsuarioEditar.Location = new System.Drawing.Point(18, 35);
            this.lblUsuarioEditar.Name = "lblUsuarioEditar";
            this.lblUsuarioEditar.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioEditar.TabIndex = 1;
            this.lblUsuarioEditar.Text = "Usuario";
            // 
            // cmbRolesEditar
            // 
            this.cmbRolesEditar.FormattingEnabled = true;
            this.cmbRolesEditar.Location = new System.Drawing.Point(67, 58);
            this.cmbRolesEditar.Name = "cmbRolesEditar";
            this.cmbRolesEditar.Size = new System.Drawing.Size(121, 21);
            this.cmbRolesEditar.TabIndex = 2;
            this.cmbRolesEditar.SelectedIndexChanged += new System.EventHandler(this.cmbRolesEditar_SelectedIndexChanged);
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Location = new System.Drawing.Point(98, 99);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(56, 17);
            this.chbActivo.TabIndex = 3;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idRolUsuario);
            this.panel1.Controls.Add(this.txtIdUsuario);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.txtUsuarioEditar);
            this.panel1.Controls.Add(this.chbActivo);
            this.panel1.Controls.Add(this.lblUsuarioEditar);
            this.panel1.Controls.Add(this.cmbRolesEditar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 162);
            this.panel1.TabIndex = 4;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(107, 6);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIdUsuario.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(89, 122);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // idRolUsuario
            // 
            this.idRolUsuario.Location = new System.Drawing.Point(203, 96);
            this.idRolUsuario.Name = "idRolUsuario";
            this.idRolUsuario.Size = new System.Drawing.Size(48, 20);
            this.idRolUsuario.TabIndex = 7;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 186);
            this.Controls.Add(this.panel1);
            this.Name = "Editar";
            this.Text = "Editar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUsuarioEditar;
        private System.Windows.Forms.ComboBox cmbRolesEditar;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.TextBox txtUsuarioEditar;
        public System.Windows.Forms.TextBox txtIdUsuario;
        public System.Windows.Forms.TextBox idRolUsuario;
    }
}