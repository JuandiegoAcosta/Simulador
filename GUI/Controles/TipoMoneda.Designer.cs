namespace Sistema_Bancario.Controles
{
    partial class TipoMoneda
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
            this.CboMoneda = new System.Windows.Forms.ComboBox();
            this.LbMoneda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CboMoneda
            // 
            this.CboMoneda.FormattingEnabled = true;
            this.CboMoneda.Items.AddRange(new object[] {
            "Soles"});
            this.CboMoneda.Location = new System.Drawing.Point(51, 2);
            this.CboMoneda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboMoneda.Name = "CboMoneda";
            this.CboMoneda.Size = new System.Drawing.Size(91, 21);
            this.CboMoneda.TabIndex = 4;
            // 
            // LbMoneda
            // 
            this.LbMoneda.AutoSize = true;
            this.LbMoneda.Location = new System.Drawing.Point(2, 5);
            this.LbMoneda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbMoneda.Name = "LbMoneda";
            this.LbMoneda.Size = new System.Drawing.Size(46, 13);
            this.LbMoneda.TabIndex = 5;
            this.LbMoneda.Text = "Moneda";
            // 
            // TipoMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbMoneda);
            this.Controls.Add(this.CboMoneda);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TipoMoneda";
            this.Size = new System.Drawing.Size(148, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox CboMoneda;
        private System.Windows.Forms.Label LbMoneda;
    }
}
