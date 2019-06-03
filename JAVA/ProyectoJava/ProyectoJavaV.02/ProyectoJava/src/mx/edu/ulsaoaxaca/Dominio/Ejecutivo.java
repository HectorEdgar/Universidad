package mx.edu.ulsaoaxaca.Dominio;

public class Ejecutivo extends Empleado {
	private static final long serialVersionUID = -6263016312183328587L;
	private String bono;

	public String getBono() {
		return bono;
	}

	public void setBono(String bono) {
		this.bono = bono;
	}
	
	@Override
	public String desplegarInformacion(){
	String informacion = super.desplegarInformacion() + "El bono del ejecutivo es :" + this.bono ;
		
		return 	informacion;
		
	}

	@Override
	public String calcularSueldo(){
	double sumaBonos = 0.0 ;
	String sueldoTotal = "";
	double sueldo = 0.0;
	
	sumaBonos = sumaBonos + Double.parseDouble(this.getBono());
	sueldo = Double.parseDouble(super.calcularSueldo()) + sumaBonos;
	
	sueldoTotal = Double.toString(sueldo);
	
		return 	sueldoTotal;
		
	}
}
