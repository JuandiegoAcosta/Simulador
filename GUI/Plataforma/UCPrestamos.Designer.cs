namespace Sistema_Bancario.Plataforma
{
    partial class UCPrestamos
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
            this.proceder1 = new Sistema_Bancario.Controles.Proceder();
            this.SuspendLayout();
            // 
            // proceder1
            // 
            this.proceder1.Location = new System.Drawing.Point(337, 273);
            this.proceder1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.proceder1.Name = "proceder1";
            this.proceder1.Size = new System.Drawing.Size(111, 40);
            this.proceder1.TabIndex = 0;
            // 
            // UCPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.proceder1);
            this.Name = "UCPrestamos";
            this.Size = new System.Drawing.Size(470, 333);
            this.Load += new System.EventHandler(this.UCPrestamos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.Proceder proceder1;
    }
}
