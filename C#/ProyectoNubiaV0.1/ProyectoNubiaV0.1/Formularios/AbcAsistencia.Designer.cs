namespace ProyectoNubiaV0._1.Formularios
{
    partial class AbcAsistencia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEditarAsistencia = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAsistencia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFecha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarAsistencia = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.pnlEditarAsistencia.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlEditarAsistencia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 387);
            this.panel1.TabIndex = 0;
            // 
            // pnlEditarAsistencia
            // 
            this.pnlEditarAsistencia.Controls.Add(this.txtNombreAlumno);
            this.pnlEditarAsistencia.Controls.Add(this.label5);
            this.pnlEditarAsistencia.Controls.Add(this.panel3);
            this.pnlEditarAsistencia.Controls.Add(this.label2);
            this.pnlEditarAsistencia.Controls.Add(this.cbFecha);
            this.pnlEditarAsistencia.Location = new System.Drawing.Point(40, 150);
            this.pnlEditarAsistencia.Name = "pnlEditarAsistencia";
            this.pnlEditarAsistencia.Size = new System.Drawing.Size(319, 234);
            this.pnlEditarAsistencia.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbAsistencia);
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 142);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Asistencia";
            // 
            // cbAsistencia
            // 
            this.cbAsistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsistencia.FormattingEnabled = true;
            this.cbAsistencia.Items.AddRange(new object[] {
            "Asistencia",
            "Falta"});
            this.cbAsistencia.Location = new System.Drawing.Point(152, 23);
            this.cbAsistencia.Name = "cbAsistencia";
            this.cbAsistencia.Size = new System.Drawing.Size(161, 21);
            this.cbAsistencia.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha: ";
            // 
            // cbFecha
            // 
            this.cbFecha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFecha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFecha.FormattingEnabled = true;
            this.cbFecha.Location = new System.Drawing.Point(152, 59);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(164, 21);
            this.cbFecha.TabIndex = 0;
            this.cbFecha.SelectedIndexChanged += new System.EventHandler(this.cbFecha_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Editar Asistencia";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtBuscar);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnBuscarAsistencia);
            this.panel4.Location = new System.Drawing.Point(40, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 303);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Buscar por matrícula";
            // 
            // btnBuscarAsistencia
            // 
            this.btnBuscarAsistencia.Location = new System.Drawing.Point(241, 38);
            this.btnBuscarAsistencia.Name = "btnBuscarAsistencia";
            this.btnBuscarAsistencia.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAsistencia.TabIndex = 1;
            this.btnBuscarAsistencia.Text = "Buscar";
            this.btnBuscarAsistencia.UseVisualStyleBackColor = true;
            this.btnBuscarAsistencia.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(313, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre del alumno:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Enabled = false;
            this.txtNombreAlumno.Location = new System.Drawing.Point(152, 15);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(164, 20);
            this.txtNombreAlumno.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBuscar.FormattingEnabled = true;
            this.txtBuscar.Location = new System.Drawing.Point(16, 39);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(206, 21);
            this.txtBuscar.TabIndex = 1;
            // 
            // AbcAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 406);
            this.Controls.Add(this.panel1);
            this.Name = "AbcAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbcAsistencia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AbcAsistencia_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEditarAsistencia.ResumeLayout(false);
            this.pnlEditarAsistencia.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlEditarAsistencia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAsistencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarAsistencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.ComboBox txtBuscar;
    }
}