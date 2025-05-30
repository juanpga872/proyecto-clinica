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

        private void btnVerCita_Click(object sender, EventArgs e)
        {
            VerCitas verCitas = new VerCitas();
            verCitas.Show();
            this.Hide();

        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form_RegistrarPacientes registrarPacientes = new Form_RegistrarPacientes();
            registrarPacientes.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form_VerPacientes verPacientes = new Form_VerPacientes();
            verPacientes.Show();
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form_RegistrarRecepcionistas form_RegistrarRecepcionistas = new Form_RegistrarRecepcionistas();
            form_RegistrarRecepcionistas.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form_VerRecepcionistas form_VerRecepcionistas = new Form_VerRecepcionistas();
            form_VerRecepcionistas.Show();
            this.Hide();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialPaciente historialPaciente = new HistorialPaciente();
            historialPaciente.Show();
            this.Hide();

        }
    }
}
