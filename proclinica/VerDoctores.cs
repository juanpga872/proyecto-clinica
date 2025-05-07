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
    public partial class VerDoctores: Form
    {
        public VerDoctores()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            //aqui funcion para volver al AdminMenu
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();


        }

        private void VerDoctores_Load(object sender, EventArgs e)
        {
            // Vincular la lista de doctores al DataGridView
            tablaDoctores.DataSource = null;
            tablaDoctores.DataSource = BaseDatosSimulada.ListaDoctores;
        }
    }
}
