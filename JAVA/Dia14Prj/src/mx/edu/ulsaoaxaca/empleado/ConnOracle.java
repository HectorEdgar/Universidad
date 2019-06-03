package mx.edu.ulsaoaxaca.empleado;

import java.io.PrintWriter;
import java.io.StringWriter;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class ConnOracle {
	private java.sql.Connection con = null;
	private java.sql.Statement stmt;
	public ResultSet resultado;

	// consulta: sentencia sql. modo: 1->insert, delete, update. 2->select.
	public String consultaOrcl(String consulta, Integer modo) {
		String regs = "";
		StringWriter sw = null;
		PrintWriter pw = null;
		try {
			String driver = "oracle.jdbc.OracleDriver";
			String ulrjdbc = "jdbc:oracle:thin:SCOTT/PASSWORD@SERVER_IP:1521:SERVICE_NAME";
			Class.forName(driver).newInstance();
			con = DriverManager.getConnection(ulrjdbc);
			stmt = (Statement) con.createStatement();
			// modo=1 -> insert,update,delete; modo=2 -> select
			if (modo == 1) {
				stmt.executeUpdate(consulta);
			} else {
				resultado = (ResultSet) stmt.executeQuery(consulta);
			}
			while (resultado.next()) {
				regs = regs + "EMPNO: " + resultado.getString(1) + " ENAME: " + (resultado.getString(2)) + " JOB: "
						+ (resultado.getString(3)) + "\\n";
			}
			try {
				resultado.close();
				stmt.close();
				con.close();
			} catch (SQLException e) {
				sw = new StringWriter();
				pw = new PrintWriter(sw);
				e.printStackTrace(pw);
				return "\\r\\n" + sw.toString() + "\\r\\n";
			}
		} catch (Exception ex) {
			sw = new StringWriter();
			pw = new PrintWriter(sw);
			ex.printStackTrace(pw);
			return "\\r\\n" + sw.toString() + "\\r\\n";
		}
		return regs;
	}
}