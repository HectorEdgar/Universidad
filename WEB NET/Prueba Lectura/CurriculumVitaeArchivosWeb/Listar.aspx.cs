using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Listar : System.Web.UI.Page
{
    //En el evento de carga del Web Form se crea un objeto de tipo StreamReader especificando la ruta del archivo con la fecha actual
    //y se leen los datos contenidos en el archivo y se le asignan al label 
    //tambien se le asignan a los otros label el numero total de registros ,el numero total de registros por fecha y la fecha correspondiente
    protected void Page_Load(object sender, EventArgs e)
    {
        String fecha = DateTime.Now.Day.ToString() +
          DateTime.Now.Month.ToString() +
          DateTime.Now.Year.ToString();
        if (File.Exists(Server.MapPath(".") + "/" + fecha + "_Curriculums.txt"))
        {
            StreamReader arch = new StreamReader(Server.MapPath(".") + "/" + fecha + "_Curriculums.txt", true);
            Label1.Text = arch.ReadToEnd();
            arch.Close();
        }
        

        if (File.Exists(this.Server.MapPath(".") + "/numRegistros.txt"))
        {
            StreamReader sr = new StreamReader(this.Server.MapPath(".") + "/numRegistros.txt");
            string valor = sr.ReadToEnd();
            int contador = int.Parse(valor);
            Label3.Text = contador.ToString();
            sr.Close();
        }else
        {
            Label3.Text = "0";
        }


        if (File.Exists(Server.MapPath(".") + "/" + fecha + "_numRegistros.txt"))
        {
            StreamReader sr2 = new StreamReader(Server.MapPath(".") + "/" + fecha + "_numRegistros.txt");
            string valor2 = sr2.ReadToEnd();
            int contador2 = int.Parse(valor2);
            Label6.Text = contador2.ToString();
            sr2.Close();


        }else
        {
            Label6.Text = "0";
        }


        Label5.Text = DateTime.Now.ToShortDateString();


    }
    //En el evento de carga del Web Form se crea un objeto de tipo StreamReader especificando la ruta del archivo con la fecha seleccionada 
    //y se leen los datos contenidos en el archivo y se le asignan al label 
    //tambien se le asignan al label el numero de registros de la fecha actual
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        String fecha = Calendar1.SelectedDate.Day.ToString() +
          Calendar1.SelectedDate.Month.ToString() +
          Calendar1.SelectedDate.Year.ToString();
        if (File.Exists(Server.MapPath(".") + "/" + fecha + "_Curriculums.txt"))
        {
            StreamReader arch = new StreamReader(Server.MapPath(".") + "/" + fecha + "_Curriculums.txt", true);
            Label1.Text = arch.ReadToEnd();
            arch.Close();
        }
        else
        {
            Label1.Text = "No hay registro este dia";
        }

        if (File.Exists(this.Server.MapPath(".") + "/numRegistros.txt"))
        {
            StreamReader sr = new StreamReader(this.Server.MapPath(".") + "/numRegistros.txt");
            string valor = sr.ReadToEnd();
            int contador = int.Parse(valor);
            Label3.Text = contador.ToString();
            sr.Close();
        }
        else
        {
            Label3.Text = "0";
        }


        

        Label5.Text = Calendar1.SelectedDate.ToShortDateString();
    }
}