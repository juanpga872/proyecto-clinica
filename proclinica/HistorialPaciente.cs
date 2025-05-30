using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static proclinica.GestorPacientes;

namespace proclinica
{
    public partial class HistorialPaciente : Form
    {
        public HistorialPaciente()
        {
            InitializeComponent();
        }

        private void HistorialPaciente_Load(object sender, EventArgs e)
        {
            // Cargar nombres de pacientes en el ComboBox
            cmbPacientes.DataSource = null;
            cmbPacientes.DataSource = GestorPacientes.ListaPacientes;
            cmbPacientes.DisplayMember = "Nombre";
            cmbPacientes.SelectedIndex = -1; // Para que no se seleccione ninguno por defecto
        }

        public void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pacienteSeleccionado = cmbPacientes.SelectedItem as Paciente;

            if (pacienteSeleccionado != null && pacienteSeleccionado.HistorialCitas != null)
            {
                dgvHistorial.DataSource = null;

                dgvHistorial.DataSource = pacienteSeleccionado.HistorialCitas
                    .Select(c => new
                    {
                        Doctor = c.Doctor,
                        Consultorio = c.Consultorio,
                        Fecha = c.FechaHora.ToString("dd/MM/yyyy"),
                        Hora = c.FechaHora.ToString("HH:mm"),
                        Motivo = c.Motivo
                    })
                    .ToList();
            }
            else
            {
                dgvHistorial.DataSource = null;
            }
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();

            var menu = new AdminMenu();
            menu.FormClosed += (s, args) => this.Close(); // Asegura que cierre todo si se cierra el menú
            menu.Show();
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si más adelante quieres manejar clicks en las celdas
        }
    }
}
