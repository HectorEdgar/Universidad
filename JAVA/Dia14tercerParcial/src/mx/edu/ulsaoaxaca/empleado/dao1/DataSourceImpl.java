package mx.edu.ulsaoaxaca.empleado.dao1;

/*String consulta = " insert into empleado (nombre, fechaNacimiento, sexo, nss, sueldo)"
+ " values (?, ?, ?, ?,?)";

try {
PreparedStatement preparedStmt = (PreparedStatement) conex.prepareStatement(consulta);

preparedStmt.setString(1, a);
preparedStmt.setString(2, b);
preparedStmt.setString(3, c);
preparedStmt.setString(4, d);
preparedStmt.setString(5, e);
preparedStmt.execute();
} catch (SQLException f) {
// TODO Auto-generated catch block
f.printStackTrace();
}
*/
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
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
	
		int NumeroAfectado=0;
		
		PreparedStatement preparedStmt;
		//Statement st =  null;
		//int rs =  0;
		try {
			
			//st=this.conex.prepareStatement(consulta);
			//rs=st.executeUpdate(consulta);
			
			preparedStmt = (PreparedStatement) conex.prepareStatement(consulta);
			preparedStmt.execute();
			
			NumeroAfectado=preparedStmt.executeUpdate(consulta);
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
		return NumeroAfectado;
	}

}
