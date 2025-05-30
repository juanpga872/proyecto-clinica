using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace proclinica
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string usuario = correo_txt.Text;
            string contraseña = contraseña_txt.Text;

            var usuarioEncontrado = GestorUsuarios.ListaUsuarios
                .FirstOrDefault(u => u.Usuario == usuario && u.Contraseña == contraseña);

            if (usuarioEncontrado != null)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GestorUsuarios.UsuarioActual = usuarioEncontrado;

                this.Hide();

                switch (usuarioEncontrado.Rol)
                {
                    case "Administrador":
                        new AdminMenu().Show();
                        break;
                    case "Recepcionista":
                        new recepcionistas_mainmenu().Show();
                        break;
                    case "Doctor":
                        new Form_DoctorMenu().Show();
                        break;
                    default:
                        MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        public void guna2TextBox1_OnTextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {

        }

        private void correo_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
