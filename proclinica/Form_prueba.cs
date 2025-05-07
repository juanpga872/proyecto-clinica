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
    public partial class Form_prueba : Form
    {
        public Form_prueba()
        {
            InitializeComponent();
        }

        private void btnRegistrarRecepcionista_Click(object sender, EventArgs e)
        {
            Form_RegistrarRecepcionistas registrar = new Form_RegistrarRecepcionistas();
            registrar.Show();
        }

        private void btnVerRecepcionistas_Click(object sender, EventArgs e)
        {
            Form_VerRecepcionistas ver = new Form_VerRecepcionistas();
            ver.Show();
        }
    }
}
