using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5ModoDesAtendido
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter daCostumers;
        private DataSet dsCustomers;
        private DataGrid dgCustomers;
        private const String tablename = "Participantes";

        public Form1()
        {
            //InitializeComponent();
            initData();
            dgCustomers = new DataGrid();
            dgCustomers.Location = new Point(5, 5);
            //dgCustomers.Size = new Size(this.ClientRectangle.Size.Width - 10, this.ClientRectangle.Height - 50);
            dgCustomers.Size = new Size(330,150);
            dgCustomers.DataSource = dsCustomers;
            dgCustomers.DataMember = tablename;

            Button btnUpdate = new Button();
            btnUpdate.Text = "Update";
            btnUpdate.Location = new Point(150,180);
            //btnUpdate.Location = new Point(this.ClientRectangle.Width / 2 - btnUpdate.Width / 2, this.ClientRectangle.Height - (btnUpdate.Height + 10));
            btnUpdate.Click += new EventHandler(btnUpdateClicked);
            Controls.AddRange(new Control[] { dgCustomers, btnUpdate });
            this.Size = new Size(400,400);
        }

        private void btnUpdateClicked(object sender, EventArgs e)
        {
            daCostumers.Update(dsCustomers, tablename);
        }

        private void initData()
        {
            conn = new SqlConnection("Server=localhost;Database=BD_Sucarnet;Trusted_Connection=True;");

            dsCustomers = new DataSet();
            daCostumers = new SqlDataAdapter("SELECT * from Participantes", conn);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(daCostumers);
            daCostumers.Fill(dsCustomers, tablename);

        }
    }
}
