using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Bancario.Froms_opciones;
using Sistema_Bancario.Plataforma;
using Sistema_Bancario.plataforma_controles;
using Modelos.Modelos;
using Sistema_Bancario.Ventanilla;
using Sistema_Bancario.Config;
using Sistema_Bancario.Administrador;
using Modelos.Session;
//using Sistema_Bancario.Ventanilla;

namespace Sistema_Bancario
{
   public partial class VentanaPrincipal : Form
   {

      #region [ View Config ]
      private const int m_Shadow = 0x0020000;

      protected override CreateParams CreateParams
      {
         get
         {
            CreateParams _cp = base.CreateParams;
            _cp.ClassStyle |= m_Shadow;
            return _cp;
         }
      }

      #endregion

      private ISession Session = null;
      public VentanaPrincipal(ISession session)
      {

         try
         {
            Session = session;
            EvaluarUsuario();
            UIForm.SetRound(this, 7);

         }
         catch (Exception)
         { }
      }

      private void EvaluarUsuario()
      {
         if (Session != null)
         {
            InitializeComponent();

            if (Session.UserRol.Any(r => r.Descripcion == "Administrador"))
            {
                BTAdministrador.Visible = true;
            }
                Show();
            //if (Session.isAdmin)
            //{

            //}
            //else if (Session.User == 1)
            //{
            lblUsertType.Image = Properties.Resources.estudiante;
            //}

            SetSessionValues();
         }
         else
         {
            MessageBox.Show("Es necesario iniciar session");
         }
      }
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
      private void SetSessionValues()
      {
         lblUserValueType.Text = Session.UserNombreCompleto;
         lblSucursal.Text = Session.SucursalNombre;
            lblVentanilla.Text = Session.VentanillaDescripcion;
            lblTurno.Text = Session.TurnoDescripcion;
      }

      protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         if (keyData == (Keys.F1))
         {
            BTGestion.BackColor = SystemColors.HotTrack;
            panel2.Controls.Clear();
            this.Componentes(3);
            return true;
         }
         else if (keyData == (Keys.F2))
         {
            BTGestion.BackColor = SystemColors.HotTrack;
            panel2.Controls.Clear();
            this.Componentes(2);
            return true;
         }
         else if (keyData == (Keys.F3))
         {
            BTGestion.BackColor = SystemColors.HotTrack;
            panel2.Controls.Clear();
            this.Componentes(1);
            return true;
         }
         else if (keyData == (Keys.F4))
         {

         }
         return base.ProcessCmdKey(ref msg, keyData);
      }
      private void btnCerrar_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      public void CrearBoton(Button NombreButton, string Text, int x)
      {

         NombreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
         NombreButton.FlatAppearance.BorderSize = 0;
         NombreButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
         NombreButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
         NombreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         NombreButton.Font = new Font("Verdana", 8, FontStyle.Bold);
         NombreButton.Padding = new Padding(20, 0, 0, 0);
         NombreButton.ForeColor = System.Drawing.SystemColors.Window;
         NombreButton.Margin = new System.Windows.Forms.Padding(2);
         NombreButton.Size = new System.Drawing.Size(200, 41);
         NombreButton.TabIndex = 6;
         NombreButton.Text = Text;
         NombreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         NombreButton.UseVisualStyleBackColor = false;
         NombreButton.Location = new Point(0, x);
         NombreButton.Click += new EventHandler(Evento_Click);
         panel2.Controls.Add(NombreButton);

      }

