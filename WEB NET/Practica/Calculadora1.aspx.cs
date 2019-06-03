using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calculadora1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        double resultado = 0;
        Label1.Text = "+";
        int num1 = 0;
        int num2 = 0;

        try
        {
            num1 = Convert.ToInt16(txtNumero1.Text);
        }
        catch (Exception)
        {
            txtNumero1.Text = "0";
            num1 = 0;
        }

        try
        {
            num2 = Convert.ToInt16(txtNumero2.Text);
        }
        catch (Exception)
        {
            txtNumero2.Text = "0";
            num2 = 0;
        }


        resultado = num1 + num2;

        txtResultado.Text = "" + resultado;

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        double resultado = 0;
        Label1.Text = "-";
        int num1 = 0;
        int num2 = 0;

        try
        {
            num1 = Convert.ToInt16(txtNumero1.Text);
        }
        catch (Exception)
        {
            txtNumero1.Text = "0";
            num1 = 0;
        }

        try
        {
            num2 = Convert.ToInt16(txtNumero2.Text);
        }
        catch (Exception)
        {
            txtNumero2.Text = "0";
            num2 = 0;
        }


        resultado = num1 - num2;

        txtResultado.Text = "" + resultado;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        double resultado = 0;
        Label1.Text = "/";
        int num1 = 0;
        int num2 = 0;

        try
        {
            num1 = Convert.ToInt16(txtNumero1.Text);
        }
        catch (Exception)
        {
            txtNumero1.Text = "0";
            num1 = 0;
        }

        try
        {
            num2 = Convert.ToInt16(txtNumero2.Text);
        }
        catch (Exception)
        {
            txtNumero2.Text = "0";
            num2 = 0;
        }


        resultado = num1 / num2;

        txtResultado.Text = "" + resultado;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        double resultado = 0;
        Label1.Text = "*";
        int num1 = 0;
        int num2 = 0;

        try
        {
            num1 = Convert.ToInt16(txtNumero1.Text);
        }
        catch (Exception)
        {
            txtNumero1.Text = "0";
            num1 = 0;
        }

        try
        {
            num2 = Convert.ToInt16(txtNumero2.Text);
        }
        catch (Exception)
        {
            txtNumero2.Text = "0";
            num2 = 0;
        }


        resultado = num1 * num2;

        txtResultado.Text = "" + resultado;
    }
}