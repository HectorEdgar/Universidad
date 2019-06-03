package mx.edu.ulsaoaxaca.empleado.dao1;

import mx.edu.ulsaoaxaca.empleado.dominio.Empleado;

public class EmpleadoDAOImpl implements EmpleadoDAO {

	/*
	 * @Override public List<Empleado> selectEmpleados() { List<Empleado >
	 * empleados = new ArrayList<Empleado>(); DataSourse ds = new
	 * DataSourceImpl(); ResultSet rs = (ResultSet) ds.ejecutarConsulta(
	 * "INSERT INTO Empleado(nombre,FechaNacimiento,sexo,sueldo,nss) VALUES('"
	 * +ven+"')"); Panel1 ven = new Panel1(); ven.setNombre(super.toString());
	 * //Ventana ventana2 = new Ventana(); empleados.add((Empleado)
	 * ven.Empleados());
	 * 
	 * try { while(rs.next()){
	 * 
	 * for(Empleado e:empleados){ e.setId(Integer.toString(rs.getInt("id")));
	 * e.setNombre(rs.getString("nombre"));
	 * e.setFechaNacimiento(rs.getString("fechaNacimiento"));
	 * e.setSexo(rs.getString("sexo")); e.setSueldo(rs.getString("sueldo"));
	 * e.setNss(rs.getString("nss")); empleados.add(e); }
	 * 
	 * } } catch (SQLException e) { // TODO Auto-generated catch block
	 * e.printStackTrace(); }
	 * 
	 * 
	 * 
	 * 
	 * return empleados; }
	 * 
	 * @Override public void ActualizarBD(String nombre, String fecha, String
	 * nss, String sexo, String sueldo) { DataSourceImpl dd = new
	 * DataSourceImpl(); dd.ejecutarActualizacion(nombre, fecha, nss, sexo,
	 * sueldo);
	 * 
	 * 
	 * String puerto = "3306"; Class.forName("com.mysql.jdbc.Driver");
	 * Connection conex =
	 * DriverManager.getConnection("jdbc:mysql://172.16.21.222:" + puerto +
	 * "/empresa", "mysql", "admin");
	 * 
	 * // the mysql insert statement String query =
	 * " insert into empleado (nombre, fechaNacimiento, sexo, nss, sueldo)" +
	 * " values (?, ?, ?, ?,?)";
	 * 
	 * // create the mysql insert preparedstatement PreparedStatement
	 * preparedStmt = conex.prepareStatement(query); preparedStmt.setString(1,
	 * caja1.getText()); preparedStmt.setString(2, caja2.getText());
	 * preparedStmt.setString(3, caja3.getText()); preparedStmt.setString(4,
	 * caja4.getText()); preparedStmt.setString(5, caja5.getText());
	 * preparedStmt.execute();
	 * 
	 * // execute the preparedstatement preparedStmt.execute();
	 * 
	 * conex.close(); } catch (Exception e1) { System.err.println("Syntax Error"
	 * ); System.err.println(e1.getMessage()); } }
	 * 
	 * 
	 * // Panel1 ven = new Panel1(); System.out.printf("Result: %s %s %s %s %s"
	 * ,nombre,fecha,nss,sexo,sueldo); ResultSet rs = (ResultSet)
	 * ds.ejecutarConsulta("INSERT INTO Empleado(nombre," + "FechaNacimiento," +
	 * "sexo," + "sueldo," + "nss) " + "VALUES('" + nombre + "','" + fecha +
	 * "','" + nss + "','" + sexo + "','" + sueldo + "')");
	 * 
	 * // Ventana ventana2 = new Ventana();
	 */

	@Override
	public void ActualizarBD(Empleado empleadoN) {

		String nombre = empleadoN.getNombre();
		String fecha = empleadoN.getFechaNacimiento();
		String nss = empleadoN.getNss();
		String sexo = empleadoN.getSexo();
		String sueldo = empleadoN.getSueldo();

		String consulta = "INSERT INTO Empleado(nombre," + "FechaNacimiento," + "sexo," + "sueldo," + "nss) "
				+ "VALUES('" + nombre + "','" + fecha + "','" + sexo + "','" + sueldo + "','" + nss + "');";
		// System.out.print(consulta);

		DataSourse data = new DataSourceImpl();
		data.ejecutarActualizacion(consulta);
	}

}
