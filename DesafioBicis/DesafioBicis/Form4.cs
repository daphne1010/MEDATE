using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DesafioBicis
{
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }
        private void CargarHistorial()
        {
            dgvHistorial.Rows.Clear();
            if (!File.Exists("historial.txt"))
                return;
            string[] lineas = File.ReadAllLines("historial.txt");
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(';');
                if (datos.Length == 5)
                {
                    dgvHistorial.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                }
            }
        }
        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarHistorial();
        }
        private void btnLimpiarHistorial_Click(object sender, EventArgs e)
        {
            File.WriteAllText("historial.txt", "");
            dgvHistorial.Rows.Clear();
            MessageBox.Show("Historial eliminado.");
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }
    }
}