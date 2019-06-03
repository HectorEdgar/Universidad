using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Agregar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //se crea dos objetos StreamReader y StreamWriter  para obtener los datos de un archivo. 
        //Luego lo que obtenemos  lo parseamos a un int y lo asignamos a un contador, al contador 
        //le sumamos uno y escribimos el contador en el archivo.
        if (File.Exists(Server.MapPath(".") + "/numRegistros.txt"))
        {
            StreamReader sr = new StreamReader(this.Server.MapPath(".") + "/numRegistros.txt");
            string valor = sr.ReadToEnd();
            int contador = int.Parse(valor);

            sr.Close();
            StreamWriter sw = new StreamWriter(Server.MapPath(".") + "/numRegistros.txt");
            sw.WriteLine(contador.ToString());
            sw.Close();
            Label2.Text = contador.ToString();
        }
        else {
            StreamWriter sr = new StreamWriter(Server.MapPath(".") + "/numRegistros.txt");
            sr.WriteLine("0");
            sr.Close();
            this.Label2.Text = "0";
        }

        //se crea dos objetos StreamReader y StreamWriter  StreamReader  con la fecha como nombre para obtener los datos de un archivo. 
        //Luego lo que obtenemos  lo parseamos a un int y lo asignamos a un contador, al contador 
        //le sumamos uno y escribimos el contador en el archivo.

        String fecha = DateTime.Now.Day.ToString() +
            DateTime.Now.Month.ToString() +
            DateTime.Now.Year.ToString();

        if (File.Exists(Server.MapPath(".") + "/"+fecha+"_numRegistros.txt"))
        {
            StreamReader sr = new StreamReader(Server.MapPath(".") + "/" + fecha + "_numRegistros.txt");
            string valor = sr.ReadToEnd();
            int contador = int.Parse(valor);
  
            sr.Close();
            StreamWriter sw = new StreamWriter(Server.MapPath(".") + "/" + fecha + "_numRegistros.txt");
            sw.WriteLine(contador.ToString());
            sw.Close();
            
        }
        else {
            StreamWriter sr = new StreamWriter(Server.MapPath(".") + "/" + fecha + "_numRegistros.txt");
            sr.WriteLine("0");
            sr.Close();
            
        }
    }


    //Evento del boton Click en el que se crea un objeto StreamWriter y se guardan los datos en 
    //un archivo de texto nombrado con la fecha de hoy y guarda los datos obtenidos del formulario.
    //Tambien obtiene el numero de registros y los guarda en un archivo;
    protected void Button1_Click(object sender, EventArgs e)
    {
        String fecha = DateTime.Now.Day.ToString() +
            DateTime.Now.Month.ToString() +
            DateTime.Now.Year.ToString();
        
        StreamWriter arch = new StreamWriter(Server.MapPath(".") + "/"+fecha+"_Curriculums.txt", true);
        arch.WriteLine("Nombre: " + TextBox1.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Direccion: " + TextBox2.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Telefono: " + TextBox3.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Email: " + TextBox4.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Lugar y Fecha de Nacimiento: " + TextBox5.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Estado Civil: " + TextBox6.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Nacionalidad: " + TextBox7.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Edad: " + TextBox8.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Peso: " + TextBox9.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Primaria: " + TextBox10.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Secundaria: " + TextBox11.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Preparatoria: " + TextBox12.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Licenciatura: " + TextBox13.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Postgrado: " + TextBox14.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("Maestria: " + TextBox15.Text);
        arch.WriteLine("<br>");
        arch.WriteLine("<br>");
        arch.WriteLine("<hr>");
        arch.Close();
        Label1.Text = "Datos Registrados";

        //se crea dos objetos StreamReader y StreamWriter  para obtener los datos de un archivo. 
        //Luego lo que obtenemos  lo parseamos a un int y lo asignamos a un contador, al contador 
        //le sumamos uno y escribimos el contador en el archivo.

        StreamReader sr = new StreamReader(this.Server.MapPath(".") + "/numRegistros.txt");
            string valor = sr.ReadToEnd();
            int contador = int.Parse(valor);
            contador++;
            sr.Close();
            StreamWriter sw = new StreamWriter(Server.MapPath(".") + "/numRegistros.txt");
            sw.WriteLine(contador.ToString());
        Label2.Text = contador.ToString();
            sw.Close();
            

        //se crea dos objetos StreamReader y StreamWriter  StreamReader  con la fecha como nombre para obtener los datos de un archivo. 
        //Luego lo que obtenemos  lo parseamos a un int y lo asignamos a un contador, al contador 
        //le sumamos uno y escribimos el contador en el archivo.
        StreamReader sr2 = new StreamReader(Server.MapPath(".") + "/" + fecha + "_numRegistros.txt");
        string valor2 = sr2.ReadToEnd();
        int contador2 = int.Parse(valor2);
        contador2++;
        sr2.Close();
        StreamWriter sw2 = new StreamWriter(Server.MapPath(".") + "/" + fecha + "_numRegistros.txt");
        sw2.WriteLine(contador2.ToString());
        sw2.Close();
        


    }


}