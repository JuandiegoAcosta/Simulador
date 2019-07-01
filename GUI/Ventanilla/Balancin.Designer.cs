namespace Sistema_Bancario.Ventanilla
{
    partial class Balancin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudNroBilletes = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CmbDenominaciones = new System.Windows.Forms.ComboBox();
            this.cmbMonedas = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDenominaciones = new System.Windows.Forms.DataGridView();
            this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_billetes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnRegistrarMov = new System.Windows.Forms.Button();
            this.btnImprimirMov = new System.Windows.Forms.Button();
            this.cmbPersonaRol = new System.Windows.Forms.ComboBox();
            this.cmbTiposRoles = new System.Windows.Forms.ComboBox();
            this.cmbTipoMov = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroBilletes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenominaciones)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudNroBilletes);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CmbDenominaciones);
            this.groupBox1.Controls.Add(this.cmbMonedas);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgvDenominaciones);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balancín caja";
            // 
            // nudNroBilletes
            // 
            this.nudNroBilletes.Location = new System.Drawing.Point(370, 94);
            this.nudNroBilletes.Name = "nudNroBilletes";
            this.nudNroBilletes.Size = new System.Drawing.Size(227, 22);
            this.nudNroBilletes.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(489, 123);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 40);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(376, 123);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(107, 40);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Imprimir ticket";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Estado caja";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CmbDenominaciones
            // 
            this.CmbDenominaciones.FormattingEnabled = true;
            this.CmbDenominaciones.Location = new System.Drawing.Point(370, 59);
            this.CmbDenominaciones.Name = "CmbDenominaciones";
            this.CmbDenominaciones.Size = new System.Drawing.Size(227, 24);
            this.CmbDenominaciones.TabIndex = 1;
            // 
            // cmbMonedas
            // 
            this.cmbMonedas.FormattingEnabled = true;
            this.cmbMonedas.Location = new System.Drawing.Point(370, 21);
            this.cmbMonedas.Name = "cmbMonedas";
            this.cmbMonedas.Size = new System.Drawing.Size(227, 24);
            this.cmbMonedas.TabIndex = 1;
            this.cmbMonedas.SelectedValueChanged += new System.EventHandler(this.cmbMonedas_SelectedValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(459, 388);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(138, 22);
            this.txtTotal.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nro billetes";
            // 
            // dgvDenominaciones
            // 
            this.dgvDenominaciones.AllowUserToAddRows = false;
            this.dgvDenominaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDenominaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Denominacion,
            this.Nro_billetes,
            this.Importe});
            this.dgvDenominaciones.Location = new System.Drawing.Point(74, 169);
            this.dgvDenominaciones.Name = "dgvDenominaciones";
            this.dgvDenominaciones.RowTemplate.Height = 24;
            this.dgvDenominaciones.Size = new System.Drawing.Size(523, 213);
            this.dgvDenominaciones.TabIndex = 2;
            this.dgvDenominaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDenominaciones_CellClick);
            // 
            // Denominacion
            // 
            this.Denominacion.HeaderText = "Denominación";
            this.Denominacion.Name = "Denominacion";
            // 
            // Nro_billetes
            // 
            this.Nro_billetes.HeaderText = "Nro billetes";
            this.Nro_billetes.Name = "Nro_billetes";
            this.Nro_billetes.Width = 150;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Denominación";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(373, 391);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 17);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Moneda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.btnRegistrarMov);
            this.groupBox2.Controls.Add(this.btnImprimirMov);
            this.groupBox2.Controls.Add(this.cmbPersonaRol);
            this.groupBox2.Controls.Add(this.cmbTiposRoles);
            this.groupBox2.Controls.Add(this.cmbTipoMov);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar movimientos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(367, 156);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(227, 22);
            this.txtCantidad.TabIndex = 5;
            // 
            // btnRegistrarMov
            // 
            this.btnRegistrarMov.Location = new System.Drawing.Point(647, 21);
            this.btnRegistrarMov.Name = "btnRegistrarMov";
            this.btnRegistrarMov.Size = new System.Drawing.Size(158, 38);
            this.btnRegistrarMov.TabIndex = 4;
            this.btnRegistrarMov.Text = "Registrar movimiento";
            this.btnRegistrarMov.UseVisualStyleBackColor = true;
            this.btnRegistrarMov.Click += new System.EventHandler(this.btnRegistrarMov_Click);
            // 
            // btnImprimirMov
            // 
            this.btnImprimirMov.Location = new System.Drawing.Point(650, 75);
            this.btnImprimirMov.Name = "btnImprimirMov";
            this.btnImprimirMov.Size = new System.Drawing.Size(155, 38);
            this.btnImprimirMov.TabIndex = 4;
            this.btnImprimirMov.Text = "Imprimir ticket";
            this.btnImprimirMov.UseVisualStyleBackColor = true;
            // 
            // cmbPersonaRol
            // 
            this.cmbPersonaRol.FormattingEnabled = true;
            this.cmbPersonaRol.Location = new System.Drawing.Point(367, 110);
            this.cmbPersonaRol.Name = "cmbPersonaRol";
            this.cmbPersonaRol.Size = new System.Drawing.Size(227, 24);
            this.cmbPersonaRol.TabIndex = 1;
            // 
            // cmbTiposRoles
            // 
            this.cmbTiposRoles.FormattingEnabled = true;
            this.cmbTiposRoles.Location = new System.Drawing.Point(367, 66);
            this.cmbTiposRoles.Name = "cmbTiposRoles";
            this.cmbTiposRoles.Size = new System.Drawing.Size(227, 24);
            this.cmbTiposRoles.TabIndex = 1;
            this.cmbTiposRoles.SelectedValueChanged += new System.EventHandler(this.cmbTiposRoles_SelectedValueChanged);
            // 
            // cmbTipoMov
            // 
            this.cmbTipoMov.FormattingEnabled = true;
            this.cmbTipoMov.Location = new System.Drawing.Point(367, 21);
            this.cmbTipoMov.Name = "cmbTipoMov";
            this.cmbTipoMov.Size = new System.Drawing.Size(227, 24);
            this.cmbTipoMov.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sujeto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo sujeto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Importe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de movimiento";
            // 
            // Balancin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Balancin";
            this.Size = new System.Drawing.Size(874, 618);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroBilletes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenominaciones)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDenominaciones;
        private System.Windows.Forms.NumericUpDown nudNroBilletes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CmbDenominaciones;
        private System.Windows.Forms.ComboBox cmbMonedas;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_billetes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnRegistrarMov;
        private System.Windows.Forms.Button btnImprimirMov;
        private System.Windows.Forms.ComboBox cmbPersonaRol;
        private System.Windows.Forms.ComboBox cmbTiposRoles;
        private System.Windows.Forms.ComboBox cmbTipoMov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
