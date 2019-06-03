using System;

public abstract class Persona
{
    private int id;
    private String nombre;
    private String fechaNacimiento;
    private char sexo;

    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    public string Nombre
    {
        get
        {
            return nombre;
        }

        set
        {
            nombre = value;
        }
    }

    public string FechaNacimiento
    {
        get
        {
            return fechaNacimiento;
        }

        set
        {
            fechaNacimiento = value;
        }
    }

    public char Sexo
    {
        get
        {
            return sexo;
        }

        set
        {
            sexo = value;
        }
    }

    public Persona()
    {

    }
    public abstract float calcularNomina();
    public abstract String desplegarInformacion();

}
