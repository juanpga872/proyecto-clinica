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
    }
}
