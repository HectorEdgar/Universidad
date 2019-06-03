using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int idAlumno = 0;
        try
        {
            idAlumno = Convert.ToInt16(TextBox1.Text);
        }
        catch (Exception)
        {
            idAlumno = 1;
            TextBox1.Text = "1";
        }

        using (DirectorioEntities1 entity = new DirectorioEntities1())
        {

            var alumnos = entity.Alumnos.Where(p=>p.idAlumno.Equals(idAlumno));
                          
            GridView1.DataSource = alumnos.ToList();
            GridView1.DataBind();

        }

        
    }
}