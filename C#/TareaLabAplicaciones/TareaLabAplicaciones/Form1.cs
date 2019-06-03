using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaLabAplicaciones
{
    public partial class Form1 : Form
    {
        private Controller control;

        public Form1()
        {
            InitializeComponent();
            this.control = new Controller();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        //Funcion que llena el DataGridView
        private void showArtist()
        {
            List<Artist> artists = this.control.getArtists();

            dgvArtist.Rows.Clear();
            foreach (Artist a in artists)
            {
                dgvArtist.Rows.Add(a.Name,a.Company.Name,a.Sales);
            }

            dgvArtist.Visible = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void updateTextBox()
        {
            //si hay un objeto Artist mostrara los datos en los textBox
            if (this.control.Artist != null)
            {
                txtArtist.Text = this.control.Artist.Name;
                txtCompany.Text = this.control.Artist.Company.Name;
                txtSales.Text = this.control.Artist.Sales;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }else
            {
                MessageBox.Show("No se encuentra el elemento");
            }
            


        }
        //evento de btnFindArtist
        private void btnFindArtist_Click(object sender, EventArgs e)
        {
            //si no hay nada en las cajas de texto muestra un dataGridView con todos los datos
            if (txtArtist.Text=="" && txtCompany.Text=="")
            {
                //Funcion que muestra el dataGridView
                showArtist();
            }
            else
            {
                if (txtArtist.Text!="" && txtCompany.Text =="")
                {
                    //realiza la busqueda por nombre atraves del controller
                    this.control.searchArtist(txtArtist.Text);
                }
                else
                {
                    if (txtCompany.Text != null && txtArtist.Text == "")
                    {
                        //realiza la busqueda por compañia atraves del controller
                        this.control.searchArtist(new Company(txtCompany.Text,""));

                    }
                    else{
                        //realiza la busqueda por nombre y compañia atraves del controller
                        this.control.searchArtist(txtArtist.Text, new Company(txtCompany.Text, ""));
                    }
                }
                dgvArtist.Visible = false;
                //funcion que muestra los datos del artista en los TextBox
                updateTextBox();
            }
            //obtiene la instruccion Query a traves del controller
            lblQuery.Text = this.control.getQuery();

        }
        //evento de btnUpdate
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Realiza la actualizacion a traves del controller
            //Verifica las filas afectadas
            if (this.control.updateArtist(txtArtist.Text,txtCompany.Text,txtSales.Text)!=0)
            {
                MessageBox.Show("Actualizacion exitosa");
            }else
            {
                MessageBox.Show("Actualizacion fallida");
            }
            //obtiene la instruccion Query a traves del controller
            lblQuery.Text = this.control.getQuery();

        }
        //evento del boton  btnInsert
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Realiza la insercion a traves del controller
            //Verifica las filas afectadas
            if (txtArtist.Text != "" && txtCompany.Text!="" && txtSales.Text!="")
            {
                if(this.control.addArtist(txtArtist.Text,txtCompany.Text, txtSales.Text) != 0)
                {
                    //Realiza un refrescado del artista actual haciendo una busqueda a traves del controller
                    this.control.searchArtist(txtArtist.Text, new Company(txtCompany.Text, ""));
                    dgvArtist.Visible = false;
                }
                else
                {
                    MessageBox.Show("A ocurrido un error");
                }
            }else
            {
                MessageBox.Show("Acomplete los datos");
            }
            //obtiene la instruccion Query a traves del controller
            lblQuery.Text = this.control.getQuery();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            if (this.control.deleteArtist()!=0)
            {
                MessageBox.Show("Se ha eliminado con exito");
                txtArtist.ResetText();
                txtCompany.ResetText();
                txtSales.ResetText();
                dgvArtist.Visible = false;
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar");
            }
            lblQuery.Text = this.control.getQuery();
        }
    }
}
