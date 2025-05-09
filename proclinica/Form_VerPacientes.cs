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
    public partial class Form_VerPacientes : Form
    {
        public Form_VerPacientes()
        {
            InitializeComponent();
            this.dataGridViewPacientes.DataError += dataGridViewPacientes_DataError;
            CargarPacientes();

        }

  

        private void CargarPacientes()
        {
            if (GestorPacientes.ListaPacientes.Count == 0)
            {
                MessageBox.Show("No hay pacientes registrados.");
                dataGridViewPacientes.DataSource = null;  // Limpiar cualquier dato anterior
            }
            else
            {
                dataGridViewPacientes.DataSource = null;  // Limpiar la fuente de datos
                dataGridViewPacientes.DataSource = GestorPacientes.ListaPacientes;  // Asignar la lista de pacientes
            }
        }

        private void dataGridViewPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el clic fue en la columna "Eliminar"
            if (e.ColumnIndex == dataGridViewPacientes.Columns["Eliminar"]?.Index && e.RowIndex >= 0)
            {
                var paciente = (GestorPacientes.Paciente)dataGridViewPacientes.Rows[e.RowIndex].DataBoundItem;
                GestorPacientes.ListaPacientes.Remove(paciente);  // Eliminar el paciente de la lista
                CargarPacientes();  // Recargar la lista de pacientes
            }
        }
        private void dataGridViewPacientes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Cancelamos el error silenciosamente
            e.ThrowException = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.ToLower();

            // Filtrar la lista de pacientes según el texto de búsqueda
            var resultados = GestorPacientes.ListaPacientes
                .Where(p => p.Nombre.ToLower().Contains(textoBusqueda) ||
                            p.Documento.ToLower().Contains(textoBusqueda))
                .ToList();

            dataGridViewPacientes.DataSource = null;
            dataGridViewPacientes.DataSource = resultados;  // Mostrar los resultados filtrados
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