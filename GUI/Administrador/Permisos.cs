using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Modelos;

namespace Sistema_Bancario.Administrador
{
    public partial class Permisos : UserControl
    {
        public Permisos()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            cmbRoles.SelectedItem = null;
            llenarComboBox();
            llenarDGVPermisos();
        }

        private static Permisos _instance;
        public static Permisos instance
        {
           
            get
            {
                if (_instance == null)
                {
                    _instance = new Permisos();
                }
                
                return _instance;
                
            }
        }

        public List<RolesModel> roles;
        public int idRol;

    
        
        private void llenarComboBox() {

            try
            {

                using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                {

                    roles = rol.Roles_ObtenerTodos().ToList();


                    cmbRoles.DataSource = roles;

                    cmbRoles.DisplayMember = "Descripcion";
                    //cmbRoles.ValueMember = "Id";
                    
                    


                    //cmbRoles.Items.Add(r.Descripcion);

                }

            }

            catch (Exception ex)
            {

            }

        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            RolesModel rm = cmbRoles.SelectedValue as RolesModel;

            idRol = rm.Id;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            llenarComboBox();
        }


        public List<ComponenteModel> permisos;
        private void llenarDGVPermisos()

        {

            try
            {

                using (WsSistemaBancario.ComponenteServiceClient PermisosRol = new WsSistemaBancario.ComponenteServiceClient())
                {




                    permisos = PermisosRol.Componente_ObtenerComponentesRol(4).ToList();

                    dgvPermisos.DataSource = permisos;

                }

            }

            catch (Exception ex)
            {

            }



        }



    }
}