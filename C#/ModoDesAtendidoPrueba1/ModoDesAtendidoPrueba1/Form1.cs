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

namespace ModoDesAtendidoPrueba1
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter daCostumers;
        private DataSet dsCustomers;
        private DataGrid dgCustomers;
        private const String tablename = "Customers";

        public Form1()
        {
            //InitializeComponent();
            initData();
            dgCustomers = new DataGrid();
            dgCustomers.Location = new Point(5,5);
            dgCustomers.Size = new Size(this.ClientRectangle.Size.Width-10,this.ClientRectangle.Height-50);
            dgCustomers.DataSource = dsCustomers;
            dgCustomers.DataMember = tablename;

            Button btnUpdate = new Button();
            btnUpdate.Text = "Update";
            btnUpdate.Location = new Point(this.ClientRectangle.Width/2-btnUpdate.Width/2,this.ClientRectangle.Height-(btnUpdate.Height+10));
            btnUpdate.Click += new EventHandler(btnUpdateClicked);
            Controls.AddRange(new Control[] { dgCustomers, btnUpdate});
        }

        private void btnUpdateClicked(object sender, EventArgs e)
        {
            daCostumers.Update(dsCustomers,tablename);
        }

        private void initData()
        {
            conn = new SqlConnection("Server=localhost;Database=Prueba;Trusted_Connection=True;");

            dsCustomers = new DataSet();
            daCostumers = new SqlDataAdapter("SELECT customerId,companyName from customers",conn);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(daCostumers);
            daCostumers.Fill(dsCustomers,tablename);

        }
    }
}
