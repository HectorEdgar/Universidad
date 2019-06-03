using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica9_
{
    public partial class Form1 : Form
    {
        inventarioDataContext db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
        public Form1()
        {

            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;

        }
        //se agrega un suplier a la base de datos con los campos del formulario
        private void button5_Click(object sender, EventArgs e)
        {
            db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            suppliers supliers = new suppliers();
            supliers.suplierId = Convert.ToInt16(txtSuplierId.Text);
            supliers.phone = txtPhone.Text;
            supliers.name = txtName.Text;

            try
            {
                db.suppliers.InsertOnSubmit(supliers);
                db.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                MessageBox.Show("Registro agregado");
            }
            catch (Exception ex)
            {
                db.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues, true);
                MessageBox.Show(ex.Message);
                db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            }



        }

        //se agrega un producto a la base de datos con los campos del formulario
        private void button8_Click(object sender, EventArgs e)
        {
            db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            products producto = new products();

            producto.productoId = Convert.ToInt16(txtProductoId.Text);
            producto.productCode = txtProductCode.Text;
            producto.name = txtProductName.Text;
            producto.quantity = Convert.ToInt16(nuProductQuantity.Value);
            producto.price = nuProductPrice.Value;

            suppliers suplier = db.suppliers.Where(p => p.name == cbProductSuplier.Text).First();
            producto.supplierId = suplier.suplierId;

            try
            {
                db.products.InsertOnSubmit(producto);
                db.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                MessageBox.Show("Registro agregado");
            }
            catch (Exception ex)
            {
                db.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues, true);
                MessageBox.Show(ex.Message);
                db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            cbProductSuplier.DataSource = db.suppliers.Select(p => p.name);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;

        }

        private suppliers supplier;
        //se hace una busqueda por el nombre del supplier y se muestra en el formulario
        private void button10_Click(object sender, EventArgs e)
        {
            db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");

            try
            {
                supplier = db.suppliers.Where(p => p.name.Contains(txtSuplierActualizacionName.Text)).First();
                txtSuplierActualizacionName.Text = supplier.name;
                txtSuplierActualizacionPhone.Text = supplier.phone;
                txtSuplierActualizacionId.Text = supplier.suplierId.ToString();
                txtSuplierActualizacionPhone.Enabled = true;
                button11.Enabled = true;
                button9.Enabled = true;
            }
            catch (Exception)
            {

                txtSuplierActualizacionName.Text = "";
                txtSuplierActualizacionPhone.Text = "";
                txtSuplierActualizacionId.Text = "";
                txtSuplierActualizacionPhone.Enabled = false;
                button11.Enabled = false;
                button9.Enabled = false;
            }








        }
        //se hace una actualizacion del supplier actual con los datos del formulario y se sube a la base de datos
        private void button9_Click(object sender, EventArgs e)
        {
            db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");

            try
            {
                var actualizar = db.suppliers.Single(p => p.suplierId.Equals(txtSuplierActualizacionId.Text));
                actualizar.name = txtSuplierActualizacionName.Text;
                actualizar.phone = txtSuplierActualizacionPhone.Text;
                db.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                MessageBox.Show("Registro actualizado");

            }
            catch (Exception ex)
            {
                db.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues, true);

                MessageBox.Show(ex.Message);
                db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            }
        }

        //se elimina el supplier actual de la base de datos
        private void button11_Click(object sender, EventArgs e)
        {
            db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");

            try
            {
                var delete = db.suppliers.Single(p => p.suplierId.Equals(txtSuplierActualizacionId.Text));
                db.suppliers.DeleteOnSubmit(delete);
                db.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
                MessageBox.Show("Registro eliminado");
                button11.Enabled = false;
                button9.Enabled = false;
            }
            catch (Exception ex)
            {
                db.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues, true);

                MessageBox.Show(ex.Message);
                db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            }

        }

        private products producto;
        //se hace una busqueda por el nombre del producto y se muestra en el formulario
        private void button13_Click(object sender, EventArgs e)
        {
            db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            try
            {

                producto = db.products.Where(p => p.name.Contains(txtProductActualizacionName.Text)).First();
                txtProductActualizacionId.Text = producto.productoId.ToString();
                txtProductActualizacionCode.Text = producto.productCode.ToString();
                txtProductActualizacionName.Text = producto.name;
                txtProductActualizacionPrice.Value = Convert.ToDecimal(producto.price);
                txtProductActualizacionQuantity.Value = Convert.ToDecimal(producto.quantity);
                txtProductActualizacionSuplier.DataSource = db.suppliers.Select(p => p.name);
                txtProductActualizacionSuplier.Text = producto.suppliers.name;

                txtProductActualizacionCode.Enabled = true;

                txtProductActualizacionPrice.Enabled = true;
                txtProductActualizacionQuantity.Enabled = true;
                txtProductActualizacionSuplier.Enabled = true;


                button12.Enabled = true;
                button14.Enabled = true;



            }
            catch (Exception ex)
            {

                txtProductActualizacionId.Text = "";
                txtProductActualizacionCode.Text = "";
                txtProductActualizacionName.Text = "";
                txtProductActualizacionPrice.Value = 0.0m;
                txtProductActualizacionQuantity.Value = 0.0m;
                txtProductActualizacionSuplier.DataSource = null;
                txtProductActualizacionSuplier.Text = "";

                txtProductActualizacionCode.Enabled = false;

                txtProductActualizacionPrice.Enabled = false;
                txtProductActualizacionQuantity.Enabled = false;
                txtProductActualizacionSuplier.Enabled = false;

                button12.Enabled = true;
                button14.Enabled = true;


                db.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues, true);

                MessageBox.Show(ex.Message);
                db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            }

        }

        //Se actualiza el producto actual con los datos del formulario y se sube a la base de datos
        private void button14_Click(object sender, EventArgs e)
        {
            db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            try
            {
                var actualizarProducto = db.products.Where(p => p.productoId == Convert.ToInt16(txtProductActualizacionId.Text)).Single();

                actualizarProducto.productCode = txtProductActualizacionCode.Text;
                actualizarProducto.name = txtProductActualizacionName.Text;
                actualizarProducto.price = txtProductActualizacionPrice.Value;
                actualizarProducto.quantity = Convert.ToInt16(txtProductActualizacionQuantity.Value);
                actualizarProducto.supplierId = db.suppliers.Where(p => p.name.Equals(txtProductActualizacionSuplier.Text)).Select(p => p.suplierId).Single();
                actualizarProducto.suppliers = db.suppliers.Where(p => p.name.Equals(txtProductActualizacionSuplier.Text)).Single();
                db.SubmitChanges(ConflictMode.ContinueOnConflict);
                MessageBox.Show("Registro actualizado");

            }
            catch (Exception ex)
            {

                db.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues, true);

                MessageBox.Show(ex.Message);
                db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            }
        }

        //Se elimina el producto actual de la base de datos
        private void button12_Click(object sender, EventArgs e)
        {
            db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            try
            {
                var eliminarProducto = db.products.Where(p => p.productoId == Convert.ToInt16(txtProductActualizacionId.Text)).Single();
                db.products.DeleteOnSubmit(eliminarProducto);
                db.SubmitChanges(ConflictMode.ContinueOnConflict);


                MessageBox.Show("Registro eliminado");
                txtProductActualizacionId.Text = "";
                txtProductActualizacionCode.Text = "";
                txtProductActualizacionName.Text = "";
                txtProductActualizacionPrice.Value = 0.0m;
                txtProductActualizacionQuantity.Value = 0.0m;
                txtProductActualizacionSuplier.DataSource = null;
                txtProductActualizacionSuplier.Text = "";
                button12.Enabled = false;
                button14.Enabled = false;
                txtProductActualizacionCode.Enabled = false;

                txtProductActualizacionPrice.Enabled = false;
                txtProductActualizacionQuantity.Enabled = false;
                txtProductActualizacionSuplier.Enabled = false;
            }
            catch (Exception ex)
            {

                db.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues, true);

                MessageBox.Show(ex.Message);
                db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            }




        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel8.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            db = new inventarioDataContext("Data Source=localhost;Initial Catalog=inventario;Integrated Security=True");
            panel1.Visible = false;
            panel8.Visible = true;

            dataGridView1.DataSource = db.products;
            dataGridView1.Columns["suppliers"].Visible = false;
            
            dataGridView2.DataSource = db.suppliers;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel4.Visible = true;
        }
    }
}
