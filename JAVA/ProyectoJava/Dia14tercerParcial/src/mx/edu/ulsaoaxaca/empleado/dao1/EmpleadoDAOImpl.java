package mx.edu.ulsaoaxaca.empleado.dao1;

import mx.edu.ulsaoaxaca.empleado.dominio.Empleado;

public class EmpleadoDAOImpl implements EmpleadoDAO {



	@Override
	public int GrabarEmpleado(Empleado empleadoN) {

		String nombre = empleadoN.getNombre();
		String fecha = empleadoN.getFechaNacimiento();
		String nss = empleadoN.getNss();
		String sexo = empleadoN.getSexo();
		String sueldo = empleadoN.getSueldo();

		String consulta = "INSERT INTO Empleado(nombre," + "FechaNacimiento," + "sexo," + "sueldo," + "nss) "
				+ "VALUES('" + nombre + "','" + fecha + "','" + sexo + "','" + sueldo + "','" + nss + "');";
		// System.out.print(consulta);

		DataSourse data = new DataSourceImpl();
		return data.ejecutarActualizacion(consulta);
	}

}
