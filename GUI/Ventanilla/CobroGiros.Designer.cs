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
            this.dni1 = new Sistema_Bancario.Dni();
            this.clave1 = new Sistema_Bancario.Controles.Clave();
            this.GVCobroGiros = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVCobroGiros)).BeginInit();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(8, 558);
            this.proceder1.Size = new System.Drawing.Size(744, 49);
            // 
            // dni1
            // 
            this.dni1.Location = new System.Drawing.Point(29, 14);
            this.dni1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dni1.Name = "dni1";
            this.dni1.Size = new System.Drawing.Size(232, 33);
            this.dni1.TabIndex = 2;
            // 
            // clave1
            // 
            this.clave1.Location = new System.Drawing.Point(29, 51);
            this.clave1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clave1.Name = "clave1";
            this.clave1.Size = new System.Drawing.Size(232, 32);
            this.clave1.TabIndex = 3;
            // 
            // GVCobroGiros
            // 
            this.GVCobroGiros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GVCobroGiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCobroGiros.Location = new System.Drawing.Point(11, 97);
            this.GVCobroGiros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GVCobroGiros.Name = "GVCobroGiros";
            this.GVCobroGiros.RowTemplate.Height = 24;
            this.GVCobroGiros.Size = new System.Drawing.Size(738, 339);
            this.GVCobroGiros.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(267, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CobroGiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GVCobroGiros);
            this.Controls.Add(this.clave1);
            this.Controls.Add(this.dni1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CobroGiros";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(760, 614);
            this.Controls.SetChildIndex(this.proceder1, 0);
            this.Controls.SetChildIndex(this.dni1, 0);
            this.Controls.SetChildIndex(this.clave1, 0);
            this.Controls.SetChildIndex(this.GVCobroGiros, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GVCobroGiros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Dni dni1;
        private Controles.Clave clave1;
        private System.Windows.Forms.DataGridView GVCobroGiros;
        private System.Windows.Forms.Button button1;
    }
}
