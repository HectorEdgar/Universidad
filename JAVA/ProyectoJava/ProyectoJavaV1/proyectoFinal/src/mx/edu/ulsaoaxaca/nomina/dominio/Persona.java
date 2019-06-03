package mx.edu.ulsaoaxaca.nomina.dominio;
import java.io.Serializable;

// clase abstracta , (virtual en c++) 

public abstract class Persona implements Serializable {
	
	private static final long serialVersionUID = 1512233590154216905L;
	//propiedades
	private String id;
	private String nombre;
	private String fechaNacimiento;
	private String sexo;
	
	
	

	//constructor predeterminado
	public Persona() {}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getFechaNacimiento() {
		return fechaNacimiento;
	}

	public void setFechaNacimiento(String fechaNacimiento) {
		this.fechaNacimiento = fechaNacimiento;
	}

	public String getSexo() {
		return sexo;
	}

	public void setSexo(String sexo) {
		this.sexo = sexo;
	}

	
	
	//metodo abstracto 
	public abstract String desplegarInformacion();
	public abstract String calcularSueldo();
}
