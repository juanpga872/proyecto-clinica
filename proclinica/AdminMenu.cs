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
    public partial class AdminMenu: Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnRegistraDoctores_Click(object sender, EventArgs e)
        {
            RegistroDoctores RegistroDoctores = new RegistroDoctores();
            RegistroDoctores.Show();

            this.Hide();

        }

        private void btnVerDoctores_Click(object sender, EventArgs e)
        {
            VerDoctores verDoctores = new VerDoctores();
            verDoctores.Show();

            this.Hide();

        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            AgendarCita agendarCita = new AgendarCita();
            agendarCita.Show();
            this.Hide();

        }

        private void Btnregistrarsecretarios_admin_Click(object sender, EventArgs e)
        {
            Form_RegistrarRecepcionistas registrar = new Form_RegistrarRecepcionistas();
            registrar.Show();
            this.Hide();
        }

        private void Btn_versecretarios_admin_Click(object sender, EventArgs e)
        {
            Form_VerRecepcionistas ver = new Form_VerRecepcionistas();
            ver.Show();
            this.Hide();
        }

        private void btn_registrarpacientes_admin_Click(object sender, EventArgs e)
        {
            Form_RegistrarPacientes registrar = new Form_RegistrarPacientes();
            registrar.Show();
            this.Hide();
        }

        private void btn_verpacientes_admin_Click(object sender, EventArgs e)
        {
            Form_VerPacientes ver = new Form_VerPacientes();
            ver.Show();
            this.Hide();
        }

        private void btncrearperfil_Click(object sender, EventArgs e)
        {
            Form_CrearPerfil ver = new Form_CrearPerfil();
            ver.Show();
            this.Hide();
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            FormLogin ver = new FormLogin();
            ver.Show();
            this.Hide();
        }
    }
}
