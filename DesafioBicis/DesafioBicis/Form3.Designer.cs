namespace DesafioBicis
{
    partial class FrmCarrera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarrera));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelPista = new System.Windows.Forms.Panel();
            this.pbBici1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panelSalida = new System.Windows.Forms.Panel();
            this.panelMeta = new System.Windows.Forms.Panel();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.pbBici2 = new System.Windows.Forms.PictureBox();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.gpInformacion = new System.Windows.Forms.GroupBox();
            this.lblVelocidad1 = new System.Windows.Forms.Label();
            this.lblDistancia1 = new System.Windows.Forms.Label();
            this.lblVelocidad2 = new System.Windows.Forms.Label();
            this.lblDistancia2 = new System.Windows.Forms.Label();
            this.lblGanador = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.timerCarrera = new System.Windows.Forms.Timer(this.components);
            this.panelCarril1 = new System.Windows.Forms.Panel();
            this.panelCarril2 = new System.Windows.Forms.Panel();
            this.panelPista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBici1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBici2)).BeginInit();
            this.gpInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Navy;
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1182, 80);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(320, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(516, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "COMPETENCIA DE BICICLETAS";
            // 
            // panelPista
            // 
            this.panelPista.BackColor = System.Drawing.Color.LightGray;
            this.panelPista.Controls.Add(this.panelCarril2);
            this.panelPista.Controls.Add(this.panelCarril1);
            this.panelPista.Controls.Add(this.lblNombre2);
            this.panelPista.Controls.Add(this.pbBici2);
            this.panelPista.Controls.Add(this.lblNombre1);
            this.panelPista.Controls.Add(this.pbBici1);
            this.panelPista.Controls.Add(this.label1);
            this.panelPista.Controls.Add(this.lbl1);
            this.panelPista.Location = new System.Drawing.Point(70, 110);
            this.panelPista.Name = "panelPista";
            this.panelPista.Size = new System.Drawing.Size(1050, 400);
            this.panelPista.TabIndex = 2;
            // 
            // pbBici1
            // 
            this.pbBici1.Image = ((System.Drawing.Image)(resources.GetObject("pbBici1.Image")));
            this.pbBici1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbBici1.InitialImage")));
            this.pbBici1.Location = new System.Drawing.Point(100, 90);
            this.pbBici1.Name = "pbBici1";
            this.pbBici1.Size = new System.Drawing.Size(100, 60);
            this.pbBici1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBici1.TabIndex = 2;
            this.pbBici1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(955, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "META";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(50, 5);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(71, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "SALIDA";
            // 
            // panelSalida
            // 
            this.panelSalida.BackColor = System.Drawing.Color.White;
            this.panelSalida.Location = new System.Drawing.Point(270, 110);
            this.panelSalida.Name = "panelSalida";
            this.panelSalida.Size = new System.Drawing.Size(10, 400);
            this.panelSalida.TabIndex = 3;
            // 
            // panelMeta
            // 
            this.panelMeta.AutoSize = true;
            this.panelMeta.BackColor = System.Drawing.Color.Gold;
            this.panelMeta.ForeColor = System.Drawing.Color.Gold;
            this.panelMeta.Location = new System.Drawing.Point(1006, 110);
            this.panelMeta.Name = "panelMeta";
            this.panelMeta.Size = new System.Drawing.Size(20, 400);
            this.panelMeta.TabIndex = 1;
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre1.Location = new System.Drawing.Point(8, 110);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(91, 23);
            this.lblNombre1.TabIndex = 3;
            this.lblNombre1.Text = "Jugador 1";
            // 
            // pbBici2
            // 
            this.pbBici2.Image = ((System.Drawing.Image)(resources.GetObject("pbBici2.Image")));
            this.pbBici2.Location = new System.Drawing.Point(100, 250);
            this.pbBici2.Name = "pbBici2";
            this.pbBici2.Size = new System.Drawing.Size(100, 60);
            this.pbBici2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBici2.TabIndex = 4;
            this.pbBici2.TabStop = false;
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(7, 270);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(91, 23);
            this.lblNombre2.TabIndex = 5;
            this.lblNombre2.Text = "Jugador 2";
            // 
            // gpInformacion
            // 
            this.gpInformacion.Controls.Add(this.lblGanador);
            this.gpInformacion.Controls.Add(this.lblDistancia2);
            this.gpInformacion.Controls.Add(this.lblVelocidad2);
            this.gpInformacion.Controls.Add(this.lblDistancia1);
            this.gpInformacion.Controls.Add(this.lblVelocidad1);
            this.gpInformacion.Location = new System.Drawing.Point(70, 540);
            this.gpInformacion.Name = "gpInformacion";
            this.gpInformacion.Size = new System.Drawing.Size(498, 170);
            this.gpInformacion.TabIndex = 6;
            this.gpInformacion.TabStop = false;
            this.gpInformacion.Text = "Informacion de carrera";
            // 
            // lblVelocidad1
            // 
            this.lblVelocidad1.AutoSize = true;
            this.lblVelocidad1.Location = new System.Drawing.Point(20, 35);
            this.lblVelocidad1.Name = "lblVelocidad1";
            this.lblVelocidad1.Size = new System.Drawing.Size(131, 16);
            this.lblVelocidad1.TabIndex = 6;
            this.lblVelocidad1.Text = "Velocidad J1: 0 km/h";
            // 
            // lblDistancia1
            // 
            this.lblDistancia1.AutoSize = true;
            this.lblDistancia1.Location = new System.Drawing.Point(20, 70);
            this.lblDistancia1.Name = "lblDistancia1";
            this.lblDistancia1.Size = new System.Drawing.Size(107, 16);
            this.lblDistancia1.TabIndex = 7;
            this.lblDistancia1.Text = "Distancia J1: 0 m";
            // 
            // lblVelocidad2
            // 
            this.lblVelocidad2.AutoSize = true;
            this.lblVelocidad2.Location = new System.Drawing.Point(320, 35);
            this.lblVelocidad2.Name = "lblVelocidad2";
            this.lblVelocidad2.Size = new System.Drawing.Size(131, 16);
            this.lblVelocidad2.TabIndex = 8;
            this.lblVelocidad2.Text = "Velocidad J2: 0 km/h";
            // 
            // lblDistancia2
            // 
            this.lblDistancia2.AutoSize = true;
            this.lblDistancia2.Location = new System.Drawing.Point(320, 70);
            this.lblDistancia2.Name = "lblDistancia2";
            this.lblDistancia2.Size = new System.Drawing.Size(107, 16);
            this.lblDistancia2.TabIndex = 9;
            this.lblDistancia2.Text = "Distancia J2: 0 m";
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanador.Location = new System.Drawing.Point(20, 115);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(105, 28);
            this.lblGanador.TabIndex = 10;
            this.lblGanador.Text = "Ganador: ";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(794, 631);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(180, 50);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar Carrera";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Orange;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(616, 575);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(180, 50);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Gray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(973, 576);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(180, 50);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver al menu";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // timerCarrera
            // 
            this.timerCarrera.Tick += new System.EventHandler(this.timerCarrera_Tick);
            // 
            // panelCarril1
            // 
            this.panelCarril1.BackColor = System.Drawing.Color.White;
            this.panelCarril1.Location = new System.Drawing.Point(100, 170);
            this.panelCarril1.Name = "panelCarril1";
            this.panelCarril1.Size = new System.Drawing.Size(850, 3);
            this.panelCarril1.TabIndex = 6;
            // 
            // panelCarril2
            // 
            this.panelCarril2.BackColor = System.Drawing.Color.White;
            this.panelCarril2.Location = new System.Drawing.Point(100, 330);
            this.panelCarril2.Name = "panelCarril2";
            this.panelCarril2.Size = new System.Drawing.Size(850, 3);
            this.panelCarril2.TabIndex = 7;
            // 
            // FrmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.gpInformacion);
            this.Controls.Add(this.panelMeta);
            this.Controls.Add(this.panelSalida);
            this.Controls.Add(this.panelPista);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competencia de bicicletas";
            this.Load += new System.EventHandler(this.FrmCarrera_Load);
            this.panelPista.ResumeLayout(false);
            this.panelPista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBici1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBici2)).EndInit();
            this.gpInformacion.ResumeLayout(false);
            this.gpInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelPista;
        private System.Windows.Forms.Panel panelSalida;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panelMeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBici1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.PictureBox pbBici2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.GroupBox gpInformacion;
        private System.Windows.Forms.Label lblVelocidad1;
        private System.Windows.Forms.Label lblDistancia1;
        private System.Windows.Forms.Label lblVelocidad2;
        private System.Windows.Forms.Label lblDistancia2;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Timer timerCarrera;
        private System.Windows.Forms.Panel panelCarril1;
        private System.Windows.Forms.Panel panelCarril2;
    }
}