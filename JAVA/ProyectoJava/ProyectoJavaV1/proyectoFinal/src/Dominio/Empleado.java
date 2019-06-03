package Dominio;
import java.util.ArrayList;
import java.io.Serializable;

public class Empleado extends Persona implements Serializable{

	
	/**
	 * 
	 */
	private static final long serialVersionUID = 4748926363842950473L;
	
	private String nss;
	private String sueldo;

	private ArrayList<Domicilio> domiciliosParticulares = new ArrayList<Domicilio>();
	private ArrayList<Domicilio> domiciliosFiscales = new ArrayList<Domicilio>();
	
	public Empleado() {
		
	}

	public String getNss() {
		return nss;
	}

	public void setNss(String nss) {
		this.nss = nss;
	}

	public String getSueldo() {
		return sueldo;
	}

	public void setSueldo(String sueldo) {
		this.sueldo = sueldo;
	}
	
	public ArrayList<Domicilio> getDomiciliosParticulares() {
		return this.domiciliosParticulares;
	}
	
	public void setDomicilioParticular(Domicilio domicilioParticular) {
		this.domiciliosParticulares.add(domicilioParticular);
	}
	
	public void setDomiciliosParticulares(ArrayList<Domicilio> domiciliosParticulares) {
		this.domiciliosParticulares = domiciliosParticulares;
	}

	public ArrayList<Domicilio> getDomiciliosFiscales() {
		return this.domiciliosFiscales;
	}
	
	public void setDomicilioFiscal(Domicilio domicilioFiscal) {
		this.domiciliosFiscales.add(domicilioFiscal);
	}
	
	@Override
	public String mostrarInformacion() {
		
		//almacenar domicilios particulares
		String domiciliosParticulares = "";
		for(Domicilio d1: this.domiciliosParticulares) {
			domiciliosParticulares = 
			domiciliosParticulares + "\n\n--Domicilio Particular--\n" + 
			 "\nCalle: " + d1.getCalle()+
			 "\nColonia: " + d1.getColonia() + 
			 "\nMunicipio: " + d1.getMunicipio()+ 
			 "\nCodigo Postal: " + d1.getCodigoPostal() + 
			 "\nEntidad federativa: "+ d1.getEntidadFederativa();
		}
		
		//almacenar domicilios fiscales
		String domiciliosFiscales = "";
		for(Domicilio d2: this.domiciliosFiscales) {
			domiciliosFiscales = 
			domiciliosFiscales + 
			"\n\n--Domicilio Fiscal--\n" + 
			"\nCalle: " + d2.getCalle()+ 
			"\nColonia: " + d2.getColonia() + 
			"\nMunicipio: " + d2.getMunicipio()+ 
			"\nCodigo Postal: " + d2.getCodigoPostal() + 
			"\nEntidad federativa: "+ d2.getEntidadFederativa();
		}
		
		return  "\nID: " + this.getId() + 
				" \nNombre: " + this.getNombre() + 
				" \nFecha Nacimiento: " + this.getFechaNacimiento() + 
				" \nSexo: " + this.getSexo() + 
				"\nNSS: " + this.nss + 
				" \nSuedo: $" +  this.sueldo + 
				domiciliosParticulares + domiciliosFiscales;
	}
	
	
	
	@Override
	public String mostrarSueldo() {
		return this.sueldo;
	}
	

	
}
