package mx.edu.ulsaoaxaca.empleado.dao;

import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

import mx.edu.ulsaoaxaca.empleado.dao1.DataSourceImpl;
import mx.edu.ulsaoaxaca.empleado.dao1.DataSourse;
import mx.edu.ulsaoaxaca.empleado.dominio.Empleado;

public class NominaDAOImpl implements NominaDAO{

	@Override
	public List<Empleado> selectEmpleados() { //implementa el metodo de la interface 
		List<Empleado > empleados =  new ArrayList<Empleado>();
		DataSourse ds = new DataSourceImpl();
		ResultSet rs= (ResultSet) 
				ds.ejecutarConsulta("INSERT INTO Empleado(nombre,FechaNacimiento,sexo,sueldo,nss) VALUES('");
	
		
		
		
		
		try {

			while (rs.next()){
				// crear un objeto tipo empleado
				Empleado e = new Empleado();
				e.setId(Integer.toString(rs.getInt("id")));
				e.setNombre(rs.getString("nombre"));
				e.setFechaNacimiento(rs.getString("fechaNacimiento"));
				e.setSexo(rs.getString("sexo"));
				e.setSueldo(rs.getString("sueldo"));
				e.setNss(rs.getString("nss"));
				empleados.add(e);
				
				

				//obtengo los valores del objeto y manndarlo al objeto  
			}
		}
		catch (Exception e){
			e.printStackTrace();
		}
		return empleados;
	}

}
