package mx.edu.ulsaoaxaca.nomina.dominio;
import java.util.ArrayList;

public class Empleado extends Persona {
	
	private static final long serialVersionUID = -468528403538017081L;
	private String sueldo;
	private String nss;
	
	private ArrayList <Domicilio> domiciliosParticulares = new ArrayList<Domicilio>();
	private ArrayList <Domicilio> domiciliosFiscales = new ArrayList <Domicilio>();
	
	public Empleado() {}

	public String getSueldo() {
		return sueldo;
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

	public ArrayList<Domicilio> getDomiciliosParticulares() {
		return this.domiciliosParticulares;
	}

	public void setDomicilioParticular(Domicilio domicilioParticular) {
		this.domiciliosParticulares.add(domicilioParticular);
	}

	public ArrayList <Domicilio> getDomiciliosFiscales() {
		return domiciliosFiscales;
	}

	public void setDomicilioFiscal(Domicilio domicilioFiscal) {
		this.domiciliosFiscales.add(domicilioFiscal);
	}
	//Sobreescritura (Overrite)
	//La herencia no rompe la encapsulacion (seguridad)
	// guarda la informacion y se debe implementar en el Test
	@Override
	public String desplegarInformacion() {
		String particular = "";
		String fiscal = "";
		
		//String informacion =  this.getId () + " " + this.getNombre() + " "+ this.getFechaNacimiento() + " " + 
			//	this.getSexo() + " " + this.nss + " " +  this.sueldo;
		
		
		for(Domicilio e : this.domiciliosParticulares ){
			
			particular = particular + " "+ e.getCalle() + " "+ e.getColonia() +" "+ e.getEntidadFederativa() + " " + e.getMunicipio() +  " "+ e.getCp() ;
			 
		}
		for(Domicilio k : this.domiciliosFiscales ){
			
				fiscal = fiscal + " "+ k.getCalle() + " "+ k.getColonia() +" "+k.getEntidadFederativa() + " " + k.getMunicipio() +  " "+ k.getCp() ;
				 
		}
		return "\nNombre:"+ this.getNombre() + 
					" \nId: "+ this.getId() + 
					"\nFecha de nacimiento: "+ this.getFechaNacimiento()+
					"\nSexo: "+ this.getSexo() + 
					"\nNumero Seguro Social:" + this.getNss()+
					"\nSueldo: "+this.getSueldo()+
					"\nDireccion Particular:" + particular + 
					" \nDireccion Fiscal: "+ fiscal + "\n\n";
	}
	@Override
	public String calcularSueldo() {
		
		double sueldo = 0.0;
		String sueldoTotal = "";
		sueldo = sueldo + Double.parseDouble(this.getSueldo());
		sueldoTotal = Double.toString(sueldo);
		return  sueldoTotal;
		
	}
	}
	
	
