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
    public partial class Form_DoctorMenu : Form
    {
        public Form_DoctorMenu()
        {
            InitializeComponent();
        }

        private void Btn_Registrarpacientes_doctor_Click(object sender, EventArgs e)
        {
            Form_RegistrarPacientes registrar = new Form_RegistrarPacientes();
            registrar.Show();
            this.Hide();
        }

        private void Btn_Verpacientes_doctor_Click(object sender, EventArgs e)
        {
            Form_VerPacientes ver = new Form_VerPacientes();
            ver.Show();
            this.Hide();
        }

        private void Btn_volver_doctor_Click(object sender, EventArgs e)
        {
           FormLogin ver = new FormLogin();
           ver.Show();
           this.Hide();  
        }

        private void Btn_Agendarcitas_doctor_Click(object sender, EventArgs e)
        {
            AgendarCita agendarCita = new AgendarCita();
            agendarCita.Show();
            this.Hide();
        }
    }
}
