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
    public partial class FrmCarrera : Form
    {
        Random random = new Random();
        int velocidad1 = 0;
        int velocidad2 = 0;
        int distancia1 = 0;
        int distancia2 = 0;
        bool carreraTerminada = false;
        public FrmCarrera()
        {
            InitializeComponent();
        }
        private void FrmCarrera_Load(object sender, EventArgs e)
        {
            if (DatosSistema.Participante1 != null)
                lblNombre1.Text = DatosSistema.Participante1.Nombre;
            if (DatosSistema.Participante2 != null)
                lblNombre2.Text = DatosSistema.Participante2.Nombre;
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            carreraTerminada = false;
            timerCarrera.Start();
        }
        private void timerCarrera_Tick(object sender, EventArgs e)
        {
            velocidad1 = random.Next(10, 30);
            velocidad2 = random.Next(10, 30);
            distancia1 += velocidad1;
            distancia2 += velocidad2;
            lblVelocidad1.Text = "Velocidad J1: " + velocidad1 + " km/h";
            lblVelocidad2.Text = "Velocidad J2: " + velocidad2 + " km/h";
            lblDistancia1.Text = "Distancia J1: " + distancia1 + " m";
            lblDistancia2.Text = "Distancia J2: " + distancia2 + " m";
            pbBici1.Left += velocidad1;
            pbBici2.Left += velocidad2;
            if (!carreraTerminada)
            {
                if (pbBici1.Right >= panelMeta.Left)
                {
                    carreraTerminada = true;
                    timerCarrera.Stop();
                    lblGanador.Text = "Ganador: " + DatosSistema.Participante1.Nombre;
                    Historial historial = new Historial();
                    historial.GuardarCarrera(DatosSistema.Participante1.Nombre, DatosSistema.Participante2.Nombre, DatosSistema.Participante1.Nombre, distancia1 + " m");
                    MessageBox.Show("Ganó " + DatosSistema.Participante1.Nombre);
                }
                if (pbBici2.Right >= panelMeta.Left)
                {
                    carreraTerminada = true;
                    timerCarrera.Stop();
                    lblGanador.Text = "Ganador: " + DatosSistema.Participante2.Nombre;
                    Historial historial = new Historial();
                    historial.GuardarCarrera(DatosSistema.Participante1.Nombre, DatosSistema.Participante2.Nombre, DatosSistema.Participante2.Nombre, distancia2 + " m");
                    MessageBox.Show("Ganó " + DatosSistema.Participante2.Nombre);
                }
            }
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timerCarrera.Stop();
            pbBici1.Left = 100;
            pbBici2.Left = 100;
            velocidad1 = 0;
            velocidad2 = 0;
            distancia1 = 0;
            distancia2 = 0;
            lblVelocidad1.Text = "Velocidad J1: 0 km/h";
            lblVelocidad2.Text = "Velocidad J2: 0 km/h";
            lblDistancia1.Text = "Distancia J1: 0 m";
            lblDistancia2.Text = "Distancia J2: 0 m";
            lblGanador.Text = "Ganador: ---";
            carreraTerminada = false;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }
    }
}