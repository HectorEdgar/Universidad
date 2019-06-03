package DAO;

import java.util.List;

import mx.edu.ulsaoaxaca.nomina.dominio.Empleado;
import mx.edu.ulsaoaxaca.nomina.dominio.Persona;



// Contrato => Servicio ( es un contrato para un ser)
public interface NominaDAO {

	List <Empleado> selectEmpleados(String nombre);  //defino metodo
	Persona editarEmpleado(String id);

	public int  insertarEmpleado(Empleado empleado);
}


