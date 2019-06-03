package Dominio;
import java.io.Serializable;
import java.lang.Comparable;


public abstract class Persona implements Serializable  {
	
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 3959425485440739803L;
	
	
	private String nombre;
	private String sexo;
	private String fechaNacimiento;
	private String id;
	
	public Persona() {
		
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getSexo() {
		return sexo;
	}

	public void setSexo(String sexo) {
		this.sexo = sexo;
	}

	public String getFechaNacimiento() {
		return fechaNacimiento;
	}

	public void setFechaNacimiento(String fechaNacimiento) {
		this.fechaNacimiento = fechaNacimiento;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}
	
	public abstract String mostrarInformacion();
	
	public abstract String mostrarSueldo();
	

	

}
