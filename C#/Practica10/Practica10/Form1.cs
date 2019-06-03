using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica10
{
    public partial class Form1 : Form
    {
        AlmacenDataContext db;
        public Form1()
        {
            InitializeComponent();

            db = new AlmacenDataContext("Data Source=localhost;Initial Catalog=almacen;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var consulta = from compra in db.compras
                           join producto in db.productos on compra.identificadorProducto equals producto.identificador
                           join cliente in db.clientes on compra.codigoCliente equals cliente.codigo
                           where cliente.codigo.Equals(txtCodigoCliente.Text)
                           select new
                           {
                               Cliente = cliente.nombre,
                               NombreProducto = producto.nombre,
                               Cantidad = compra.cantidad


                           };
            dataGridView1.DataSource = consulta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var consulta = from compra in db.compras
                           join producto in db.productos on compra.identificadorProducto equals producto.identificador
                           join cliente in db.clientes on compra.codigoCliente equals cliente.codigo
                           where cliente.codigo >= nudCodigoClienteInferior.Value && cliente.codigo <= nudCodigoClienteSuprior.Value
                           select new
                           {
                               Cliente = cliente.nombre,
                               NombreProducto = producto.nombre,
                               FechaCompra = compra.fechaHoraCompra
                           };
            dataGridView1.DataSource = consulta;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var consulta = from producto in db.productos
                           where producto.identificador >= nudCodigoProductoInferior.Value
                           && producto.identificador <= nudCodigoProductoSuperior.Value
                           && producto.precio >= nudProductoPrecioMinimo.Value
                           && producto.precio <= nudProductoPrecioMaximo.Value
                           select new
                           {
                               Producto = producto.nombre,
                               Precio = producto.precio

                           };
            dataGridView1.DataSource = consulta;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var consulta = from producto in db.productos
                           join compra in db.compras on producto.identificador equals compra.identificadorProducto
                           join cliente in db.clientes on compra.codigoCliente equals cliente.codigo
                           select new
                           {
                               Cliente = cliente.nombre,
                               ProductoId = compra.identificadorProducto,
                               Producto = producto.nombre,
                               FechaCompra = compra.fechaHoraCompra,
                               Cantidad = compra.cantidad,

                           };
            dataGridView1.DataSource = consulta;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            var consulta = from producto in db.productos
                           join compra in db.compras on producto.identificador equals compra.identificadorProducto
                           select new
                           {
                               ProductoId = compra.identificadorProducto,
                               Producto = producto.nombre,
                               FechaCompra = compra.fechaHoraCompra,
                               Cantidad = compra.cantidad
                           };
            dataGridView1.DataSource = consulta;
        }
    }
}
