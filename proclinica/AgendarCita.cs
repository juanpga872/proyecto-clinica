using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proclinica
{
    public partial class AgendarCita : Form
    {
        // Simulación de base de datos de citas
        public static class BaseCitasSimulada
        {
            public static List<Cita> ListaCitas = new List<Cita>
            {
                new Cita
                {
                    Paciente = "Ana Torres",
                    Doctor = "Dr. Juan Pérez",
                    Consultorio = "101A",
                    FechaHora = new DateTime(2025, 6, 1, 9, 30, 0),
                    Motivo = "Chequeo general"
                },
                new Cita
                {
                    Paciente = "Carlos López",
                    Doctor = "Dra. María Gómez",
                    Consultorio = "102B",
                    FechaHora = new DateTime(2025, 6, 2, 11, 0, 0),
                    Motivo = "Dolor de cabeza"
                },
                new Cita
                {
                    Paciente = "Laura Mejía",
                    Doctor = "Dr. Juan Pérez",
                    Consultorio = "101A",
                    FechaHora = new DateTime(2025, 6, 3, 14, 45, 0),
                    Motivo = "Consulta pediátrica"
                }
            };
        }

        public AgendarCita()
        {
            InitializeComponent();
        }

        private void AgendarCita_Load(object sender, EventArgs e)
        {
            // Cargar doctores
            txcDoctor.DataSource = null;
            txcDoctor.DataSource = BaseDatosSimulada.ListaDoctores;
            txcDoctor.DisplayMember = "NombreCompleto";

            // Cargar pacientes
            txcPaciente.DataSource = null;
            txcPaciente.DataSource = GestorPacientes.ListaPacientes;
            txcPaciente.DisplayMember = "Nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var pacienteSeleccionado = txcPaciente.SelectedItem as GestorPacientes.Paciente;

            if (pacienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un paciente válido.");
                return;
            }

            DateTime fechaHora = DateTimeFecha.Value.Date + dateTimeHora.Value.TimeOfDay;

            Cita nuevaCita = new Cita
            {
                Paciente = pacienteSeleccionado.Nombre,
                Doctor = txcDoctor.Text,
                Consultorio = txcConsultorio.Text,
                FechaHora = fechaHora,
                Motivo = txtMotivo.Text
            };

            // Agregar cita al historial del paciente
            pacienteSeleccionado.HistorialCitas.Add(nuevaCita);

            // Agregar cita a la lista general
            BaseCitasSimulada.ListaCitas.Add(nuevaCita);

            MessageBox.Show("Cita agendada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos
            txcPaciente.SelectedIndex = -1;
            txcDoctor.SelectedIndex = -1;
            txcConsultorio.SelectedIndex = -1;
            txtMotivo.Clear();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        // Eventos vacíos (puedes eliminar si no los usas)
        private void guna2HtmlLabel1_Click(object sender, EventArgs e) { }
        private void txcPaciente_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txcDoctor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimeHora_ValueChanged(object sender, EventArgs e) { }
        private void txcConsultorio_SelectedIndexChanged(object sender, EventArgs e) { }
        private void DateTimeFecha_ValueChanged(object sender, EventArgs e) { }
        private void txtMotivo_TextChanged(object sender, EventArgs e) { }
        private void guna2HtmlLabel4_Click(object sender, EventArgs e) { }
    }
}
