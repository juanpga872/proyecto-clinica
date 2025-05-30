using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proclinica
{
    public partial class Form_RegistrarPacientes : Form
    {
        public Form_RegistrarPacientes()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén completos
            if (txtNombre.Text == "" || cmbTipoDoc.SelectedIndex == -1 ||
                txtDocumento.Text == "" || cmbGenero.SelectedIndex == -1 ||
                txtEdad.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // Verificar que la edad sea un número válido
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("La edad debe ser un número.");
                return;
            }

            // Crear un nuevo paciente y agregarlo a la lista
            var paciente = new GestorPacientes.Paciente
            {
                Nombre = txtNombre.Text,
                TipoDocumento = cmbTipoDoc.Text,
                Documento = txtDocumento.Text,
                Genero = cmbGenero.Text,
                Edad = edad,
                Telefono = txtTelefono.Text
            };

            GestorPacientes.ListaPacientes.Add(paciente);  // Agregar a la lista de pacientes
            MessageBox.Show("Paciente registrado con éxito.");

            LimpiarFormulario();  // Limpiar los campos del formulario
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDocumento.Clear();
            txtEdad.Clear();
            txtTelefono.Clear();
            cmbTipoDoc.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
        }

        private void Btn_volver_Click(object sender, EventArgs e)
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