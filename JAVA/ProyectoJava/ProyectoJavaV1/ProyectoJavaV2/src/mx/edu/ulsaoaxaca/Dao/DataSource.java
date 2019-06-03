package mx.edu.ulsaoaxaca.Dao;

public interface DataSource {

	public Object ejecutarConsulta(String consulta);

	public int ejecutarActualizacion(String consulta);
}
