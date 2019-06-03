package mx.edu.ulsaoaxaca.empleado.dao;

import java.util.List;

import mx.edu.ulsaoaxaca.empleado.dominio.Empleado;

// Contrato => Servicio ( es un contrato para un ser)
public interface NominaDAO {
	
	List <Empleado> selectEmpleados();  //defino metodo
}
