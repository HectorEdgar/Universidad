using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practia8
{
    public partial class Form1 : Form
    {

        veterinariaBdDataContext db = new veterinariaBdDataContext("Data Source=localhost;Initial Catalog=veterinaria;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            
            comboBox1.DataSource = db.mascota.Select(p => p.species).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var mascotas = from mascota in db.mascota where mascota.name.Contains(textBox1.Text) select mascota;

            IEnumerable<mascota> mascotas = db.mascota.ToList().Where(p => p.name.StartsWith(textBox1.Text));
            dataGridView1.DataSource = mascotas.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //var mascotas = from mascota in db.mascota where mascota.name == textBox2.Text select mascota;
            
            IEnumerable<mascota> mascotas = db.mascota.ToList().Where(p => p.name == textBox2.Text);
            dataGridView1.DataSource = mascotas.ToList();
            dataGridView1.Columns["owner"].Visible = false;
            dataGridView1.Columns["sex"].Visible = false;
            dataGridView1.Columns["name"].Visible = false;
            dataGridView1.Columns["death"].Visible = false;
            dataGridView1.Columns["species"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var mascotas = from mascota in db.mascota orderby mascota.name ascending select mascota;
            
            IEnumerable<mascota> mascotas = db.mascota.ToList().OrderBy(p => p.name);
            dataGridView1.DataSource = mascotas.ToList();
            dataGridView1.Columns["owner"].Visible = false;
            dataGridView1.Columns["sex"].Visible = false;
            dataGridView1.Columns["birth"].Visible = false;
            dataGridView1.Columns["death"].Visible = false;
            dataGridView1.Columns["species"].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var mascotas = from mascota in db.mascota orderby mascota.name descending select mascota;
            
            IEnumerable<mascota> mascotas = db.mascota.ToList().OrderByDescending(p => p.name);
            dataGridView1.DataSource = mascotas.ToList();
            dataGridView1.Columns["owner"].Visible = false;
            dataGridView1.Columns["sex"].Visible = false;
            dataGridView1.Columns["birth"].Visible = false;
            dataGridView1.Columns["death"].Visible = false;
            dataGridView1.Columns["species"].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //var mascotas = from mascota in db.mascota where mascota.owner == textBox3.Text  select mascota;
            
            IEnumerable<mascota> mascotas = db.mascota.ToList().Where(p => p.owner == textBox3.Text);
            dataGridView1.DataSource = mascotas.ToList();
            dataGridView1.Columns["owner"].Visible = false;
            dataGridView1.Columns["birth"].Visible = false;
            dataGridView1.Columns["death"].Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //var mascotas = from mascota in db.mascota orderby mascota.birth ascending select mascota;
            
            IEnumerable<mascota> mascotas = db.mascota.ToList().OrderBy(p => p.birth);
            dataGridView1.DataSource = mascotas.ToList();
            dataGridView1.Columns["owner"].Visible = false;
            dataGridView1.Columns["birth"].Visible = false;
            dataGridView1.Columns["death"].Visible = false;
            dataGridView1.Columns["species"].Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            IEnumerable<mascota> mascotas = db.mascota.ToList().Where(p => p.species.StartsWith(textBox4.Text));
            dataGridView1.DataSource = mascotas.ToList();
            dataGridView1.Columns["owner"].Visible = false;
            dataGridView1.Columns["species"].Visible = false;
            dataGridView1.Columns["sex"].Visible = false;




        }

        private void button8_Click(object sender, EventArgs e)
        {

            IQueryable<mascota> lista = from a in db.mascota select a;
            List<mascota> listaMascotas = lista.ToList();

            int conteo1 = listaMascotas.Count();
            int conteo2 = listaMascotas.Count(p => p.species == "dog");
            int conteo3 = listaMascotas.Count(p => p.species == "bird");
            int conteo4 = listaMascotas.Count(p => p.species == "cat");
            int conteo5 = listaMascotas.Count(p => p.species == "snake");
            List<String> conteos = new List<String>();
            conteos.Add("total =" + conteo1.ToString());
            conteos.Add("dog =" + conteo2.ToString());
            conteos.Add("bird =" + conteo3.ToString());
            conteos.Add("cat =" + conteo4.ToString());
            conteos.Add("snake =" + conteo5.ToString());
            listBox1.DataSource = conteos;
        }

        //public delegate TResult Func<T1,TResult>();
        private void button9_Click(object sender, EventArgs e)
        {
            var lista = from m in db.mascota select m;
            List<mascota> listaMascotas = lista.ToList();

            Func<String, int, IEnumerable<mascota>> muestra =(especie, numeroletras) =>
            {
                IEnumerable<mascota> masc = listaMascotas.Where(p => p.species == especie);
                return masc.Where(p => p.name.Count() == numeroletras).Where(p => p.species == especie);
               

            };
            IEnumerable<mascota> mascotas = muestra(comboBox1.Text,(int)numericUpDown1.Value);
            dataGridView1.DataSource = mascotas.ToList();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Func<string, IEnumerable<mascota>> inc = delegate (string var1)
            {
                List<mascota> lista = db.mascota.ToList();                 
                return lista.Where(n => n.owner.StartsWith(var1)); 
            };

            IEnumerable<mascota> mascotas = inc(textBox8.Text);
            dataGridView1.DataSource = mascotas.ToList();

            dataGridView1.Columns["owner"].Visible = false;
            dataGridView1.Columns["species"].Visible = true;
            dataGridView1.Columns["sex"].Visible = false;
            dataGridView1.Columns["birth"].Visible = false;
            dataGridView1.Columns["death"].Visible = false;
        }




        private void button11_Click(object sender, EventArgs e)
        {
            
            char genero = Convert.ToChar(textBox5.Text);
            string especie = textBox6.Text;
            DateTime fechaNacimiento = DateTime.Parse(textBox7.Text);

            Func<char, string, DateTime, IEnumerable<mascota>> inc = delegate (char sex, string specie, DateTime birth)
            {
                List<mascota> lista = db.mascota.ToList();
                
                return lista.Where(n => n.species == specie && n.sex == sex && n.birth == birth);
            };

            IEnumerable<mascota> mascotas = inc(genero, especie, fechaNacimiento);
            dataGridView1.DataSource = mascotas.ToList();
            
        }

    }
}
