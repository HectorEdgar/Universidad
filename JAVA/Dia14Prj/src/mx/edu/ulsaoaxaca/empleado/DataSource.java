package mx.edu.ulsaoaxaca.empleado;

//contrato => servicio
//FUNCION: 1.- ejecutar consultas 2.-ejecutar actualizaciones
public interface DataSource {
	
	
	public Object ejecutarConsulta(String consulta); //SELECT ...
	
	int ejecutarActualizacion(String consulta); //INSERT, UPDATE, DELETE 


}
