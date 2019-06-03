package mx.edu.ulsaoaxaca.Dominio;

@SuppressWarnings("serial")
public class Cuenta extends Persona {
	private String usuario;
	private String contrasena;
	private String fechaAlta;
	private String fechaCreacion;

	public Cuenta() {

	}

	public String getUsuario() {
		return usuario;
	}

	public void setUsuario(String usuario) {
		this.usuario = usuario;
	}

	public String getContrasena() {
		return contrasena;
	}

	public void setContrasena(String contrasena) {
		this.contrasena = contrasena;
	}

	public String getFechaAlta() {
		return fechaAlta;
	}

	public void setFechaAlta(String fechaAlta) {
		this.fechaAlta = fechaAlta;
	}

	public String getFechaCreacion() {
		return fechaCreacion;
	}

	public void setFechaCreacion(String fechaCreacion) {
		this.fechaCreacion = fechaCreacion;
	}

	@Override
	public String desplegarInformacion() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public String calcularSueldo() {
		// TODO Auto-generated method stub
		return null;
	}

}
