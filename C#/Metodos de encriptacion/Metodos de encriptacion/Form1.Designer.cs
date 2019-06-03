namespace Metodos_de_encriptacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlPolybios = new System.Windows.Forms.Panel();
            this.pnlCesar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCesarEncriptar = new System.Windows.Forms.RichTextBox();
            this.txtCesarEncriptado = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEncriptarCesar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlMenuPrincipal.SuspendLayout();
            this.pnlPolybios.SuspendLayout();
            this.pnlCesar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metodos de encriptacion:";
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.Controls.Add(this.button2);
            this.pnlMenuPrincipal.Controls.Add(this.button1);
            this.pnlMenuPrincipal.Controls.Add(this.label1);
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(186, 184);
            this.pnlMenuPrincipal.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cesar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Polybios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnlPolybios
            // 
            this.pnlPolybios.Controls.Add(this.button3);
            this.pnlPolybios.Controls.Add(this.label6);
            this.pnlPolybios.Controls.Add(this.label7);
            this.pnlPolybios.Controls.Add(this.richTextBox2);
            this.pnlPolybios.Controls.Add(this.richTextBox3);
            this.pnlPolybios.Controls.Add(this.label8);
            this.pnlPolybios.Location = new System.Drawing.Point(239, 12);
            this.pnlPolybios.Name = "pnlPolybios";
            this.pnlPolybios.Size = new System.Drawing.Size(773, 337);
            this.pnlPolybios.TabIndex = 2;
            // 
            // pnlCesar
            // 
            this.pnlCesar.Controls.Add(this.btnEncriptarCesar);
            this.pnlCesar.Controls.Add(this.label5);
            this.pnlCesar.Controls.Add(this.label4);
            this.pnlCesar.Controls.Add(this.txtCesarEncriptado);
            this.pnlCesar.Controls.Add(this.txtCesarEncriptar);
            this.pnlCesar.Controls.Add(this.label3);
            this.pnlCesar.Location = new System.Drawing.Point(22, 389);
            this.pnlCesar.Name = "pnlCesar";
            this.pnlCesar.Size = new System.Drawing.Size(783, 343);
            this.pnlCesar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Metodo de encriptacion :  Cesar";
            // 
            // txtCesarEncriptar
            // 
            this.txtCesarEncriptar.AcceptsTab = true;
            this.txtCesarEncriptar.Location = new System.Drawing.Point(21, 63);
            this.txtCesarEncriptar.Name = "txtCesarEncriptar";
            this.txtCesarEncriptar.Size = new System.Drawing.Size(721, 104);
            this.txtCesarEncriptar.TabIndex = 5;
            this.txtCesarEncriptar.Text = "Escriba aqui el texto a encriptar";
            this.txtCesarEncriptar.Click += new System.EventHandler(this.txtCesarEncriptar_Click);
            // 
            // txtCesarEncriptado
            // 
            this.txtCesarEncriptado.Location = new System.Drawing.Point(21, 198);
            this.txtCesarEncriptado.Name = "txtCesarEncriptado";
            this.txtCesarEncriptado.ReadOnly = true;
            this.txtCesarEncriptado.Size = new System.Drawing.Size(721, 104);
            this.txtCesarEncriptado.TabIndex = 6;
            this.txtCesarEncriptado.Text = "Aqui aparecera el texto encriptado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Texto a encriptar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Texto encriptado";
            // 
            // btnEncriptarCesar
            // 
            this.btnEncriptarCesar.Enabled = false;
            this.btnEncriptarCesar.Location = new System.Drawing.Point(667, 14);
            this.btnEncriptarCesar.Name = "btnEncriptarCesar";
            this.btnEncriptarCesar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptarCesar.TabIndex = 9;
            this.btnEncriptarCesar.Text = "Encriptar";
            this.btnEncriptarCesar.UseVisualStyleBackColor = true;
            this.btnEncriptarCesar.Click += new System.EventHandler(this.btnEncriptarCesar_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(666, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Encriptar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Texto encriptado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Texto a encriptar";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(20, 206);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(721, 104);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "Aqui aparecera el texto encriptado";
            // 
            // richTextBox3
            // 
            this.richTextBox3.AcceptsTab = true;
            this.richTextBox3.Location = new System.Drawing.Point(20, 71);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(721, 104);
            this.richTextBox3.TabIndex = 11;
            this.richTextBox3.Text = "Escriba aqui el texto a encriptar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Metodo de encriptacion :  Polybios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 757);
            this.Controls.Add(this.pnlCesar);
            this.Controls.Add(this.pnlPolybios);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMenuPrincipal.ResumeLayout(false);
            this.pnlMenuPrincipal.PerformLayout();
            this.pnlPolybios.ResumeLayout(false);
            this.pnlPolybios.PerformLayout();
            this.pnlCesar.ResumeLayout(false);
            this.pnlCesar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMenuPrincipal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlPolybios;
        private System.Windows.Forms.Panel pnlCesar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtCesarEncriptar;
        private System.Windows.Forms.Button btnEncriptarCesar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtCesarEncriptado;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label8;
    }
}

