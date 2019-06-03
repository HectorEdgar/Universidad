namespace Practica10
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.nudCodigoClienteInferior = new System.Windows.Forms.NumericUpDown();
            this.nudCodigoClienteSuprior = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.nudCodigoProductoSuperior = new System.Windows.Forms.NumericUpDown();
            this.nudCodigoProductoInferior = new System.Windows.Forms.NumericUpDown();
            this.nudProductoPrecioMaximo = new System.Windows.Forms.NumericUpDown();
            this.nudProductoPrecioMinimo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoClienteInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoClienteSuprior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoProductoSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoProductoInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductoPrecioMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductoPrecioMinimo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consulta 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Consulta2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(8, 41);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCliente.TabIndex = 3;
            // 
            // nudCodigoClienteInferior
            // 
            this.nudCodigoClienteInferior.Location = new System.Drawing.Point(20, 39);
            this.nudCodigoClienteInferior.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCodigoClienteInferior.Name = "nudCodigoClienteInferior";
            this.nudCodigoClienteInferior.Size = new System.Drawing.Size(62, 20);
            this.nudCodigoClienteInferior.TabIndex = 4;
            // 
            // nudCodigoClienteSuprior
            // 
            this.nudCodigoClienteSuprior.Location = new System.Drawing.Point(20, 78);
            this.nudCodigoClienteSuprior.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudCodigoClienteSuprior.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCodigoClienteSuprior.Name = "nudCodigoClienteSuprior";
            this.nudCodigoClienteSuprior.Size = new System.Drawing.Size(68, 20);
            this.nudCodigoClienteSuprior.TabIndex = 5;
            this.nudCodigoClienteSuprior.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Consulta3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nudCodigoProductoSuperior
            // 
            this.nudCodigoProductoSuperior.Location = new System.Drawing.Point(105, 31);
            this.nudCodigoProductoSuperior.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudCodigoProductoSuperior.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCodigoProductoSuperior.Name = "nudCodigoProductoSuperior";
            this.nudCodigoProductoSuperior.Size = new System.Drawing.Size(68, 20);
            this.nudCodigoProductoSuperior.TabIndex = 8;
            this.nudCodigoProductoSuperior.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCodigoProductoInferior
            // 
            this.nudCodigoProductoInferior.Location = new System.Drawing.Point(18, 31);
            this.nudCodigoProductoInferior.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCodigoProductoInferior.Name = "nudCodigoProductoInferior";
            this.nudCodigoProductoInferior.Size = new System.Drawing.Size(62, 20);
            this.nudCodigoProductoInferior.TabIndex = 7;
            // 
            // nudProductoPrecioMaximo
            // 
            this.nudProductoPrecioMaximo.Location = new System.Drawing.Point(108, 95);
            this.nudProductoPrecioMaximo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudProductoPrecioMaximo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProductoPrecioMaximo.Name = "nudProductoPrecioMaximo";
            this.nudProductoPrecioMaximo.Size = new System.Drawing.Size(68, 20);
            this.nudProductoPrecioMaximo.TabIndex = 10;
            this.nudProductoPrecioMaximo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudProductoPrecioMinimo
            // 
            this.nudProductoPrecioMinimo.Location = new System.Drawing.Point(21, 95);
            this.nudProductoPrecioMinimo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudProductoPrecioMinimo.Name = "nudProductoPrecioMinimo";
            this.nudProductoPrecioMinimo.Size = new System.Drawing.Size(62, 20);
            this.nudProductoPrecioMinimo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codigo (Inf, sup)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Precio (Min , max)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(70, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Consulta4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(70, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Consulta5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Codigo (Inf, sup)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Codigo Cliente";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(266, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 80);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.nudCodigoClienteInferior);
            this.panel2.Controls.Add(this.nudCodigoClienteSuprior);
            this.panel2.Location = new System.Drawing.Point(266, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 123);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(266, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 80);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.nudCodigoProductoInferior);
            this.panel4.Controls.Add(this.nudCodigoProductoSuperior);
            this.panel4.Controls.Add(this.nudProductoPrecioMinimo);
            this.panel4.Controls.Add(this.nudProductoPrecioMaximo);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 176);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.txtCodigoCliente);
            this.panel5.Location = new System.Drawing.Point(12, 205);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 100);
            this.panel5.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 547);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoClienteInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoClienteSuprior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoProductoSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoProductoInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductoPrecioMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductoPrecioMinimo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.NumericUpDown nudCodigoClienteInferior;
        private System.Windows.Forms.NumericUpDown nudCodigoClienteSuprior;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown nudCodigoProductoSuperior;
        private System.Windows.Forms.NumericUpDown nudCodigoProductoInferior;
        private System.Windows.Forms.NumericUpDown nudProductoPrecioMaximo;
        private System.Windows.Forms.NumericUpDown nudProductoPrecioMinimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

