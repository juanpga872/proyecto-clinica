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
    public partial class Form_CrearPerfil : Form
    {
        public Form_CrearPerfil()
        {
            InitializeComponent();
            CargarUsuarios();
            CargarRoles();
        }

        private void Btn_volver_recepcionista_Click(object sender, EventArgs e)
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


        private void btnCrearPerfil_Click(object sender, EventArgs e)
        {
            if (comboUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un usuario para crear el perfil.");
                return;
            }

            var seleccionado = comboUsuarios.SelectedItem;
            string documento = comboUsuarios.SelectedValue.ToString();

            if (GestorUsuarios.ListaUsuarios.Any(u => u.Documento == documento))
            {
                MessageBox.Show("Este usuario ya tiene un perfil asignado.");
                return;
            }

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string rol = (seleccionado as dynamic).Rol;

            var nuevoUsuario = new GestorUsuarios.usuario
            {
                Usuario = usuario,
                Contraseña = contraseña,
                Documento = documento,
                Rol = rol
            };

            GestorUsuarios.ListaUsuarios.Add(nuevoUsuario);
            MessageBox.Show("Perfil creado exitosamente.");
        }

        private void CargarUsuarios()
        {
            var listaGeneral = new List<dynamic>();

            foreach (var r in GestorRecepcionistas.ListaRecepcionista)
            {
                listaGeneral.Add(new
                {
                    Descripcion = $"{r.Nombre} - {r.Documento} (Recepcionista)",
                    Documento = r.Documento,
                    Rol = "Recepcionista"
                });
            }

            foreach (var d in BaseDatosSimulada.ListaDoctores)
            {
                listaGeneral.Add(new
                {
                    Descripcion = $"{d.NombreCompleto} - {d.Documento} (Doctor)",
                    Documento = d.Documento,
                    Rol = "Doctor"
                });
            }

            if (listaGeneral.Count > 0)
            {
                comboUsuarios.DataSource = listaGeneral;
                comboUsuarios.DisplayMember = "Descripcion";
                comboUsuarios.ValueMember = "Documento";
                comboUsuarios.SelectedIndex = 0; // selecciona el primero por defecto
            }
            else
            {
                comboUsuarios.DataSource = null;
                MessageBox.Show("No hay usuarios disponibles para asignar un perfil.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CargarRoles()
        {
            comboRoles.Items.Clear();
            comboRoles.Items.Add("Recepcionista");
            comboRoles.Items.Add("Doctor");
            comboRoles.Items.Add("Administrador");
            comboRoles.Items.Add("SuperAdmin");
            comboRoles.SelectedIndex = 0;
        }
    }
}

