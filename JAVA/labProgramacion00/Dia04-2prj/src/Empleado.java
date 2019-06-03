import java.util.ArrayList;

public class Empleado extends Persona{
	private String sueldo;
	private String nss;
	private ArrayList<Domicilio> domiciliosParticulares = new ArrayList<Domicilio>();
	private ArrayList<Domicilio> domiciliosFiscales = new ArrayList<Domicilio>();
	public Empleado(){
		
	}

	public String getSueldo() {
		return sueldo;
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
	
	public void setSueldo(String sueldo) {
		this.sueldo = sueldo;
	}

	public String getNss() {
		return nss;
	}

	public void setNss(String nss) {
		this.nss = nss;
	}

	//sobreescritura (overwrite)
	//La herencia no rompe con la encapsulacion
	@Override
	public String desplegarInformacion() {
	//	return this.getId() +" "+ this.getNombre() +" "+ this.getFechaNacimiento() +" "+
	//		this.getSexo() +" "+ this.nss+" " +" "+ this.sueldo;
		String informacion= this.getId() +" "+ this.getNombre() +" "+ this.getFechaNacimiento() +" "+
				this.getSexo() +" "+ this.nss+" "+ this.sueldo;
		return informacion;
		
	}
}
