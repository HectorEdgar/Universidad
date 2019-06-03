namespace ProyectoNubiaV0._1.Formularios
{
    partial class TomaAsistencia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDiasGrupo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.btnGuardarAsistencia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.cbGrupoGimnasio = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlListaAsistencia = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlListaAsistencia.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.NombreAlumno,
            this.Asistencia});
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 485);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlInformacion);
            this.panel1.Controls.Add(this.pnlListaAsistencia);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(13, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 552);
            this.panel1.TabIndex = 2;
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.panel2);
            this.pnlInformacion.Controls.Add(this.label9);
            this.pnlInformacion.Location = new System.Drawing.Point(27, 111);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(326, 254);
            this.pnlInformacion.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblHoraInicio);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblHoraFin);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblDiasGrupo);
            this.panel2.Location = new System.Drawing.Point(-1, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 205);
            this.panel2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Días a  la semana:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(95, 86);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(0, 13);
            this.lblHoraInicio.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hora de Inicio:";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(95, 122);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(0, 13);
            this.lblHoraFin.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hora Final:";
            // 
            // lblDiasGrupo
            // 
            this.lblDiasGrupo.AutoSize = true;
            this.lblDiasGrupo.Location = new System.Drawing.Point(4, 52);
            this.lblDiasGrupo.Name = "lblDiasGrupo";
            this.lblDiasGrupo.Size = new System.Drawing.Size(0, 13);
            this.lblDiasGrupo.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Información del horario";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(46, 20);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(35, 13);
            this.lblDia.TabIndex = 9;
            this.lblDia.Text = "label3";
            // 
            // btnGuardarAsistencia
            // 
            this.btnGuardarAsistencia.Location = new System.Drawing.Point(3, 16);
            this.btnGuardarAsistencia.Name = "btnGuardarAsistencia";
            this.btnGuardarAsistencia.Size = new System.Drawing.Size(391, 23);
            this.btnGuardarAsistencia.TabIndex = 3;
            this.btnGuardarAsistencia.Text = "Tomar Asistencia";
            this.btnGuardarAsistencia.UseVisualStyleBackColor = true;
            this.btnGuardarAsistencia.Click += new System.EventHandler(this.btnGuardarAsistencia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dia: ";
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(246, 47);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarLista.TabIndex = 2;
            this.btnMostrarLista.Text = "Mostrar lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // cbGrupoGimnasio
            // 
            this.cbGrupoGimnasio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGrupoGimnasio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGrupoGimnasio.ItemHeight = 13;
            this.cbGrupoGimnasio.Location = new System.Drawing.Point(14, 49);
            this.cbGrupoGimnasio.Name = "cbGrupoGimnasio";
            this.cbGrupoGimnasio.Size = new System.Drawing.Size(207, 21);
            this.cbGrupoGimnasio.TabIndex = 1;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 10);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toma de Asistencia";
            // 
            // pnlListaAsistencia
            // 
            this.pnlListaAsistencia.Controls.Add(this.dataGridView1);
            this.pnlListaAsistencia.Controls.Add(this.btnGuardarAsistencia);
            this.pnlListaAsistencia.Location = new System.Drawing.Point(368, 3);
            this.pnlListaAsistencia.Name = "pnlListaAsistencia";
            this.pnlListaAsistencia.Size = new System.Drawing.Size(405, 536);
            this.pnlListaAsistencia.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblDia);
            this.panel4.Controls.Add(this.cbGrupoGimnasio);
            this.panel4.Controls.Add(this.btnMostrarLista);
            this.panel4.Location = new System.Drawing.Point(27, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 88);
            this.panel4.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 411);
            this.panel3.TabIndex = 19;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 75;
            // 
            // NombreAlumno
            // 
            this.NombreAlumno.HeaderText = "Nombre del alumno";
            this.NombreAlumno.Name = "NombreAlumno";
            this.NombreAlumno.ReadOnly = true;
            this.NombreAlumno.Width = 113;
            // 
            // Asistencia
            // 
            this.Asistencia.FalseValue = "Falta";
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.IndeterminateValue = "retardo";
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.TrueValue = "Asistencia";
            this.Asistencia.Width = 61;
            // 
            // TomaAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 616);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TomaAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TomaAsistenci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TomaAsistencia_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlListaAsistencia.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardarAsistencia;
        private System.Windows.Forms.ComboBox cbGrupoGimnasio;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDiasGrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlListaAsistencia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlumno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asistencia;
    }
}