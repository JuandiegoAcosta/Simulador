namespace Sistema_Bancario.Froms_opciones
{
    partial class CobroGiros
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
            this.clave1 = new Sistema_Bancario.Controles.Clave();
            this.GVCobroGiros = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dni2 = new Sistema_Bancario.Controles.DNI();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVCobroGiros)).BeginInit();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(8, 705);
            this.proceder1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.proceder1.Size = new System.Drawing.Size(1149, 49);
            // 
            // clave1
            // 
            this.clave1.Location = new System.Drawing.Point(11, 73);
            this.clave1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clave1.Name = "clave1";
            this.clave1.Size = new System.Drawing.Size(295, 32);
            this.clave1.TabIndex = 3;
            // 
            // GVCobroGiros
            // 
            this.GVCobroGiros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GVCobroGiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCobroGiros.Location = new System.Drawing.Point(11, 122);
            this.GVCobroGiros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GVCobroGiros.Name = "GVCobroGiros";
            this.GVCobroGiros.RowTemplate.Height = 24;
            this.GVCobroGiros.Size = new System.Drawing.Size(1121, 338);
            this.GVCobroGiros.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(312, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dni2
            // 
            this.dni2.Location = new System.Drawing.Point(98, 12);
            this.dni2.Name = "dni2";
            this.dni2.Size = new System.Drawing.Size(251, 58);
            this.dni2.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(11, 17);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(66, 17);
            this.Nombre.TabIndex = 7;
            this.Nombre.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "DNI :";
            // 
            // CobroGiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.dni2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GVCobroGiros);
            this.Controls.Add(this.clave1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CobroGiros";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.clave1, 0);
            this.Controls.SetChildIndex(this.GVCobroGiros, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dni2, 0);
            this.Controls.SetChildIndex(this.Nombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GVCobroGiros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controles.Clave clave1;
        private System.Windows.Forms.DataGridView GVCobroGiros;
        private System.Windows.Forms.Button button1;
        private Controles.DNI dni2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
    }
}