      private void Evento_Click(object sender, EventArgs e)
      {
         Button btn = sender as Button;
         TituloText.Visible = true;

         #region Botones
         if (btn.Text.Equals("Retiros"))
         {
            if (!panel1.Controls.Contains(Retiros.instance))
            {
               panel1.Controls.Add(Retiros.instance);
               Retiros.instance.Dock = DockStyle.Fill;
               Retiros.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            else
            {
               TituloText.Text = btn.Text;
               Retiros.instance.BringToFront();
            }
         }
         else if (btn.Text.Equals("Depósitos"))
         {
            if (!panel1.Controls.Contains(Depositos.instance))
            {
               panel1.Controls.Add(Depositos.instance);
               Depositos.instance.Dock = DockStyle.Fill;
               Depositos.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            else
            {
               TituloText.Text = btn.Text;
               Depositos.instance.BringToFront();
            }
            //  Limpiar();
            //   button6.BackColor = SystemColors.HotTrack;

         }
         else if (btn.Text.Equals("Transferencias"))
         {
            if (!panel1.Controls.Contains(Transferencias.instance))
            {
               panel1.Controls.Add(Transferencias.instance);
               Transferencias.instance.Dock = DockStyle.Fill;
               Transferencias.instance.BringToFront();
               TituloText.Text = btn.Text;

            }
            else
            {
               Transferencias.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            //    Limpiar();
            //   button2.BackColor = SystemColors.HotTrack;
         }
         else if (btn.Text.Equals("Envío Giros"))
         {
            if (!panel1.Controls.Contains(Envio_Giros.instance))
            {
               panel1.Controls.Add(Envio_Giros.instance);
               Envio_Giros.instance.Dock = DockStyle.Fill;
               Envio_Giros.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            else
            {
               Envio_Giros.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            // Limpiar();
            //  button4.BackColor = SystemColors.HotTrack;
         }
         else if (btn.Text.Equals("Cobro Giros"))
         {
            if (!panel1.Controls.Contains(CobroGiros.instance))
            {
               panel1.Controls.Add(CobroGiros.instance);
               CobroGiros.instance.Dock = DockStyle.Fill;
               CobroGiros.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            else
            {
               TituloText.Text = btn.Text;
               CobroGiros.instance.BringToFront();
            }
            // Limpiar();
            //  button3.BackColor = SystemColors.HotTrack;
         }
         else if (btn.Text.Equals("Pago tarjetas"))
         {
            if (!panel1.Controls.Contains(Tarjetas.instance))
            {
               panel1.Controls.Add(Tarjetas.instance);
               Tarjetas.instance.Dock = DockStyle.Fill;
               Tarjetas.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            else
            {
               TituloText.Text = btn.Text;
               Tarjetas.instance.BringToFront();
            }
            //  Limpiar();
            //  button5.BackColor = SystemColors.HotTrack;
         }
         else if (btn.Text.Equals("Pago Cuotas"))
         {
            if (!panel1.Controls.Contains(Cuotas.getinstance()))
            {
               panel1.Controls.Add(Cuotas.getinstance());
               Cuotas.getinstance().Dock = DockStyle.Fill;
               Cuotas.getinstance().BringToFront();
               TituloText.Text = btn.Text;
            }
            else
            {
               TituloText.Text = btn.Text;
               Cuotas.getinstance().BringToFront();
            }
            //   Limpiar();
            //    button8.BackColor = SystemColors.HotTrack;
         }
         else if (btn.Text.Equals("Tipo Cambio"))
         {
            if (!panel1.Controls.Contains(Tipo_de_Cambio.instance))
            {
               panel1.Controls.Add(Tipo_de_Cambio.instance);
               Tipo_de_Cambio.instance.Dock = DockStyle.Fill;
               Tipo_de_Cambio.instance.BringToFront();
               TituloText.Text = btn.Text;

            }
            else
            {
               Tipo_de_Cambio.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            //  Limpiar();
            //   button1.BackColor = SystemColors.HotTrack;
         }
         else if (btn.Text.Equals("Pago Servicios"))
         {
            if (!panel1.Controls.Contains(Servicios.instance))
            {
               panel1.Controls.Add(Servicios.instance);
               Servicios.instance.Dock = DockStyle.Fill;
               Servicios.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            else
            {
               TituloText.Text = btn.Text;
               Servicios.instance.BringToFront();
            }

            //  Limpiar();
            // button10.BackColor = SystemColors.HotTrack;
         }
         else if (btn.Text.Equals("Abrir Cuenta"))
         {
                NuevaCuentaUserControl cuenta;
                if (this.Session != null)
                {
                    cuenta = new NuevaCuentaUserControl(this.Session);
                    if (!panel1.Controls.Contains(cuenta))
                    {
                        panel1.Controls.Add(cuenta);
                        cuenta.Dock = DockStyle.Fill;
                        cuenta.BringToFront();
                        TituloText.Text = btn.Text;
                    }
                    else
                    {
                        cuenta.BringToFront();
                        TituloText.Text = btn.Text;
                    }
                }
                else
                {
                    MessageBox.Show("La sesión ha caducado");
                }
            //   Limpiar();
            //   button2.BackColor = SystemColors.HotTrack;
         }
         else if (btn.Text.Equals("Gestionar Cuenta"))
         {
            if (!panel1.Controls.Contains(UCactualizarCuenta.instance))
            {
               panel1.Controls.Add(UCactualizarCuenta.instance);
               UCactualizarCuenta.instance.Dock = DockStyle.Fill;
               UCactualizarCuenta.instance.BringToFront();
               TituloText.Text = btn.Text;

            }
            else
            {
               UCactualizarCuenta.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            //    Limpiar();
            //   button2.BackColor = SystemColors.HotTrack;
         }
         else if (btn.Text.Equals("Realizar Préstamo"))
         {
            if (!panel1.Controls.Contains(UCprestamos.instance))
            {
               panel1.Controls.Add(UCprestamos.instance);
               UCprestamos.instance.Dock = DockStyle.Fill;
               UCprestamos.instance.BringToFront();
               TituloText.Text = btn.Text;

            }
            else
            {
               UCprestamos.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            //    Limpiar();
            //   button2.BackColor = SystemColors.HotTrack;
         }
         else if (btn.Text.Equals("Refinanciar"))
         {
            if (!panel1.Controls.Contains(UCrefinanciar.instance))
            {
               panel1.Controls.Add(UCrefinanciar.instance);
               UCrefinanciar.instance.Dock = DockStyle.Fill;
               UCrefinanciar.instance.BringToFront();
               TituloText.Text = btn.Text;

            }
            else
            {
               UCrefinanciar.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            //    Limpiar();
            //   button2.BackColor = SystemColors.HotTrack;
         }
         else if (btn.Text.Equals("Solicitar Chequera"))
         {
            if (!panel1.Controls.Contains(UCchequeras.instance))
            {
               panel1.Controls.Add(UCchequeras.instance);
               UCchequeras.instance.Dock = DockStyle.Fill;
               UCchequeras.instance.BringToFront();
               TituloText.Text = btn.Text;

            }
            else
            {
               UCchequeras.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            //    Limpiar();
            //   button2.BackColor = SystemColors.HotTrack;
         }
         else if (btn.Text.Equals("Balancin Caja"))
         {
            if (!panel1.Controls.Contains(Balancin.instance))
            {
               panel1.Controls.Add(Balancin.instance);
               Balancin.instance.Dock = DockStyle.Fill;
               Balancin.instance.BringToFront();
               TituloText.Text = btn.Text;

            }
            else
            {
               Balancin.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
         }
         else if (btn.Text.Equals("Resumen total"))
         {
            if (!panel1.Controls.Contains(ResumenTotal.instance))
            {
               panel1.Controls.Add(ResumenTotal.instance);
               ResumenTotal.instance.Dock = DockStyle.Fill;
               ResumenTotal.instance.BringToFront();
               TituloText.Text = btn.Text;

            }
            else
            {
               ResumenTotal.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
         }
         else if (btn.Text.Equals("Cliente"))
         {
            if (!panel1.Controls.Contains(UCcliente.instance))
            {
               panel1.Controls.Add(UCcliente.instance);
               UCcliente.instance.Dock = DockStyle.Fill;
               UCcliente.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            else
            {
               UCcliente.instance.BringToFront();
               TituloText.Text = btn.Text;
            }
            }
            else if (btn.Text.Equals("Cobro Cheques"))
            {
                if (!panel1.Controls.Contains(Cheques.instance))
                {
                    panel1.Controls.Add(Cheques.instance);
                    Cheques.instance.Dock = DockStyle.Fill;
                    Cheques.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
                else
                {
                    UCcliente.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
            }

            else if (btn.Text.Equals("Personas"))
            {
                if (!panel1.Controls.Contains(Personas.instance))
                {
                    panel1.Controls.Add(Personas.instance);
                    Personas.instance.Dock = DockStyle.Fill;
                    Personas.instance.BringToFront();
                    TituloText.Text = btn.Text;

                }
                else
                {
                    Personas.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
            }


            else if (btn.Text.Equals("Roles"))
            {
                if (!panel1.Controls.Contains(Roles.instance))
                {
                    panel1.Controls.Add(Roles.instance);
                    Roles.instance.Dock = DockStyle.Fill;
                    Roles.instance.BringToFront();
                    TituloText.Text = btn.Text;

                }
                else
                {
                    Roles.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
            }


            else if (btn.Text.Equals("Permisos"))
            {
                if (!panel1.Controls.Contains(Permisos.instance))
                {
                    
                    panel1.Controls.Add(Permisos.instance);
                    Permisos.instance.Dock = DockStyle.Fill;
                    Permisos.instance.BringToFront();
                    TituloText.Text = btn.Text;

                }
                else
                {
                    Permisos.instance.BringToFront();
                    TituloText.Text = btn.Text;
                }
            }

            #endregion
        }
      private void Componentes(int x)
      {
         switch (x)
         {
            case 1:

                    if (Session.Componentes.Any(c => c.Nombre == "Abrir Cuenta"))
                    {
                        Button AbrirCuenta = new Button();
                        this.CrearBoton(AbrirCuenta, "Abrir Cuenta", 0);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Gestionar Cuenta"))
                    {
                        Button GestionarCuenta = new Button();
                        this.CrearBoton(GestionarCuenta, "Gestionar Cuenta", 50);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Realizar Préstamo"))
                    {
                        Button RealizarPrestamo = new Button();
                        this.CrearBoton(RealizarPrestamo, "Realizar Préstamo", 100);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Refinanciar"))
                    {
                        Button Refinanciar = new Button();
                        this.CrearBoton(Refinanciar, "Refinanciar", 150);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Solicitar Chequera"))
                    {
                        Button SolicitarChequera = new Button();
                        this.CrearBoton(SolicitarChequera, "Solicitar Chequera", 200);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Gestionar Chequera"))
                    {
                        Button GestionarChequera = new Button();
                        this.CrearBoton(GestionarChequera, "Gestionar Chequera", 250);
                    }
                    break;
            case 2:
               Button Cliente = new Button();
               Button TipoCliente = new Button();
               Button Moneda = new Button();
               Button TipoCuenta = new Button();
               Button InteresesMoratorios = new Button();
               Button Aseguradora = new Button();
               Button Empleado = new Button();

               this.CrearBoton(Cliente, "Cliente", 0);
               this.CrearBoton(TipoCliente, "TipoCliente", 50);
               this.CrearBoton(TipoCuenta, "Tipo Cuenta", 100);
               this.CrearBoton(InteresesMoratorios, "Intereses Moratorios", 150);
               break;
            case 3:
              

                    if (Session.Componentes.Any(c => c.Nombre == "Retiros"))
                    {
                        Button Retiros = new Button();
                        this.CrearBoton(Retiros, "Retiros", 0);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Depósitos"))
                    {
                        Button Depositos = new Button();
                        this.CrearBoton(Depositos, "Depósitos", 50);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Transferencias"))
                    {
                        Button Transferencias = new Button();
                        this.CrearBoton(Transferencias, "Transferencias", 100);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Envío Giros"))
                    {
                        Button Envio_Giros = new Button();
                        this.CrearBoton(Envio_Giros, "Envío Giros", 150);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Cobro Giros"))
                    {
                        Button Cobro_Giros = new Button();
                        this.CrearBoton(Cobro_Giros, "Cobro Giros", 200);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Cobro Giros"))
                    {
                        Button Pago_tarjetas = new Button();
                        this.CrearBoton(Pago_tarjetas, "Pago tarjetas", 250);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Pago Cuotas"))
                    {
                        Button Pago_Cuotas = new Button();
                        this.CrearBoton(Pago_Cuotas, "Pago Cuotas", 300);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Tipo Cambio"))
                    {
                        Button Tipo_Cambio = new Button();
                        this.CrearBoton(Tipo_Cambio, "Tipo Cambio", 350);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Pago Servicios"))
                    {
                        Button Pago_Servicios = new Button();
                        this.CrearBoton(Pago_Servicios, "Pago Servicios", 400);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Cobro Cheques"))
                    {
                        Button Cobro_Cheques = new Button();
                        this.CrearBoton(Cobro_Cheques, "Cobro Cheques", 450);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Balancin Caja"))
                    {
                        Button Balancin = new Button();
                        this.CrearBoton(Balancin, "Balancin Caja", 500);
                    }

                    if (Session.Componentes.Any(c => c.Nombre == "Resumen Total"))
                    {
                        Button Resumen_total = new Button();
                        this.CrearBoton(Resumen_total, "Resumen total", 550);
                    }
               break;


             case 4:
               Button Personas = new Button();
               Button Roles = new Button();
               Button Permisos = new Button();

               this.CrearBoton(Personas, "Personas", 0);
               this.CrearBoton(Roles, "Roles", 50);
               this.CrearBoton(Permisos, "Permisos", 100);
               break;
            }
      }

      private void BTGestion_Click(object sender, EventArgs e)
      {
         Marcar(sender);
         panel2.Controls.Clear();
         this.Componentes(2);
      }

      private void BTPlataforma_Click(object sender, EventArgs e)
      {
         Marcar(sender);
         panel2.Controls.Clear();
         this.Componentes(1);
      }

      private void BTReportes_Click(object sender, EventArgs e)
      {
         Marcar(sender);
      }

      private void BTOperaciones_Click(object sender, EventArgs e)
      {
         Marcar(sender);
         panel2.Controls.Clear();
         this.Componentes(3);
      }

      private void BTAdministrador_Click(object sender, EventArgs e)
      {
          Marcar(sender);
          panel2.Controls.Clear();
          this.Componentes(4);
      }

        private void Marcar(object boton)
      {
         Button BotonMenu;
         BotonMenu = boton as Button;
         BTOperaciones.BackColor = Color.Transparent;
         BTReportes.BackColor = Color.Transparent;
         BTGestion.BackColor = Color.Transparent;
         BTPlataforma.BackColor = Color.Transparent;
            BTOperaciones.ForeColor = Color.Black;
            BTReportes.ForeColor = Color.Black;
            BTGestion.ForeColor = Color.Black;
            BTPlataforma.ForeColor = Color.Black;
            BotonMenu.BackColor = SystemColors.HotTrack;
            BotonMenu.ForeColor = Color.White;   
      }

      private void PbxClose_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void Button11_Click(object sender, EventArgs e)
      {
         Login lg = new Login();
         lg.Show();

         this.Close();
      }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
