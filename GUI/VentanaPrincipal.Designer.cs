﻿namespace Sistema_Bancario
{
   partial class VentanaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTOperaciones = new System.Windows.Forms.Button();
            this.BTReportes = new System.Windows.Forms.Button();
            this.BTGestion = new System.Windows.Forms.Button();
            this.BTPlataforma = new System.Windows.Forms.Button();
            this.TituloText = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.stStatus = new System.Windows.Forms.StatusStrip();
            this.lblUsertType = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserValueType = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSucursal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblServidor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new Sistema_Bancario.Controles.GradentPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.MoveFrom = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3.SuspendLayout();
            this.stStatus.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(267, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 727);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 782);
            this.panel2.TabIndex = 7;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button11.BackColor = System.Drawing.Color.Brown;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.SystemColors.Window;
            this.button11.Location = new System.Drawing.Point(0, 852);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(267, 44);
            this.button11.TabIndex = 10;
            this.button11.Text = "Cerrar Sesión";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.BTOperaciones);
            this.panel3.Controls.Add(this.BTReportes);
            this.panel3.Controls.Add(this.BTGestion);
            this.panel3.Controls.Add(this.BTPlataforma);
            this.panel3.Location = new System.Drawing.Point(265, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1177, 39);
            this.panel3.TabIndex = 8;
            // 
            // BTOperaciones
            // 
            this.BTOperaciones.BackColor = System.Drawing.Color.Transparent;
            this.BTOperaciones.FlatAppearance.BorderSize = 0;
            this.BTOperaciones.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTOperaciones.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BTOperaciones.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BTOperaciones.Location = new System.Drawing.Point(0, 0);
            this.BTOperaciones.Margin = new System.Windows.Forms.Padding(4);
            this.BTOperaciones.Name = "BTOperaciones";
            this.BTOperaciones.Size = new System.Drawing.Size(147, 39);
            this.BTOperaciones.TabIndex = 8;
            this.BTOperaciones.Text = "Operaciones";
            this.BTOperaciones.UseVisualStyleBackColor = false;
            this.BTOperaciones.Click += new System.EventHandler(this.BTOperaciones_Click);
            // 
            // BTReportes
            // 
            this.BTReportes.BackColor = System.Drawing.Color.Transparent;
            this.BTReportes.FlatAppearance.BorderSize = 0;
            this.BTReportes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTReportes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BTReportes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BTReportes.Location = new System.Drawing.Point(366, 0);
            this.BTReportes.Margin = new System.Windows.Forms.Padding(4);
            this.BTReportes.Name = "BTReportes";
            this.BTReportes.Size = new System.Drawing.Size(117, 39);
            this.BTReportes.TabIndex = 11;
            this.BTReportes.Text = "Reportes";
            this.BTReportes.UseVisualStyleBackColor = false;
            this.BTReportes.Click += new System.EventHandler(this.BTReportes_Click);
            // 
            // BTGestion
            // 
            this.BTGestion.BackColor = System.Drawing.Color.Transparent;
            this.BTGestion.FlatAppearance.BorderSize = 0;
            this.BTGestion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTGestion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BTGestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BTGestion.Location = new System.Drawing.Point(141, 0);
            this.BTGestion.Margin = new System.Windows.Forms.Padding(4);
            this.BTGestion.Name = "BTGestion";
            this.BTGestion.Size = new System.Drawing.Size(100, 39);
            this.BTGestion.TabIndex = 9;
            this.BTGestion.Text = "Gestión";
            this.BTGestion.UseVisualStyleBackColor = false;
            this.BTGestion.Click += new System.EventHandler(this.BTGestion_Click);
            // 
            // BTPlataforma
            // 
            this.BTPlataforma.BackColor = System.Drawing.Color.Transparent;
            this.BTPlataforma.FlatAppearance.BorderSize = 0;
            this.BTPlataforma.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTPlataforma.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.BTPlataforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BTPlataforma.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BTPlataforma.Location = new System.Drawing.Point(241, 0);
            this.BTPlataforma.Margin = new System.Windows.Forms.Padding(4);
            this.BTPlataforma.Name = "BTPlataforma";
            this.BTPlataforma.Size = new System.Drawing.Size(125, 39);
            this.BTPlataforma.TabIndex = 10;
            this.BTPlataforma.Text = "Plataforma";
            this.BTPlataforma.UseVisualStyleBackColor = false;
            this.BTPlataforma.Click += new System.EventHandler(this.BTPlataforma_Click);
            // 
            // TituloText
            // 
            this.TituloText.AutoSize = true;
            this.TituloText.BackColor = System.Drawing.Color.Transparent;
            this.TituloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.TituloText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TituloText.Location = new System.Drawing.Point(272, 85);
            this.TituloText.Name = "TituloText";
            this.TituloText.Size = new System.Drawing.Size(93, 33);
            this.TituloText.TabIndex = 6;
            this.TituloText.Text = "Título";
            this.TituloText.Visible = false;
            // 
            // stStatus
            // 
            this.stStatus.BackColor = System.Drawing.SystemColors.Window;
            this.stStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsertType,
            this.lblUserValueType,
            this.toolStripStatusLabel7,
            this.lblSucursal,
            this.toolStripStatusLabel2,
            this.lblServidor,
            this.toolStripStatusLabel4,
            this.lblDatabase,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel8});
            this.stStatus.Location = new System.Drawing.Point(0, 898);
            this.stStatus.Name = "stStatus";
            this.stStatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.stStatus.Size = new System.Drawing.Size(1432, 25);
            this.stStatus.TabIndex = 13;
            this.stStatus.Text = "statusStrip1";
            // 
            // lblUsertType
            // 
            this.lblUsertType.Image = global::Sistema_Bancario.Properties.Resources.none;
            this.lblUsertType.Name = "lblUsertType";
            this.lblUsertType.Size = new System.Drawing.Size(105, 20);
            this.lblUsertType.Text = "Estudiante :";
            // 
            // lblUserValueType
            // 
            this.lblUserValueType.Name = "lblUserValueType";
            this.lblUserValueType.Size = new System.Drawing.Size(16, 20);
            this.lblUserValueType.Text = "?";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Image = global::Sistema_Bancario.Properties.Resources.sucursal;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(90, 20);
            this.toolStripStatusLabel7.Text = "Sucursal :";
            // 
            // lblSucursal
            // 
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(16, 20);
            this.lblSucursal.Text = "?";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = global::Sistema_Bancario.Properties.Resources.server;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(91, 20);
            this.toolStripStatusLabel2.Text = "Servidor :";
            // 
            // lblServidor
            // 
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(16, 20);
            this.lblServidor.Text = "?";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Image = global::Sistema_Bancario.Properties.Resources.database;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(99, 20);
            this.toolStripStatusLabel4.Text = "Database :";
            // 
            // lblDatabase
            // 
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(16, 20);
            this.lblDatabase.Text = "?";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(53, 20);
            this.toolStripStatusLabel10.Text = "     |     ";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel9.Image")));
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(133, 20);
            this.toolStripStatusLabel9.Text = "Instituto del Sur";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(0, 20);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 31);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 39);
            this.panel4.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cuadro de Opciones";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(226)))));
            this.panel6.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(72)))), ((int)(((byte)(150)))));
            this.panel6.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(183)))), ((int)(((byte)(226)))));
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.pbxClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1432, 31);
            this.panel6.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "::  SISTEMA BANCARIO";
            // 
            // pbxClose
            // 
            this.pbxClose.BackColor = System.Drawing.Color.Transparent;
            this.pbxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(1391, 0);
            this.pbxClose.Margin = new System.Windows.Forms.Padding(4);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(41, 31);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxClose.TabIndex = 1;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.PbxClose_Click);
            // 
            // MoveFrom
            // 
            this.MoveFrom.Fixed = true;
            this.MoveFrom.Horizontal = true;
            this.MoveFrom.TargetControl = this.panel6;
            this.MoveFrom.Vertical = true;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1432, 923);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.stStatus);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.TituloText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel3.ResumeLayout(false);
            this.stStatus.ResumeLayout(false);
            this.stStatus.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel panel3;
      private Bunifu.Framework.UI.BunifuCustomLabel TituloText;
      private System.Windows.Forms.Button button11;
      private Bunifu.Framework.UI.BunifuDragControl MoveFrom;
      private System.Windows.Forms.Button BTReportes;
      private System.Windows.Forms.Button BTPlataforma;
      private System.Windows.Forms.Button BTGestion;
      private System.Windows.Forms.Button BTOperaciones;
      private System.Windows.Forms.StatusStrip stStatus;
      private System.Windows.Forms.ToolStripStatusLabel lblUsertType;
      private System.Windows.Forms.ToolStripStatusLabel lblUserValueType;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
      private System.Windows.Forms.ToolStripStatusLabel lblSucursal;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
      private System.Windows.Forms.ToolStripStatusLabel lblServidor;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
      private System.Windows.Forms.ToolStripStatusLabel lblDatabase;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
      private Controles.GradentPanel panel6;
      private System.Windows.Forms.PictureBox pbxClose;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel panel4;
      private System.Windows.Forms.Label label2;
   }
}