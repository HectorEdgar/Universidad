public class Estudiante {
	private String nombre;
	private String fechaNacimiento;
	private String sexo;
	private String id;
	private String escuela;
	private String grado;
	private String grupo;
	
	public Estudiante() {
		
	}
	public void setNombre(String nombre) {
		this.nombre=nombre;
	}
	public String getNombre() {
		return this.nombre;
	}
	public void setFechaNacimiento(String fechaNacimiento) {
		this.fechaNacimiento=fechaNacimiento;
	}
	public String getFechaNacimiento() {
		return this.fechaNacimiento;
	}
	public void setSexo(String sexo) {
		this.sexo=sexo;
	}
	public String getSexo() {
		return this.sexo;
	}
	public void setId(String id) {
		this.id=id;
	}
	public String getId() {
		return this.id;
	}
	public void setEscuela(String escuela) {
		this.escuela=escuela;
	}
	public String getEscuela() {
		return this.escuela;
	}
	public void setGrado(String grado) {
		this.grado=grado;
	}
	public String getGrado() {
		return this.grado;
	}
	public void setGrupo(String grupo) {
		this.grupo=grupo;
	}
	public String getGrupo() {
		return this.grupo;
	}
}