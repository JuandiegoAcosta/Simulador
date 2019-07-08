namespace Sistema_Bancario
{
    partial class Monto
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
            this.TBMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBMonto
            // 
            this.TBMonto.Location = new System.Drawing.Point(92, 3);
            this.TBMonto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBMonto.Name = "TBMonto";
            this.TBMonto.Size = new System.Drawing.Size(201, 20);
            this.TBMonto.TabIndex = 0;
            this.TBMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBMonto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Monto :";
            // 
            // Monto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBMonto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Monto";
            this.Size = new System.Drawing.Size(295, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox TBMonto;
        private System.Windows.Forms.Label label4;
    }
}
