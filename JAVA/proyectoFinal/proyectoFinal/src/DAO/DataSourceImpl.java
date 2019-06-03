package DAO;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;




public class DataSourceImpl implements DataSourse{
	//Propiedades
	private String usuario = "SYSTEM";
	private String contrasena ="Root1234";
	private String puerto = "3306";
	private String protocolo = "jdbc:mysql://localhost:"+ puerto +"/empleados";
	private Connection conex = null;
	//private String sql = "";
	public DataSourceImpl(){ // constructor (inicializar objeto)
		//1.-Registrar el driver 
		try {
			Class.forName("com.mysql.jdbc.Driver");
			//2. Obtener una conexicon
			this.conex = DriverManager.getConnection(this.protocolo, this.usuario, this.contrasena); //recibe un objeto de tipo connection 
		}	
		catch(Exception e){
			e.printStackTrace();
		}
	}

	//Select
	@Override
	public Object ejecutarConsulta(String consulta) {
		// 3. Ejecutar la consulta 
		Statement st =  null;
		ResultSet rs =  null;
		try{		

			st = this.conex.createStatement();  //Instruccion = Statement
			rs = st.executeQuery(consulta); // Resultset =  conjunto de resultados   //Se ejecuta la consulta

		}
		catch (Exception e){
			e.printStackTrace();
		}
		return rs;
	}
	//INSERT, UPDATE ,DELETE 
	@Override
	public int ejecutarActualizacion(String consulta) {
		int rs= 0 ;
		Statement  st = null;
		try {
			st = this.conex.createStatement();
			rs = st.executeUpdate(consulta);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return rs;
	}
}


