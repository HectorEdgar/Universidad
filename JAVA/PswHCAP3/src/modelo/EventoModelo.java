package modelo;

import java.sql.Date;

public class EventoModelo {
	
	private int idEvento;
	private String nombre;
	private Date fecha;
	private String lugar;
	
	public EventoModelo() { }
	
	public EventoModelo(int idEvento, String nombre, Date fecha, String lugar) {
		super();
		this.idEvento = idEvento;
		this.nombre = nombre;
		this.fecha = fecha;
		this.lugar = lugar;
	}

	public int getIdEvento() {
		return idEvento;
	}

	public void setIdEvento(int idEvento) {
		this.idEvento = idEvento;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public Date getFecha() {
		return fecha;
	}

	public void setFecha(Date fecha) {
		this.fecha = fecha;
	}

	public String getLugar() {
		return lugar;
	}

	public void setLugar(String lugar) {
		this.lugar = lugar;
	}
	
}
