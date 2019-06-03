import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class DataSourseImpl implements DataSourse {
	private String usuario="mysql";
	private String puerto="3306";
	private String contrasena="admin";
	private String protocolo="jdbc:mysql://172.16.21.222:"+puerto+"/empresa";
	private Connection conex;

	public DataSourseImpl(){
		try {
			Class.forName("com.mysql.jdbc.Driver");
			
			this.conex=DriverManager.getConnection(this.protocolo, this.usuario, this.contrasena);
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		
	}

	@Override
	public Object ejecutarConsulta(String consulta) {
		Statement st=null;
		ResultSet rs=null;
		try {
			st=conex.createStatement();
			rs=st.executeQuery(consulta);
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		
		return rs;
	}

	@Override
	public int ejecutarActualizacion(String consulta) {
		
		int rs=0;
		try {
			PreparedStatement ps;
			ps=this.conex.prepareStatement(consulta);
			rs=ps.executeUpdate();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return rs;
	}


}
