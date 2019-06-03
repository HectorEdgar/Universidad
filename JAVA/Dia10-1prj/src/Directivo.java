public class Directivo extends Empleado {
	
	private static final long serialVersionUID = 883659372759003440L;
	private String accion;
	
	public Directivo(){
		
	}

	public String getAccion() {
		return accion;
	}

	public void setAccion(String accion) {
		this.accion = accion;
	}
	
	@Override
	public String desplegarInformacion() {
		
		return super.desplegarInformacion()+"\nAccion: "+ this.accion;
		
	}
	
	@Override
	public String calcularSueldo(){
		Double sumaSueldo=0.0;
		sumaSueldo=Double.parseDouble(super.calcularSueldo())+Double.parseDouble(this.accion);
		return String.valueOf(sumaSueldo);
		
		
	}
}