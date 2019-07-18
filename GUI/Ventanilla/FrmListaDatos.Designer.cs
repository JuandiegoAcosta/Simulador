namespace Sistema_Bancario.Ventanilla
{
    partial class FrmListaDatos
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
            this.DGVlistaDatos = new System.Windows.Forms.DataGridView();
            this.BTAceptar = new System.Windows.Forms.Button();
            this.BTCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVlistaDatos
            // 
            this.DGVlistaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVlistaDatos.Location = new System.Drawing.Point(12, 12);
            this.DGVlistaDatos.Name = "DGVlistaDatos";
            this.DGVlistaDatos.Size = new System.Drawing.Size(591, 381);
            this.DGVlistaDatos.TabIndex = 0;
            // 
            // BTAceptar
            // 
            this.BTAceptar.Location = new System.Drawing.Point(148, 412);
            this.BTAceptar.Name = "BTAceptar";
            this.BTAceptar.Size = new System.Drawing.Size(75, 23);
            this.BTAceptar.TabIndex = 1;
            this.BTAceptar.Text = "Aceptar";
            this.BTAceptar.UseVisualStyleBackColor = true;
            // 
            // BTCancelar
            // 
            this.BTCancelar.Location = new System.Drawing.Point(334, 412);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTCancelar.TabIndex = 2;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmListaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.BTAceptar);
            this.Controls.Add(this.DGVlistaDatos);
            this.Name = "FrmListaDatos";
            this.Text = "FrmListaDatos";
            ((System.ComponentModel.ISupportInitialize)(this.DGVlistaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVlistaDatos;
        private System.Windows.Forms.Button BTAceptar;
        private System.Windows.Forms.Button BTCancelar;
    }
}