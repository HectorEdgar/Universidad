package mx.edu.ulsaoaxaca.Dao;

import java.sql.ResultSet;
import java.sql.SQLException;

import mx.edu.ulsaoaxaca.Dominio.Cuenta;

public class CuentaDaoImpl implements CuentaDao{
	@Override
	public Cuenta ValidarUsuario(Cuenta cuenta) {
		String usuario = cuenta.getUsuario();
		String contrasena = cuenta.getContrasena();
		String consulta = "SELECT * FROM CUENTAS,PERSONAS,PERFILES WHERE CUEN_USUARIO = \"" + usuario + "\" AND " + 
				 "CUEN_CONTRASENA = \""+contrasena+"\" AND CUEN_PERSONA_ID = PERSONA_ID" + " AND CUEN_PERFIL_ID = PERFIL_ID";

		DataSource ds = new DataSourceImpl();
		ResultSet rs = (ResultSet) ds.ejecutarConsulta(consulta);
		Cuenta CuentaValidada = new Cuenta();

		try {
			while (rs.next()) {
				CuentaValidada.setUsuario(usuario);
				CuentaValidada.setContrasena(contrasena);
				CuentaValidada.setId(Integer.toString(rs.getInt("PERSONA_ID")));
				CuentaValidada.setNombre(rs.getString("PERS_NOMBRE"));
				CuentaValidada.setFechaAlta(rs.getString("PERF_FECHA_ALTA"));
				CuentaValidada.setFechaCreacion(rs.getString("CUEN_FECHA_CREACION"));
				CuentaValidada.setSexo(rs.getString("PERS_SEXO"));
				CuentaValidada.setFechaNacimiento(rs.getString("PERS_FECHA_NACIMIENTO"));
				return CuentaValidada;
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;

	}
}
