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
    public partial class Form_VerRecepcionistas : Form
    {
        public Form_VerRecepcionistas()
        {
            InitializeComponent();
            this.dataGridViewRecepcionistas.DataError += dataGridViewRecepcionistas_DataError;
            CargarRecepcionistas();
        }

        private void CargarRecepcionistas()
        {
            if (GestorRecepcionistas.ListaRecepcionista.Count == 0)
            {
                MessageBox.Show("No hay recepcionistas registrados.");
                dataGridViewRecepcionistas.DataSource = null;
            }
            else
            {
                dataGridViewRecepcionistas.DataSource = null;
                dataGridViewRecepcionistas.DataSource = GestorRecepcionistas.ListaRecepcionista;
            }
        }
        private void dataGridViewRecepcionistas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Cancelamos el error silenciosamente
            e.ThrowException = false;
        }

        private void dataGridViewRecepcionistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewRecepcionistas.Columns["Eliminar"]?.Index && e.RowIndex >= 0)
            {
                var recepcionista = (GestorRecepcionistas.recepcionista)dataGridViewRecepcionistas.Rows[e.RowIndex].DataBoundItem;
                GestorRecepcionistas.ListaRecepcionista.Remove(recepcionista);
                CargarRecepcionistas();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.ToLower();

            var resultados = GestorRecepcionistas.ListaRecepcionista
                .Where(r => r.Nombre.ToLower().Contains(textoBusqueda) ||
                            r.Documento.ToLower().Contains(textoBusqueda))
                .ToList();

            dataGridViewRecepcionistas.DataSource = null;
            dataGridViewRecepcionistas.DataSource = resultados;
        }

        private void Btn_volver_Click_1(object sender, EventArgs e)
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
