using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7
{
    public partial class Form1 : Form
    {

        DataClasses1DataContext db = new DataClasses1DataContext("Data Source=EDGAR;Initial Catalog=mventas;Integrated Security=True");
        artist art;
        company comp;
        List<company> comps;
        List<artist> arts;
        delegate void funcion();
        delegate bool funcion2(String s);

        funcion2 fun2;
        public Form1()
        {
            InitializeComponent();
            art = new artist();
            comp = new company();
            panel1.Visible = false;
            panel2.Visible = false;
            dataGridView1.DataSource = db.artist;
            dataGridView2.DataSource = db.company;
        }

        

        private void limpiarElementos()
        {
            txtArtisSales.ResetText();
            txtArtistName.ResetText();
            txtCompanyName.ResetText();
            txtCompanyLocation.ResetText();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            fun2 = (string s) => s.Length != 0 || s != "";
            if (fun2(txtCompanyName.Text) && fun2(txtCompanyLocation.Text))
            {
                try
                {

                    funcion func = () =>
                    {
                        company compa = new company();
                        compa.compName = txtCompanyName.Text;
                        compa.location = txtCompanyLocation.Text;

                        comps.Add(compa);

                        dataGridView2.DataSource = null;
                        dataGridView2.DataSource = comps;
                    };
                    func();



                }
                catch (Exception ex)
                {


                    MessageBox.Show("error: " + ex.StackTrace);
                    MessageBox.Show("error: " + ex.Message);


                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            fun2 = (string s) => s.Length != 0 || s != "";
            if (fun2(txtArtisSales.Text) && fun2(txtArtistName.Text) && fun2(cbCompanyName.Text))
            {
                try
                {
                    funcion func = () =>
                    {
                        art = new artist();
                        art.artName = txtArtistName.Text;
                        art.company = cbCompanyName.Text;
                        art.sales = txtArtisSales.Text;

                        arts.Add(art);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = arts;
                    };
                    func();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los datos");
            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext("Data Source=EDGAR;Initial Catalog=mventas;Integrated Security=True");
            dataGridView1.DataSource = db.artist;
            dataGridView1.Columns["company1"].Visible = false;
            arts = new List<artist>();
            List<String> nombesCompañias = new List<string>();

            foreach (company c in (from c in db.company select c))
            {
                nombesCompañias.Add(c.compName);
            }
            cbCompanyName.DataSource = nombesCompañias;
            limpiarElementos();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext("Data Source=EDGAR;Initial Catalog=mventas;Integrated Security=True");
            dataGridView2.DataSource = db.company;
            
            
            comps = new List<company>();
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        delegate void funcion3(company comp);
        private void button7_Click(object sender, EventArgs e)
        {
            int i = 1;
            funcion3 func = (company c) =>
            {
                try
                {
                    db.company.InsertOnSubmit(c);
                    db.SubmitChanges();
                    MessageBox.Show("Registro agregado \nFila" + i++);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error " + ex.Message + "fila " + i++);
                }

            };
            foreach (company comp in comps)
            {
                func(comp);
            }
        }

        delegate void funcion4(artist a);
        private void button8_Click(object sender, EventArgs e)
        {            
            int i = 1;
            funcion4 func = (artist a) =>
            {
                try
                {
                    db.artist.InsertOnSubmit(a);
                    db.SubmitChanges();
                    MessageBox.Show("Registro agregado \nFila" + i++);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message + "fila " + i++);
                }
            };
            foreach (artist art in arts)
            {
                func(art);
            }
        }
    }
}
