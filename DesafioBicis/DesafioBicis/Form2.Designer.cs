namespace DesafioBicis
{
    partial class FrmRegistro
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbParticipante1 = new System.Windows.Forms.GroupBox();
            this.txtEquipo1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.gbParticipante2 = new System.Windows.Forms.GroupBox();
            this.txtEquipo2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdad2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbParticipante1.SuspendLayout();
            this.gbParticipante2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(220, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(483, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO DE PARTICIPANTES";
            // 
            // gbParticipante1
            // 
            this.gbParticipante1.Controls.Add(this.txtEquipo1);
            this.gbParticipante1.Controls.Add(this.label3);
            this.gbParticipante1.Controls.Add(this.txtEdad1);
            this.gbParticipante1.Controls.Add(this.label1);
            this.gbParticipante1.Controls.Add(this.label2);
            this.gbParticipante1.Controls.Add(this.txtNombre1);
            this.gbParticipante1.Location = new System.Drawing.Point(70, 100);
            this.gbParticipante1.Name = "gbParticipante1";
            this.gbParticipante1.Size = new System.Drawing.Size(350, 250);
            this.gbParticipante1.TabIndex = 1;
            this.gbParticipante1.TabStop = false;
            this.gbParticipante1.Text = "Participante 1";
            // 
            // txtEquipo1
            // 
            this.txtEquipo1.Location = new System.Drawing.Point(100, 140);
            this.txtEquipo1.Name = "txtEquipo1";
            this.txtEquipo1.Size = new System.Drawing.Size(220, 22);
            this.txtEquipo1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Equipo: ";
            // 
            // txtEdad1
            // 
            this.txtEdad1.Location = new System.Drawing.Point(100, 90);
            this.txtEdad1.Name = "txtEdad1";
            this.txtEdad1.Size = new System.Drawing.Size(220, 22);
            this.txtEdad1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(100, 40);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(220, 22);
            this.txtNombre1.TabIndex = 0;
            // 
            // gbParticipante2
            // 
            this.gbParticipante2.Controls.Add(this.txtEquipo2);
            this.gbParticipante2.Controls.Add(this.label6);
            this.gbParticipante2.Controls.Add(this.txtEdad2);
            this.gbParticipante2.Controls.Add(this.label5);
            this.gbParticipante2.Controls.Add(this.txtNombre2);
            this.gbParticipante2.Controls.Add(this.label4);
            this.gbParticipante2.Location = new System.Drawing.Point(520, 100);
            this.gbParticipante2.Name = "gbParticipante2";
            this.gbParticipante2.Size = new System.Drawing.Size(350, 250);
            this.gbParticipante2.TabIndex = 2;
            this.gbParticipante2.TabStop = false;
            this.gbParticipante2.Text = "Participante 2";
            // 
            // txtEquipo2
            // 
            this.txtEquipo2.Location = new System.Drawing.Point(100, 140);
            this.txtEquipo2.Name = "txtEquipo2";
            this.txtEquipo2.Size = new System.Drawing.Size(220, 22);
            this.txtEquipo2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Equipo: ";
            // 
            // txtEdad2
            // 
            this.txtEdad2.Location = new System.Drawing.Point(100, 90);
            this.txtEdad2.Name = "txtEdad2";
            this.txtEdad2.Size = new System.Drawing.Size(220, 22);
            this.txtEdad2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Edad: ";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(100, 40);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(220, 22);
            this.txtNombre2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(128, 430);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(220, 50);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Participantes";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Orange;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(385, 430);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(180, 50);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Gray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(600, 430);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(180, 50);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver al Menu";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbParticipante2);
            this.Controls.Add(this.gbParticipante1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.gbParticipante1.ResumeLayout(false);
            this.gbParticipante1.PerformLayout();
            this.gbParticipante2.ResumeLayout(false);
            this.gbParticipante2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbParticipante1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdad1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEquipo1;
        private System.Windows.Forms.GroupBox gbParticipante2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdad2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEquipo2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}