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
    public partial class Form_RegistrarRecepcionistas : Form
    {
        public Form_RegistrarRecepcionistas()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén completos
            if (txtNombre.Text == "" || cmbTipoDoc.SelectedIndex == -1 ||
                txtDocumento.Text == "" || cmbGenero.SelectedIndex == -1 ||
                txtEdad.Text == "" || txtTelefono.Text == "" ||txtcorreo.Text == "")
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }
            // Verificar que la edad sea un número válido
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("La edad debe ser un número.");
                return;
            }
            // Crear un nuevo recepcionista y agregarlo a la lista
            var recepcionista = new GestorRecepcionistas.recepcionista
            {
                Nombre = txtNombre.Text,
                TipoDocumento = cmbTipoDoc.Text,
                Documento = txtDocumento.Text,
                Genero = cmbGenero.Text,
                Edad = edad,
                Telefono = txtTelefono.Text,
                correo = txtcorreo.Text
            };

            GestorRecepcionistas.ListaRecepcionista.Add(recepcionista);  // Agregar a la lista
            MessageBox.Show("Recepcionista registrado con éxito.");
            LimpiarFormulario();  // Limpiar los campos

        
        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDocumento.Clear();
            txtEdad.Clear();
            txtTelefono.Clear();
            txtcorreo.Clear();
            cmbTipoDoc.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
        }

        private void Btn_volver_recepcionista_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_prueba menuAdmin = new Form_prueba(); 
            menuAdmin.Show();
            
        }
    }
    
}
