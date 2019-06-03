
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

	public String desplegarInformacion1() {
		super.desplegarInformacion();
		String empleadoInformacion = desplegarInformacion();
		String bonoEjecutivo= bono;
		return empleadoInformacion+"\n Bono:"+bonoEjecutivo+"\n\n";
	}
}
