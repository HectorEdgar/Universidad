
public class Ejecutivo extends Empleado {
	
	private static final long serialVersionUID = -6263016312183328587L;
	private String bono;
	public Ejecutivo(){
		
	}
	public String getBono() {
		return bono;
	}
	public void setBono(String bono) {
		this.bono = bono;
	}

	public String desplegarInformacion() {
		
		return super.desplegarInformacion()+"\n Bono:"+this.bono+"\n\n";
	}
	@Override
	public String calcularSueldo(){
		double sumaSueldo=0.0;
		sumaSueldo=	Double.parseDouble(super.calcularSueldo())+Double.parseDouble(this.bono);
		
		return String.valueOf(sumaSueldo);
	}
	
}
