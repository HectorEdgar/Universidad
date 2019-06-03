package Dominio;
import java.io.Serializable;

public class Directivo extends Empleado implements Serializable{
	

	
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 5713805660427001340L;

	private String accion;

	
	public Directivo() {}

	public String getAccion() {
		return accion;
	}

	public void setAcciones(String accion) {
		this.accion = accion;
	}
	
	@Override
	public String mostrarInformacion(){
		return super.mostrarInformacion() + "\nAcciones: " + this.accion;
	}

	@Override
	public String mostrarSueldo() {
		
		return Double.toString(Double.parseDouble(super.mostrarSueldo()) + Double.parseDouble(this.accion));
	}
}
