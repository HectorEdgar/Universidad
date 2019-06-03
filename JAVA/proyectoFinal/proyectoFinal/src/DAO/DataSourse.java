package DAO;

// contrato para proveer un servicio
public interface  DataSourse {
	//1.-  ejecutar consultas
	//2.- ejecutar actualizaciones 

	public Object ejecutarConsulta(String consulta); //SELECT...
	public int  ejecutarActualizacion(String consulta); //INSERT , UPDATE , DELETE


}
