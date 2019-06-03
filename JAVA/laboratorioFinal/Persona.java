public class Persona {
	private String nombre;
	private String fechaNacimiento;
	private String sexo;
	private String id;
	
	public Persona(){
		
	}
	
	public void setNombre(String nombre){
		this.nombre=nombre;
	}
	public String getNombre(){
		return this.nombre;
	}
	
	public void setFechaNacimiento(String fechaNacimiento){
		this.fechaNacimiento=fechaNacimiento;
	}
	public String getFechaNacimiento(){
		return this.fechaNacimiento;
	}
	
	public void setSexo(String sexo){
		this.sexo=sexo;
	}
	public String getSexo(){
		return this.sexo;
	}
	
	public void setId(String id){
		this.id=id;
	}
	public String getId(){
		return this.id;
	}
}