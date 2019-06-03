package mx.edu.ulsaoaxaca.Dominio;

public class Directivo extends Empleado{
	private static final long serialVersionUID = 883659372759003440L;

	public Directivo(){
	}
	public String getAccion() {
		return accion;
	}
	
	public void setAccion(String accion) {
		this.accion = accion;
	}

	private String accion;

@Override
public String desplegarInformacion() {
	return super.desplegarInformacion() + "Las acciones son:" + this.accion;
}

@Override
public String calcularSueldo() {
	
	double accion = 0.0;
	String sueldoTotal = "";
	double total = 0.0;
	
	accion = accion + Double.parseDouble(this.getAccion());
	total =  Double.parseDouble(super.calcularSueldo())+ accion;
	sueldoTotal = Double.toString(total);
	return  sueldoTotal;
	
}
}