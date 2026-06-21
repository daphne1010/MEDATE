using DesafioBicis.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioBicis
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre1.Text == "" || txtEdad1.Text == "" || txtEquipo1.Text == "" || txtNombre2.Text == "" || txtEdad2.Text == "" || txtEquipo2.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }
            int edad1;
            int edad2;
            if (!int.TryParse(txtEdad1.Text, out edad1))
            {
                MessageBox.Show("Edad del participante 1 incorrecta.");
                return;
            }
            if (!int.TryParse(txtEdad2.Text, out edad2))
            {
                MessageBox.Show("Edad del participante 2 incorrecta.");
                return;
            }
            DatosSistema.Participante1 = new Participante(txtNombre1.Text, edad1, txtEquipo1.Text);
            DatosSistema.Participante2 = new Participante(txtNombre2.Text, edad2, txtEquipo2.Text);
            MessageBox.Show("Participantes guardados correctamente.");
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre1.Clear();
            txtEdad1.Clear();
            txtEquipo1.Clear();
            txtNombre2.Clear();
            txtEdad2.Clear();
            txtEquipo2.Clear();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }
    }
}