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
    public partial class AgendarCita: Form
    {
        public static class BaseCitasSimulada
        {
            public static List<Cita> ListaCitas = new List<Cita>();
        }
        public AgendarCita()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txcPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txcDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeHora_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txcConsultorio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimeFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cita nuevaCita = new Cita
            {
                Paciente = txcPaciente.Text,
                Doctor = txcDoctor.Text,
                Consultorio = txcConsultorio.Text,
                FechaHora = DateTimeFecha.Value.Date + dateTimeHora.Value.TimeOfDay,
                Motivo = txtMotivo.Text
            };

            BaseCitasSimulada.ListaCitas.Add(nuevaCita);

            MessageBox.Show("Cita agendada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            txcPaciente.Text = "";
            txcDoctor.Text = "";
            txcConsultorio.Text = "";
            txtMotivo.Text = "";

        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {

        }

        private void AgendarCita_Load(object sender, EventArgs e)
        {
        
            txcDoctor.DataSource = null;
            txcDoctor.DataSource = BaseDatosSimulada.ListaDoctores;
            txcDoctor.DisplayMember = "NombreCompleto"; // Qué propiedad mostrar
        
        }
    }
}
