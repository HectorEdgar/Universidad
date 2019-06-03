package Dominio;
import java.io.Serializable;

public class Ejecutivo extends Empleado implements Serializable {
	/**
	 * 
	 */
	private static final long serialVersionUID = 5774418027742613783L;
	
	private String bono;

	
	
	
	public Ejecutivo() {}

	public String getBono() {
		return bono;
	}

	public void setBono(String bono) {
		this.bono = bono;
	}
	
	@Override
	public String mostrarInformacion() {
		return super.mostrarInformacion() + "\nBono: $" + this.bono;
	}
	
	
	
	@Override
	public String mostrarSueldo(){
		
		return Double.toString(Double.parseDouble(super.mostrarSueldo()) + Double.parseDouble(this.bono));
	}
	
}
