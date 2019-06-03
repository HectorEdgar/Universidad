using System;

public class Ejecutivo : Empleado {
    private int id;
    private float bono;

	public Ejecutivo() {

	}

    
    public override float calcularNomina()
    {
        return ((sueldo+20)*getNumeroHorasTrabajadas())+bono;
    }

    public void setId(int id)
    {
        this.id = id;

    }

    public void setBono(float bono)
    {
        this.bono = bono;

    }

    public float getBono()
    {
        return this.bono;

    }

    public int  getId()
    {
        return id;
    }



}

