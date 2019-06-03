import java.sql.ResultSet;
import java.sql.SQLException;

public class UsuarioDAOImpl implements UsuarioDAO {

	@Override
	public boolean ValidarUsuario(Usuario usuario) {
		DataSourse ds = new DataSourseImpl();

		ResultSet rs = (ResultSet) ds.ejecutarConsulta("SELECT * FROM Usuario");
		Usuario us = new Usuario();
		boolean a = false;
		try {
			while (rs.next()) {

				us.setContrasena(rs.getString("contrasena"));
				us.setNombre(rs.getString("nombre"));
				if (usuario.getNombre() == us.getNombre() && usuario.getContrasena() == us.getContrasena()) {
					a = true;
					break;
				}
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}

		return a;
	}

	@Override
	public String InformacionUsuario(Usuario usuario) {
		// TODO Auto-generated method stub
		return null;
	}

}
