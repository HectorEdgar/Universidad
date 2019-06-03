namespace TareaLabAplicaciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvArtist = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnFindArtist = new System.Windows.Forms.Button();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtxtArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuery = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblQuery);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvArtist);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnFindArtist);
            this.panel1.Controls.Add(this.txtSales);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCompany);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtArtist);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 233);
            this.panel1.TabIndex = 0;
            // 
            // dgvArtist
            // 
            this.dgvArtist.AllowUserToAddRows = false;
            this.dgvArtist.AllowUserToDeleteRows = false;
            this.dgvArtist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtArtist,
            this.dgvtxtCompany,
            this.dgvtxtSales});
            this.dgvArtist.Location = new System.Drawing.Point(23, 75);
            this.dgvArtist.Name = "dgvArtist";
            this.dgvArtist.ReadOnly = true;
            this.dgvArtist.Size = new System.Drawing.Size(359, 81);
            this.dgvArtist.TabIndex = 11;
            this.dgvArtist.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(439, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(439, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(439, 75);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnFindArtist
            // 
            this.btnFindArtist.Location = new System.Drawing.Point(439, 17);
            this.btnFindArtist.Name = "btnFindArtist";
            this.btnFindArtist.Size = new System.Drawing.Size(75, 36);
            this.btnFindArtist.TabIndex = 7;
            this.btnFindArtist.Text = "Find details of Artist";
            this.btnFindArtist.UseVisualStyleBackColor = true;
            this.btnFindArtist.Click += new System.EventHandler(this.btnFindArtist_Click);
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(282, 45);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(100, 20);
            this.txtSales.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sales";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(149, 45);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(100, 20);
            this.txtCompany.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(23, 45);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(100, 20);
            this.txtArtist.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artist";
            // 
            // dgvtxtArtist
            // 
            this.dgvtxtArtist.Frozen = true;
            this.dgvtxtArtist.HeaderText = "Artist";
            this.dgvtxtArtist.Name = "dgvtxtArtist";
            this.dgvtxtArtist.ReadOnly = true;
            // 
            // dgvtxtCompany
            // 
            this.dgvtxtCompany.Frozen = true;
            this.dgvtxtCompany.HeaderText = "Company";
            this.dgvtxtCompany.Name = "dgvtxtCompany";
            this.dgvtxtCompany.ReadOnly = true;
            // 
            // dgvtxtSales
            // 
            this.dgvtxtSales.Frozen = true;
            this.dgvtxtSales.HeaderText = "Sales";
            this.dgvtxtSales.Name = "dgvtxtSales";
            this.dgvtxtSales.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Query:";
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(14, 200);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(87, 13);
            this.lblQuery.TabIndex = 13;
            this.lblQuery.Text = "Slect * from tabla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 258);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnFindArtist;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSales;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Label label4;
    }
}

