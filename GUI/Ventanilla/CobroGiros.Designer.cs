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
         this.proceder1.Location = new System.Drawing.Point(6, 572);
         this.proceder1.Size = new System.Drawing.Size(862, 40);
         // 
         // dni1
         // 
         this.dni1.Location = new System.Drawing.Point(22, 11);
         this.dni1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.dni1.Name = "dni1";
         this.dni1.Size = new System.Drawing.Size(174, 27);
         this.dni1.TabIndex = 2;
         // 
         // clave1
         // 
         this.clave1.Location = new System.Drawing.Point(22, 41);
         this.clave1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.clave1.Name = "clave1";
         this.clave1.Size = new System.Drawing.Size(174, 26);
         this.clave1.TabIndex = 3;
         // 
         // GVCobroGiros
         // 
         this.GVCobroGiros.BackgroundColor = System.Drawing.SystemColors.Control;
         this.GVCobroGiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.GVCobroGiros.Location = new System.Drawing.Point(8, 79);
         this.GVCobroGiros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.GVCobroGiros.Name = "GVCobroGiros";
         this.GVCobroGiros.RowTemplate.Height = 24;
         this.GVCobroGiros.Size = new System.Drawing.Size(554, 275);
         this.GVCobroGiros.TabIndex = 4;
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.Color.ForestGreen;
         this.button1.FlatAppearance.BorderSize = 0;
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.ForeColor = System.Drawing.SystemColors.Window;
         this.button1.Location = new System.Drawing.Point(200, 41);
         this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(58, 26);
         this.button1.TabIndex = 5;
         this.button1.Text = "Buscar";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // CobroGiros
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.GVCobroGiros);
         this.Controls.Add(this.clave1);
         this.Controls.Add(this.dni1);
         this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
         this.Name = "CobroGiros";
         this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
         this.Size = new System.Drawing.Size(874, 618);
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
