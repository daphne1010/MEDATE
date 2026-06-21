namespace DesafioBicis
{
    partial class FrmHistorial
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
            this.panelLineal = new System.Windows.Forms.Panel();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParticipante1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParticipante2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGanador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiarHistorial = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(260, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(419, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HISTORIAL DE CARRERAS";
            // 
            // panelLineal
            // 
            this.panelLineal.BackColor = System.Drawing.Color.DarkBlue;
            this.panelLineal.Location = new System.Drawing.Point(210, 70);
            this.panelLineal.Name = "panelLineal";
            this.panelLineal.Size = new System.Drawing.Size(500, 3);
            this.panelLineal.TabIndex = 1;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colParticipante1,
            this.colParticipante2,
            this.colGanador,
            this.colTiempo});
            this.dgvHistorial.Location = new System.Drawing.Point(50, 100);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(850, 350);
            this.dgvHistorial.TabIndex = 2;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 20F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colParticipante1
            // 
            this.colParticipante1.FillWeight = 25F;
            this.colParticipante1.HeaderText = "Participante 1";
            this.colParticipante1.MinimumWidth = 6;
            this.colParticipante1.Name = "colParticipante1";
            this.colParticipante1.ReadOnly = true;
            // 
            // colParticipante2
            // 
            this.colParticipante2.FillWeight = 25F;
            this.colParticipante2.HeaderText = "Participante 2";
            this.colParticipante2.MinimumWidth = 6;
            this.colParticipante2.Name = "colParticipante2";
            this.colParticipante2.ReadOnly = true;
            // 
            // colGanador
            // 
            this.colGanador.FillWeight = 20F;
            this.colGanador.HeaderText = "Ganador";
            this.colGanador.MinimumWidth = 6;
            this.colGanador.Name = "colGanador";
            this.colGanador.ReadOnly = true;
            // 
            // colTiempo
            // 
            this.colTiempo.FillWeight = 10F;
            this.colTiempo.HeaderText = "Tiempo";
            this.colTiempo.MinimumWidth = 6;
            this.colTiempo.Name = "colTiempo";
            this.colTiempo.ReadOnly = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Location = new System.Drawing.Point(50, 470);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(285, 23);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Resultados guardados en el historial";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(180, 530);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 50);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiarHistorial
            // 
            this.btnLimpiarHistorial.BackColor = System.Drawing.Color.Orange;
            this.btnLimpiarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarHistorial.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarHistorial.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarHistorial.Location = new System.Drawing.Point(390, 530);
            this.btnLimpiarHistorial.Name = "btnLimpiarHistorial";
            this.btnLimpiarHistorial.Size = new System.Drawing.Size(180, 50);
            this.btnLimpiarHistorial.TabIndex = 5;
            this.btnLimpiarHistorial.Text = "Limpiar historial";
            this.btnLimpiarHistorial.UseVisualStyleBackColor = false;
            this.btnLimpiarHistorial.Click += new System.EventHandler(this.btnLimpiarHistorial_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Gray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(600, 530);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(180, 50);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver al menu";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiarHistorial);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.panelLineal);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Carreras";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelLineal;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParticipante1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParticipante2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGanador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiarHistorial;
        private System.Windows.Forms.Button btnVolver;
    }
}