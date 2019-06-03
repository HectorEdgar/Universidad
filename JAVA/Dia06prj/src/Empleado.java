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
		String particular = "";
		String fiscal = "";
		
for(Domicilio e : this.domiciliosParticulares ){
			
			particular = "\n\nDOMICILIO PARTICULAR\n\nCALLE: "+e.getCalle() + "\nCOLONIA: "+
			e.getColonia() +"\nENTIDAD FEDERATIVA: "+ e.getEntidadFederativa() + "\nMUNICIPIO: " +
					e.getMunicipio() +  "\nCP: "+ e.getCp() ;
			 
		}
			for(Domicilio k : this.domiciliosFiscales ){
			
				fiscal = "\n\n*DOMICILIO FISCAL:\n"+"\nCALLE: "+k.getCalle() + "\nCOLONIA: "
				+ k.getColonia() +"\nENTIDAD FEDERATIVA: "+k.getEntidadFederativa() + "\nMUNICIPIO: " +
						k.getMunicipio() +  "\nCP: "+ k.getCp() ;
				 
			}
		
		//Domicilio arrayDomicilioParticularN = (Domicilio)domiciliosParticulares.get(0);
		//Domicilio arrayDomicilioFiscalN = (Domicilio)domiciliosFiscales.get(0);
	//	return this.getId() +" "+ this.getNombre() +" "+ this.getFechaNacimiento() +" "+
	//	this.getSexo() +" "+ this.nss+" " +" "+ this.sueldo;
		String informacion= 
				"\nID: "+this.getId()+
				"\nNOMBRE:"+this.getNombre()+
				"\nFECHA DE NACIMIENTO: "+this.getFechaNacimiento()+
				"\nSEXO: "+this.getSexo()+
				"\nNSS: "+ this.nss+" "+
				"\nSUELDO: "+this.sueldo+ particular+fiscal;
				
			/*	"		Domicilio Particular:"+arrayDomicilioParticularN.getCalle()+
				" "+arrayDomicilioParticularN.getColonia()+
				" "+arrayDomicilioParticularN.getMunicipio()+
				" "+arrayDomicilioParticularN.getEntidadFederativa()+
				" "+arrayDomicilioParticularN.getCp()+
				
				"		Domicilio Fiscal:"+arrayDomicilioFiscalN.getCalle()+
				" "+arrayDomicilioFiscalN.getColonia()+
				" "+arrayDomicilioFiscalN.getMunicipio()+
				" "+arrayDomicilioFiscalN.getEntidadFederativa()+
				" "+arrayDomicilioFiscalN.getCp();
				*/
		return informacion;
		
	}
}
