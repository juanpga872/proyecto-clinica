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
    public partial class VerCitas: Form
    {
        public VerCitas()
        {
            InitializeComponent();
        }

        private void VerCitas_Load(object sender, EventArgs e)
        {
            // Cargar la lista de citas en el DataGridView
            dgvCitas.DataSource = null;
            dgvCitas.DataSource = AgendarCita.BaseCitasSimulada.ListaCitas;
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu menu = new AdminMenu();
            menu.Show();
        }
    }
}
