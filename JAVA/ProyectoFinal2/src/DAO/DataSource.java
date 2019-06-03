package DAO;

import java.sql.ResultSet;

public interface DataSource {
	
	
	public Object ejecutarConsulta(String consulta); //SELECT ...
	
	int insertarEmpleado(String insertar); //INSERT, UPDATE, DELETE 

	ResultSet validarUsuario(String consulta);


}
