﻿namespace XWFControlLibrary.UI.help
{
   partial class FormReport
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
         this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
         this.SuspendLayout();
         // 
         // reportViewer1
         // 
         this.reportViewer1.Location = new System.Drawing.Point(0, 0);
         this.reportViewer1.Name = "ReportViewer";
         //this.reportViewer1.ServerReport.BearerToken = null;
         this.reportViewer1.Size = new System.Drawing.Size(396, 246);
         this.reportViewer1.TabIndex = 0;
         // 
         // FormReport
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(618, 445);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormReport";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "FormReport";
         this.ResumeLayout(false);

      }

      #endregion

      private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
   }
}