package mx.edu.ulsaoaxaca.Dao;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

import mx.edu.ulsaoaxaca.Dominio.Directivo;
import mx.edu.ulsaoaxaca.Dominio.Ejecutivo;
import mx.edu.ulsaoaxaca.Dominio.Empleado;
import mx.edu.ulsaoaxaca.Dominio.Persona;

public class NominaDaoImpl implements NominaDao {

	@Override
	public ArrayList<Persona> CalcularNomina() {

		ArrayList<Persona> empleadosN = new ArrayList<Persona>();
		DataSource ds = new DataSourceImpl();
		String consultaEmpleados = "SELECT * FROM EMPLEADO,PERSONA WHERE EMPL_PERSONA_ID = PERSONA_ID ";
		String consultaEjecutivos = "SELECT * FROM EJECUTIVO, EMPLEADO,PERSONA WHERE EMPL_PERSONA_ID=EMPLEADO_ID AND EMPL_PERSONA_ID = PERSONA_ID ;";
		String consultaDirectivos = "SELECT * FROM DIRECTIVO, EMPLEADO, PERSONA WHERE DIRE_EMPLEADO_ID = EMPLEADO_ID AND EMPL_PERSONA_ID = PERSONA_ID;";

		ResultSet rs1 = (ResultSet) ds.ejecutarConsulta(consultaEmpleados);
		ResultSet rs2 = (ResultSet) ds.ejecutarConsulta(consultaEjecutivos);
		ResultSet rs3 = (ResultSet) ds.ejecutarConsulta(consultaDirectivos);

		try {
			while (rs1.next()) {
				Empleado emp = new Empleado();
				emp.setId(rs1.getString("PERSONA_ID"));
				emp.setNombre("PERS_NOMBRE");
				emp.setNss("PERS_NOMBRE");
				emp.setSexo("PERS_SEXO");
				emp.setSueldo(rs1.getString("EMPL_SUELDO"));

				empleadosN.add(emp);

			}
		} catch (SQLException e) {
			e.printStackTrace();
		}

		try {
			while (rs2.next()) {
				Ejecutivo ej = new Ejecutivo();
				ej.setBono("EJEC_BONO");
				ej.setFechaNacimiento("PERS_FECHA_NACIMIENTO");
				ej.setId("PERSONA_ID");
				ej.setNombre("PERS_NOMBRE");
				ej.setNss("EMPL_NSS");
				ej.setSexo("PERS_SEXO");
				ej.setSueldo("EMPL_SUELDO");

				empleadosN.add(ej);

			}
		} catch (SQLException e1) {
			e1.printStackTrace();
		}

		try {
			while (rs3.next()) {
				Directivo dire = new Directivo();
				dire.setFechaNacimiento("PERS_FECHA_NACIMIENTO");
				dire.setId("PERSONA_ID");
				dire.setNombre("PERS_NOMBRE");
				dire.setNss("EMPL_NSS");
				dire.setSexo("PERS_SEXO");
				dire.setSueldo("EMPL_SUELDO");
				dire.setAccion("DIRE_ACCION");
				empleadosN.add(dire);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}

		return empleadosN;
	}

}
