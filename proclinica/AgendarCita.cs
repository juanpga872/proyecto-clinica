using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proclinica
{
    public partial class AgendarCita: Form
    {
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
        public AgendarCita()
        {
            InitializeComponent();
        }

            // Agregar cita a la lista general
            BaseCitasSimulada.ListaCitas.Add(nuevaCita);

            MessageBox.Show("Cita agendada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private void AgendarCita_Load(object sender, EventArgs e)
        {
            // Cargar doctores
            txcDoctor.DataSource = null;
            txcDoctor.DataSource = BaseDatosSimulada.ListaDoctores;
            txcDoctor.DisplayMember = "NombreCompleto";

            // Limpiar campos
            txcPaciente.SelectedIndex = -1;
            txcDoctor.SelectedIndex = -1;
            txcConsultorio.SelectedIndex = -1;
            txtMotivo.Clear();
            // Cargar pacientes
            txcPaciente.DataSource = null;
            txcPaciente.DataSource = GestorPacientes.ListaPacientes;
            txcPaciente.DisplayMember = "Nombre";
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (GestorUsuarios.UsuarioActual != null)
            {
                string rolActual = GestorUsuarios.UsuarioActual.Rol;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var pacienteSeleccionado = txcPaciente.SelectedItem as GestorPacientes.Paciente;

                switch (rolActual)
                {
                    case "Recepcionista":
            if (pacienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un paciente válido.");
                return;
            }

                        new recepcionistas_mainmenu().Show();
                        break;
                    case "SuperAdmin":

                        new Form_prueba().Show();
                        break;
            DateTime fechaHora = DateTimeFecha.Value.Date + dateTimeHora.Value.TimeOfDay;

                    case "Administrador":
                        new AdminMenu().Show();
                        break;
            Cita nuevaCita = new Cita
            {
                Paciente = pacienteSeleccionado.Nombre,
                Doctor = txcDoctor.Text,
                Consultorio = txcConsultorio.Text,
                FechaHora = fechaHora,
                Motivo = txtMotivo.Text
            };
                Motivo = txtMotivo.Text
                    case "Doctor":
                        new Form_DoctorMenu().Show();
                        break;
            // Agregar cita al historial del paciente
            pacienteSeleccionado.HistorialCitas.Add(nuevaCita);

            // Agregar cita a la lista general
            BaseCitasSimulada.ListaCitas.Add(nuevaCita);
                Motivo = txtMotivo.Text
            BaseCitasSimulada.ListaCitas.Add(nuevaCita);
                Motivo = txtMotivo.Text
                        MessageBox.Show("No se definió una ventana de regreso para este rol.", "Error de Navegación", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                        break;
                }
            // Limpiar campos
            txcPaciente.SelectedIndex = -1;
            txcDoctor.SelectedIndex = -1;
            txcConsultorio.SelectedIndex = -1;
            txtMotivo.Clear();
        }
            txtMotivo.Text = "";

                this.Hide();
            }
        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        private void btnVolverAtras_Click(object sender, EventArgs e)
        
        private void AgendarCita_Load(object sender, EventArgs e)
        {
        
            txcDoctor.DataSource = null;
            txcDoctor.DataSource = BaseDatosSimulada.ListaDoctores;
            txcDoctor.DisplayMember = "NombreCompleto"; // Qué propiedad mostrar
        
        }
=======
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
>>>>>>> juanpablo/clinic-app

        // Eventos vacíos (puedes eliminar si no los usas)
        private void guna2HtmlLabel1_Click(object sender, EventArgs e) { }
        private void txcPaciente_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txcDoctor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimeHora_ValueChanged(object sender, EventArgs e) { }
        private void txcConsultorio_SelectedIndexChanged(object sender, EventArgs e) { }
        private void DateTimeFecha_ValueChanged(object sender, EventArgs e) { }
        private void txtMotivo_TextChanged(object sender, EventArgs e) { }
        private void guna2HtmlLabel4_Click(object sender, EventArgs e) { }
            txcDoctor.DisplayMember = "NombreCompleto"; // Qué propiedad mostrar
        
        }
            txcDoctor.DisplayMember = "NombreCompleto"; // Qué propiedad mostrar
        
        }
            txcDoctor.DisplayMember = "NombreCompleto"; // Qué propiedad mostrar
        
        }
    }
}
