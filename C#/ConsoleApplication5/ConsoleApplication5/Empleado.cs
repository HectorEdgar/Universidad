using System;

public class Empleado : Persona
{
    private int id;
    private String fechaContratacion { set; get; }
    private float numeroHorasTrabajadas { set; get; }
    public static float sueldo = 50;


    public Empleado()
    {
    }

    public void setId(int id)
    {
        this.id = id;

    }

    public int getId()
    {

        return this.id;
    }


    public void setFechaContratacion(String fech)
    {
        this.fechaContratacion = fech;

    }

    public String getFechaContratacion()
    {

        return this.fechaContratacion;
    }



    public void setNUmeroHorasTrabajadas(float horas)
    {

        this.numeroHorasTrabajadas = horas;

    }

    public float getNumeroHorasTrabajadas()
    {

        return this.numeroHorasTrabajadas;
    }

    public float sueldoHora()
    {

        return sueldo * numeroHorasTrabajadas;
    }
    public override float calcularNomina()
    {
        return sueldo * numeroHorasTrabajadas;

    }

    public override string desplegarInformacion()
    {
        String cadena1 = Convert.ToString(sueldo);
        cadena1 += " ";
        cadena1 += Convert.ToString(numeroHorasTrabajadas);
        return cadena1;
    }
}