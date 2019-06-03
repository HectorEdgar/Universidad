package DAO;


import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class DataSourceImpl implements DataSource{
	private Connection conexion;
	private Statement stmt;
	

	private String puerto = "3306";
	private String usuario = "root";
	private String contrasena = "gonzalez1";
	private String protocolo = "jdbc:mysql://localhost:"+puerto+"/lazarobd";
	private Connection conex = null;
	
	public DataSourceImpl() {
		
		try {
			//1.- registrar el driver
			Class.forName("com.mysql.jdbc.Driver");
			//2.- obtener una conexion
			this.conex = DriverManager.getConnection(this.protocolo,this.usuario,this.contrasena);
			/*if (conex!=null){

				System.out.println("Conexion exitosa !!!!");
			}else {
				System.out.println("Conexion fallida!");
			}*/
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

	
		return null;
	}

	//INSERT, UPDATE, DELETE 
	@Override
	public int insertarEmpleado(String insertar) {
		Statement st = null;
		int rs = 0;
		try{
			//3.- ejecutar la actualizacion
			st = this.conex.createStatement();
			int retorno=rs = st.executeUpdate(insertar);
			return retorno;
		} catch(Exception e){
			e.printStackTrace();
		}
		return 0;
	}
	@Override
public ResultSet validarUsuario(String consulta) { 
		
		try {
			Statement st = null;
			st=this.conex.createStatement();
			ResultSet rs=st.executeQuery(consulta);
			return rs;
		}catch (Exception SQLException) {
			SQLException.printStackTrace();
		}
		return null;
	}
	

}