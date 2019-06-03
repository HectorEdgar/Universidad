package mx.edu.ulsaoaxaca.Dao;

import mx.edu.ulsaoaxaca.Dominio.Domicilio;
import mx.edu.ulsaoaxaca.Dominio.Empleado;

public class EmpleadoDaoImpl implements EmpleadoDao {

	@Override
	public int GrabarEmpleado(Empleado emp) {
		String nombre = emp.getNombre();
		String fecha = emp.getFechaNacimiento();
		String nss = emp.getNss();
		String sexo = emp.getSexo();
		String sueldo = emp.getSueldo();
		int id = Integer.parseInt(emp.getId());
		DataSource data = new DataSourceImpl();

		String consulta1 = "INSERT INTO PERSONAS(PERS_NOMBRE," + "PERS_FECHA_NACIMIENTO," + "PERS_SEXO,"
				+ "PERSONA_ID) " + "VALUES('" + nombre + "','" + fecha + "','" + sexo + "'," + id + "" + ");";
		
		String consulta3 = "INSERT INTO EMPLEADOS(EMPL_PERSONA_ID,EMPLEADO_ID,EMPL_SUELDO,EMPL_NSS) " +
		"VALUES("+id+","+id+","+sueldo+",'"+nss+"');";
		int filasafectadas1=data.ejecutarActualizacion(consulta1);
		if(filasafectadas1==0){
			return 0;
		}
		int idDomicilio1 =Integer.valueOf(emp.getId());
		
		for (Domicilio e : emp.getDomiciliosParticulares()) {
			 idDomicilio1 = idDomicilio1+1;
			String consulta2 = "INSERT INTO DOMICILIOS(DOMICILIO_ID,DOMI_CALLE,DOMI_COLONIA,DOMI_MUNICIPIO,DOMI_ENTIDAD_FEDERATIVA,DOMI_CP) "
					+ "VALUES(" + idDomicilio1+ ",'" + e.getCalle() + "','" + e.getColonia() + "','"
					+ e.getEntidadFederativa() + "','" + e.getMunicipio() + "','" + e.getCp() + "');";

			//String consulta4 = "INSERT INTO empleadospordomicilios(Empleado_EMPLEADO_ID,Domicilio_DOMICILIO_ID,CLASE_DOMICILIO_TIPO_DOMICILIO_ID) "
				//	+ "VALUES(" + emp.getId() + "," + idDomicilio + ",1";

			
			int filasafectadas2=data.ejecutarActualizacion(consulta2);
			if(filasafectadas2==0){
				return 0;
			}
			//int filasafectadas2=data.ejecutarActualizacion(consulta4);
			
			 //if(filasafectadas2==0){
			//	return 0;
			//}
		}
		int idDomicilio2 =Integer.valueOf(emp.getId())+100;
		for (Domicilio e : emp.getDomiciliosFiscales()) {
			 idDomicilio2 = idDomicilio2+1;
			// String particular = " " + e.getCalle() + " " + e.getColonia() + "
			// " + e.getEntidadFederativa() + " "
			// + e.getMunicipio() + " " + e.getCp();
			String consulta2 = "INSERT INTO DOMICILIOS(DOMICILIO_ID,DOMI_CALLE,DOMI_COLONIA,DOMI_MUNICIPIO,DOMI_ENTIDAD_FEDERATIVA,DOMI_CP) "
					+ "VALUES(" + idDomicilio2 + ",'" + e.getCalle() + "','" + e.getColonia() + "','"
					+ e.getEntidadFederativa() + "','" + e.getMunicipio() + "','" + e.getCp() + "');";

			//String consulta4 = "INSERT INTO empleadospordomicilios(Empleado_EMPLEADO_ID,Domicilio_DOMICILIO_ID,CLASE_DOMICILIO_TIPO_DOMICILIO_ID) "
				//	+ "VALUES(" + emp.getId() + "," + idDomicilio + ",2";

			
			int filasafectadas2=data.ejecutarActualizacion(consulta2);
			if(filasafectadas2==0){
				return 0;
			}
			//int filasafectadas2=data.ejecutarActualizacion(consulta4);
			
			 //if(filasafectadas2==0){
				//return 0;
			//}
		}
		
		
		int filasafectadas3=data.ejecutarActualizacion(consulta3);
		
		 if(filasafectadas3==0){
			return 0;
		}
		
		 for (Domicilio e : emp.getDomiciliosParticulares()) {
			 
			String consulta4 = "INSERT INTO empleadospordomicilios(Empleado_EMPLEADO_ID,Domicilio_DOMICILIO_ID,CLASE_DOMICILIO_TIPO_DOMICILIO_ID) "
				+ "VALUES(" + emp.getId() + "," + idDomicilio1 + ",1);";
			
			int filasafectadas4=data.ejecutarActualizacion(consulta4);
			
			 if(filasafectadas4==0){
				return 0;
			}
			 
		 }
		 for (Domicilio e : emp.getDomiciliosFiscales()) {
			 String consulta4 = "INSERT INTO empleadospordomicilios(Empleado_EMPLEADO_ID,Domicilio_DOMICILIO_ID,CLASE_DOMICILIO_TIPO_DOMICILIO_ID) "
							+ "VALUES(" + emp.getId() + "," + idDomicilio2 + ",2);";
			 int filasafectadas4=data.ejecutarActualizacion(consulta4);
				
			 if(filasafectadas4==0){
				return 0;
			}
		 }

		return 1;

	}

}