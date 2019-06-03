﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calculadora2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Button5_Click(object sender, EventArgs e)
    {
        Label1.Text = RadioButtonList1.Text;

        double resultado = 0;
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


        switch (RadioButtonList1.Text)
        {
            case "+":
                resultado = num1 + num2;

                txtResultado.Text = "" + resultado;
                break;
            case "-":
                resultado = num1 - num2;

                txtResultado.Text = "" + resultado;
                break;
            case "/":
                resultado = num1 / num2;

                txtResultado.Text = "" + resultado;
                break;
            case "*":
                resultado = num1 * num2;

                txtResultado.Text = "" + resultado;
                break;
        }
    }
}