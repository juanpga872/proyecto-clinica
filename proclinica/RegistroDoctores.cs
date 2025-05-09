using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proclinica;

namespace proclinica
{





    public partial class RegistroDoctores: Form
    {

        public RegistroDoctores()
        {
            InitializeComponent();
        }



        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Doctor nuevoDoctor = new Doctor()
            {
                NombreCompleto = txt_nombreCompleto.Text,
                Genero = txtGenero.Text,
                Especialidad = txtEspecialidad.Text,
                Documento = txtDocumento.Text,
                TipoDocumento = txtTipoDocumento.Text,
                Edad = int.Parse(txtEdad.Text),
                Telefono = txtTelefono.Text
            };

            BaseDatosSimulada.ListaDoctores.Add(nuevoDoctor);

            MessageBox.Show("Doctor registrado correctamente");

            // Opcional: limpiar campos después de agregar
            txt_nombreCompleto.Clear();
            txtGenero.Clear();
            txtEspecialidad.Clear();
            txtDocumento.Clear();
            txtTipoDocumento.Clear();
            txtEdad.Clear();
            txtTelefono.Clear();

        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            if (GestorUsuarios.UsuarioActual != null)
            {
                string rolActual = GestorUsuarios.UsuarioActual.Rol;

                switch (rolActual)
                {
                    case "Recepcionista":

                        new recepcionistas_mainmenu().Show();
                        break;
                    case "SuperAdmin":

                        new Form_prueba().Show();
                        break;

                    case "Administrador":
                        new AdminMenu().Show();
                        break;

                    case "Doctor":
                        new Form_DoctorMenu().Show();
                        break;

                    default:

                        MessageBox.Show("No se definió una ventana de regreso para este rol.", "Error de Navegación", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        break;
                }


                this.Hide();
            }
        }

    }
}
