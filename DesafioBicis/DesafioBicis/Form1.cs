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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistro frm = new FrmRegistro();
            frm.Show();
            this.Hide();
        }
        private void btnCarrera_Click(object sender, EventArgs e)
        {
            FrmCarrera frm = new FrmCarrera();
            frm.Show();
            this.Hide();
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frm = new FrmHistorial();
            frm.Show();
            this.Hide();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}