package DAO;

import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

import mx.edu.ulsaoaxaca.nomina.dominio.Directivo;
import mx.edu.ulsaoaxaca.nomina.dominio.Domicilio;
import mx.edu.ulsaoaxaca.nomina.dominio.Ejecutivo;
import mx.edu.ulsaoaxaca.nomina.dominio.Empleado;
import mx.edu.ulsaoaxaca.nomina.dominio.Persona;

public class NominaDAOImpl implements NominaDAO{

	@Override
	public List<Empleado> selectEmpleados(String nombre) { //implementa el metodo de la interface 
		List<Empleado> empleados =  new ArrayList<Empleado>();
		DataSourse ds = new DataSourceImpl();
		ResultSet rs= (ResultSet) 
				ds.ejecutarConsulta("SELECT  p.nombre,em.id_empleado From Empleado em, Persona p WHERE p.nombre LIKE '"+nombre+"%' and id_personaem = id_persona;"); //consulta
		try {

			while (rs.next()){
				
				// Crear un objeto tipo empleado
				Empleado e = new Empleado();
			
				e.setNombre(rs.getString("nombre"));
				e.setId(Integer.toString(rs.getInt("id_empleado")));
				empleados.add(e);

				//obtengo los valores del objeto y mandarlo al objeto  
			}
		}
		catch (Exception e){
			e.printStackTrace();
		} 

		return empleados;
	}

	@Override
	public int  insertarEmpleado(Empleado empleado) {
		String sql = "";
		DataSourse ds = new DataSourceImpl();
		sql ="INSERT INTO empleado (nombre,fechaNacimiento,sexo,sueldo,nss) "
				+ "VALUES ('"+empleado.getNombre()+"','"+empleado.getFechaNacimiento()+"','"+empleado.getSexo()+"','"+empleado.getSueldo()+"','"+empleado.getNss()+"');";
		int r = ds.ejecutarActualizacion(sql);

		return r;
	}

	@Override
	public Persona editarEmpleado(String id) {
		DataSourse ds = new DataSourceImpl();
		ResultSet rs= (ResultSet) 
				ds.ejecutarConsulta("select * from persona, empleado,domicilioparticular where id_persona = id_personaem and id_empleado = id_empleadodp and id_empleado = "+id+";"); //consulta
		Domicilio domicilioParticular = new Domicilio();;
		if (rs instanceof Empleado){
			Empleado empleado = new Empleado();
		try {

			while (rs.next()){
				
				// Crear un objeto tipo empleado
				
				
				
				empleado.setId(Integer.toString(rs.getInt("id")));
				empleado.setNombre(rs.getString("nombre"));
				empleado.setFechaNacimiento(rs.getString("fechaNacimiento"));
				empleado.setSexo(rs.getString("sexo"));
				empleado.setSueldo(rs.getString("sueldo"));
				empleado.setNss(rs.getString("nss"));
				domicilioParticular.setCalle(rs.getString("calle"));
				domicilioParticular.setColonia(rs.getString("colonia"));
				domicilioParticular.setMunicipio(rs.getString("municipio"));
				domicilioParticular.setEntidadFederativa(rs.getString("entidadFederativa"));
				domicilioParticular.setCp(rs.getString("codigoPostal"));
				
				empleado.setDomicilioParticular(domicilioParticular);
				
			}
		}
		catch (Exception e){
			e.printStackTrace();
		} 
		return empleado;
		}
		
		// ejecutivo
		if(rs instanceof Ejecutivo){
			Ejecutivo ejecutivo = new Ejecutivo();
			try {

				while (rs.next()){
					ejecutivo.setId(Integer.toString(rs.getInt("id")));
					ejecutivo.setNombre(rs.getString("nombre"));
					ejecutivo.setFechaNacimiento(rs.getString("fechaNacimiento"));
					ejecutivo.setSexo(rs.getString("sexo"));
					ejecutivo.setSueldo(rs.getString("sueldo"));
					ejecutivo.setNss(rs.getString("nss"));
					ejecutivo.setBono(rs.getString("bono"));
					domicilioParticular.setCalle(rs.getString("calle"));
					domicilioParticular.setColonia(rs.getString("colonia"));
					domicilioParticular.setMunicipio(rs.getString("municipio"));
					domicilioParticular.setEntidadFederativa(rs.getString("entidadFederativa"));
					domicilioParticular.setCp(rs.getString("codigoPostal"));
					
					ejecutivo.setDomicilioParticular(domicilioParticular);
				}
			}
			catch (Exception e){
				e.printStackTrace();
			} 
			return ejecutivo;
		}
		
		if (rs instanceof Directivo){
			Directivo directivo = new  Directivo();
			try {

				while (rs.next()){
					directivo.setId(Integer.toString(rs.getInt("id")));
					directivo.setNombre(rs.getString("nombre"));
					directivo.setFechaNacimiento(rs.getString("fechaNacimiento"));
					directivo.setSexo(rs.getString("sexo"));
					directivo.setSueldo(rs.getString("sueldo"));
					directivo.setNss(rs.getString("nss"));
					directivo.setAccion(rs.getString("Acciones"));
					domicilioParticular.setCalle(rs.getString("calle"));
					domicilioParticular.setColonia(rs.getString("colonia"));
					domicilioParticular.setMunicipio(rs.getString("municipio"));
					domicilioParticular.setEntidadFederativa(rs.getString("entidadFederativa"));
					domicilioParticular.setCp(rs.getString("codigoPostal"));
					
					directivo.setDomicilioParticular(domicilioParticular);
				}
			}
			catch (Exception e){
				e.printStackTrace();
			} 
			return directivo;
		}
		return null;
		
	}

}
