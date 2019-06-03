using System;

public class Directivo : Empleado
{
    private int id;
    private float accion;

    public Directivo()
    {

    }
    public override float calcularNomina() 
    {
        return ((sueldo + 20) * getNumeroHorasTrabajadas())+accion;
    }
}
