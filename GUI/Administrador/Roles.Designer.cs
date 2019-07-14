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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(32, 87);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(73, 13);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Nombre de rol";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(131, 84);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(100, 20);
            this.txtRol.TabIndex = 1;
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Location = new System.Drawing.Point(35, 117);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(356, 263);
            this.dgvRoles.TabIndex = 2;
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(489, 133);
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
            this.btnEditarRol.Location = new System.Drawing.Point(489, 206);
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
            this.btnEliminarRol.Location = new System.Drawing.Point(489, 283);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(100, 40);
            this.btnEliminarRol.TabIndex = 5;
            this.btnEliminarRol.Text = "Eliminar rol";
            this.btnEliminarRol.UseVisualStyleBackColor = false;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminarRol);
            this.Controls.Add(this.btnEditarRol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.lblRol);
            this.Name = "Roles";
            this.Size = new System.Drawing.Size(662, 410);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditarRol;
        private System.Windows.Forms.Button btnEliminarRol;
        public System.Windows.Forms.TextBox txtRol;
    }
}
