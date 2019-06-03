package mx.edu.ulsaoaxaca.Dao;

public interface DataSourse {

	public Object ejecutarConsulta(String consulta);

	public int ejecutarActualizacion(String consulta);
}
