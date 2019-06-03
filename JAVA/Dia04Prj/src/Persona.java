import java.util.ArrayList;

public class Persona {
	private String id;
	private String nombre;
	private String fechaNacimiento;
	private String sexo;
	private ArrayList<Domicilio> domiciliosParticulares = new ArrayList<Domicilio>();
	private ArrayList<Domicilio> domiciliosFiscales = new ArrayList<Domicilio>();
	
	

	public Persona(){
		
	}
	public ArrayList<Domicilio> getDomiciliosParticular() {
		return this.domiciliosParticulares;
	}

	public void setDomiciliosParticular(Domicilio domiciliosParticulares) {
		this.domiciliosParticulares.add(domiciliosParticulares);
	}

	public ArrayList<Domicilio> getDomiciliosFiscales() {
		return this.domiciliosFiscales;
	}

	public void setDomiciliosFiscales(Domicilio domiciliosFiscales) {
		this.domiciliosFiscales.add(domiciliosFiscales);
	}
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
	
}
