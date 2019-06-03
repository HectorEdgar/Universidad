package mx.edu.ulsaoaxaca.empleado;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class DataSourceImpl implements DataSource{
	

	private String puerto = "3306";
	private String usuario = "mysql";
	private String contrasena = "admin";
	private String protocolo = "jdbc:mysql://172.16.21.222:"+puerto+"/empresa";
	private Connection conex = null;
	
	public DataSourceImpl() {
		
		try {
			//1.- registrar el driver
			Class.forName("com.mysql.jdbc.Driver");
			//2.- obtener una conexion
			this.conex = DriverManager.getConnection(this.protocolo,this.usuario,this.contrasena);
		
		} catch (Exception e) {
			e.printStackTrace();
		}
		
	}

	//SELECT..
	@Override
	public Object ejecutarConsulta(String consulta) {
		Statement st = null;
		ResultSet rs = null;
		try{
			//3.- ejecutar la consulta
			st = this.conex.createStatement();
			rs = st.executeQuery(consulta);
		} catch(Exception e){
			e.printStackTrace();
		}

	
		return rs;
	}

	//INSERT, UPDATE, DELETE 
	@Override
	public int ejecutarActualizacion(String consulta) {
		// TODO Auto-generated method stub
		return 0;
	}
	
	

}