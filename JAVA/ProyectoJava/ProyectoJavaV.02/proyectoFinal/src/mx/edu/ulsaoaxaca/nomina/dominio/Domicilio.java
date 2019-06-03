package mx.edu.ulsaoaxaca.nomina.dominio;
import java.io.Serializable;

public class Domicilio  implements Serializable {
	
	private static final long serialVersionUID = 8521996262606387400L;
	
	private String calle;
	private String colonia;
	private String municipio;
	private String entidadFederativa;
	private String cp;
	
	public Domicilio() {}

	public String getCalle() {
		return calle;
	}

	public void setCalle(String calle) {
		this.calle = calle;
	}

	public String getColonia() {
		return colonia;
	}

	public void setColonia(String colonia) {
		this.colonia = colonia;
	}

	public String getMunicipio() {
		return municipio;
	}

	public void setMunicipio(String municipio) {
		this.municipio = municipio;
	}

	public String getEntidadFederativa() {
		return entidadFederativa;
	}

	public void setEntidadFederativa(String entidadFederativa) {
		this.entidadFederativa = entidadFederativa;
	}

	public String getCp() {
		return cp;
	}

	public void setCp(String cp) {
		this.cp = cp;
	}
	
	

}
