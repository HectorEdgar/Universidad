package mx.edu.ulsaoaxaca.Dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class DataSourceImpl implements DataSource {

	private String usuario = "root";
	private String contrasena = "MATIAS96edgar";
	private String puerto = "3306";
	private String protocolo = "jdbc:mysql://Localhost:" + puerto + "/proyectojava";
	private Connection conex = null;

	public DataSourceImpl() {

		try {
			Class.forName("com.mysql.jdbc.Driver");

			this.conex = DriverManager.getConnection(this.protocolo, this.usuario, this.contrasena);

		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	@Override
	public Object ejecutarConsulta(String consulta) {

		Statement st = null;
		ResultSet rs = null;
		try {

			st = this.conex.createStatement();
			rs = st.executeQuery(consulta);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return rs;
	}

	@Override
	public int ejecutarActualizacion(String consulta) {

		int NumeroAfectado = 0;
		Statement Stmt;
		try {
			Stmt = this.conex.createStatement();

			NumeroAfectado = Stmt.executeUpdate(consulta);
		} catch (SQLException e) {
			e.printStackTrace();
		}

		return NumeroAfectado;
	}

}
