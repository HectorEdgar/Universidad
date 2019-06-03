package DAO;



import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;


import Dominio.Administrador;



public class LoginDaoImpl implements LoginDao {
	@Override
	public List<Administrador> validarUsarioF() {
		Administrador registro =new Administrador();
		 List<Administrador> administradores=new ArrayList();
		 String consulta="SELECT contrasena,usuario FROM Administrador";
		 DataSource guardar= new DataSourceImpl();
		 ResultSet rs =guardar.validarUsuario(consulta);
		 try{
		 while(rs.next()){
			 registro.setUsuario(rs.getString("usuario"));
			 registro.setContrasena(rs.getString("contrasena"));
			 administradores.add(registro);
		 }
		 }catch(Exception e){
			 e.printStackTrace();
		 }
		return administradores;
	}
}
