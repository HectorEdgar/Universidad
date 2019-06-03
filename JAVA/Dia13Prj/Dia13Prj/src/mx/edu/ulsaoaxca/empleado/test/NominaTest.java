package mx.edu.ulsaoaxca.empleado.test;

import java.util.List;

import mx.edu.ulsaoaxaca.empleado.dao.NominaDAO;
import mx.edu.ulsaoaxaca.empleado.dao.NominaDAOImpl;
import mx.edu.ulsaoaxaca.empleado.dominio.Empleado;



//Bussines Object
public class NominaTest {

	public static void main(String... args) {

		// 1.- Calcular nomina

		// Invocar al dao
		NominaDAO nomina = new NominaDAOImpl();
		List <Empleado> empleados = nomina.selectEmpleados(); //getData()

		double totalNomina = 0.0;
		for (Empleado e : empleados) { 
			totalNomina += Double.parseDouble(e.calcularSueldo());
		}
		System.out.printf("La nomina total es de %.2f", totalNomina);
	}

}
