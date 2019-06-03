package mx.edu.ulsaoaxaca.empleado.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class DataSourceImpl implements DataSourse{
	//Propiedades
	private String usuario = "mysql";
	private String contrasena ="admin";
	private String puerto = "3306";
	private String protocolo = "jdbc:mysql://172.16.21.222:"+ puerto +"/empresa";
	private Connection conex = null;

	public DataSourceImpl(){ // constructor (inicializar objecto)
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

			st = this.conex.createStatement();  //Intruccion = Statement
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

		return 0;
	}

}
