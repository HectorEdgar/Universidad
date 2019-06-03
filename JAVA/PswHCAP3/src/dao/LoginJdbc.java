package dao;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class LoginJdbc {
	
	public static synchronized int login(String usuario, String clave) {
        Connection cn = null;
        ResultSet rs = null;
        Statement st = null;
        int hayUsuario = 0;
        try {
            cn = Conexion.getConexion();
            st = cn.createStatement();
            String sql = "select * from usuario where nombre = '" + usuario + "' and clave = '" + clave + "'";
            rs = st.executeQuery(sql);
            while (rs.next()) {
            	hayUsuario++;
            }
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
        	try {
				st.close();
				rs.close();
	            Conexion.cerrarConexion(cn);
			} catch (SQLException e) {
				e.printStackTrace();
			}
        }
        return  hayUsuario;
    }
	
}
