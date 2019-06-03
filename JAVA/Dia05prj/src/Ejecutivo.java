public class Ejecutivo extends Empleado {
	private String bono;
	

	public Ejecutivo(){
		
	}

	public String getBono() {
		return bono;
	}

	public void setBono(String bono) {
		this.bono = bono;
	}
	
	public String desplegarInformacion(String informacion1){
	
		return this.bono;
	}
	
}
