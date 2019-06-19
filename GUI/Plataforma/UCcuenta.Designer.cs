namespace Sistema_Bancario.Plataforma
{
    partial class UCcuenta
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
            this.tipoCuenta1 = new Sistema_Bancario.Controles.TipoCuenta();
            this.proceder1 = new Sistema_Bancario.Controles.Proceder();
            this.SuspendLayout();
            // 
            // tipoCuenta1
            // 
            this.tipoCuenta1.Location = new System.Drawing.Point(335, 21);
            this.tipoCuenta1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipoCuenta1.Name = "tipoCuenta1";
            this.tipoCuenta1.Size = new System.Drawing.Size(138, 52);
            this.tipoCuenta1.TabIndex = 2;
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(362, 342);
            this.proceder1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.proceder1.Name = "proceder1";
            this.proceder1.Size = new System.Drawing.Size(111, 40);
            this.proceder1.TabIndex = 0;
            // 
            // UCcuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tipoCuenta1);
            this.Controls.Add(this.proceder1);
            this.Name = "UCcuenta";
            this.Size = new System.Drawing.Size(491, 399);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.Proceder proceder1;
        private Controles.TipoCuenta tipoCuenta1;
    }
}
