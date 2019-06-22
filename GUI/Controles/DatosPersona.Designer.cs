namespace Sistema_Bancario.Controles
{
    partial class DatosPersona
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnClear);
            this.gbDatos.Controls.Add(this.btnSearch);
            this.gbDatos.Controls.Add(this.txtNumDoc);
            this.gbDatos.Controls.Add(this.lblNumDoc);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.textBox1);
            this.gbDatos.Controls.Add(this.txtApMaterno);
            this.gbDatos.Controls.Add(this.txtApPaterno);
            this.gbDatos.Controls.Add(this.lblApMaterno);
            this.gbDatos.Controls.Add(this.lblApPaterno);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Location = new System.Drawing.Point(4, 4);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatos.Size = new System.Drawing.Size(506, 243);
            this.gbDatos.TabIndex = 9;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Image = global::Sistema_Bancario.Properties.Resources.limpiar;
            this.btnClear.Location = new System.Drawing.Point(407, 32);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 43);
            this.btnClear.TabIndex = 26;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Image = global::Sistema_Bancario.Properties.Resources.buscar;
            this.btnSearch.Location = new System.Drawing.Point(351, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 43);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(137, 42);
            this.txtNumDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumDoc.MaxLength = 11;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(204, 22);
            this.txtNumDoc.TabIndex = 22;
            this.txtNumDoc.TextChanged += new System.EventHandler(this.txtNumDoc_TextChanged);
            this.txtNumDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDoc_KeyPress);
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Location = new System.Drawing.Point(20, 46);
            this.lblNumDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(107, 17);
            this.lblNumDoc.TabIndex = 21;
            this.lblNumDoc.Text = "Nro Documento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 196);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(319, 22);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1267, 517);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 22);
            this.textBox1.TabIndex = 17;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(137, 159);
            this.txtApMaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(319, 22);
            this.txtApMaterno.TabIndex = 16;
            this.txtApMaterno.Visible = false;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(137, 122);
            this.txtApPaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(319, 22);
            this.txtApPaterno.TabIndex = 15;
            this.txtApPaterno.Visible = false;
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Location = new System.Drawing.Point(20, 161);
            this.lblApMaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(114, 17);
            this.lblApMaterno.TabIndex = 14;
            this.lblApMaterno.Text = "Apellido Materno";
            this.lblApMaterno.Visible = false;
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Location = new System.Drawing.Point(20, 126);
            this.lblApPaterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(112, 17);
            this.lblApPaterno.TabIndex = 13;
            this.lblApPaterno.Text = "Apellido Paterno";
            this.lblApPaterno.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 196);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 17);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombres";
            this.lblNombre.Visible = false;
            // 
            // DatosPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DatosPersona";
            this.Size = new System.Drawing.Size(531, 266);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
    }
}
