package dao;

import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import modelo.EventoModelo;

public class EventoJdbc {
	
	public static synchronized boolean insertarEvento(int idEvento, String nombre, Date fecha, String lugar) {
		Connection cn = null;
		PreparedStatement statement = null;
        boolean respuesta = false;
        String sql = "INSERT INTO Evento (idEvento, nombre, fecha, lugar) VALUES (?, ?, ?, ?)";
        try {
        	cn = Conexion.getConexion();
        	statement = cn.prepareStatement(sql);
			statement.setInt(1, idEvento);
			statement.setString(2, nombre);
			statement.setDate(3, fecha);
			statement.setString(4, lugar);
			
			int rowsInserted = statement.executeUpdate();
			if (rowsInserted > 0) {
				System.out.println("Evento insertado en base de datos satisfactoriamente");
				respuesta = true;
			}
	        statement.close();
	        Conexion.cerrarConexion(cn);
	    } catch (SQLException e) {
	        e.printStackTrace();
	        Conexion.deshacerCambios(cn);
	        Conexion.cerrarConexion(cn);
	    } catch (Exception e) {
	        e.printStackTrace();
	        Conexion.deshacerCambios(cn);
	        Conexion.cerrarConexion(cn);
	    }
	    return respuesta;
	}
	
	
	public static synchronized List<EventoModelo> obtenerListaEventos() {
		List<EventoModelo> listaEventos = new ArrayList<EventoModelo>();
		Connection cn = null;
		Statement statement = null;
        String sql = "SELECT * FROM Evento";
        try {
        	cn = Conexion.getConexion();
        	cn.createStatement();
        	statement = cn.createStatement();
        	ResultSet result = statement.executeQuery(sql);
			while (result.next()){
				EventoModelo eventoModelo = 
						new EventoModelo(
								result.getInt(1), //idEvento 
								result.getString(2), //nombre
								result.getDate(3), //fecha, 
								result.getString(4) //lugar
								);
				listaEventos.add(eventoModelo);
			}
			Conexion.cerrarConexion(cn);
        } catch (SQLException e) {
	        e.printStackTrace();
	        Conexion.deshacerCambios(cn);
	        Conexion.cerrarConexion(cn);
	    } catch (Exception e) {
	        e.printStackTrace();
	        Conexion.deshacerCambios(cn);
	        Conexion.cerrarConexion(cn);
	    }
        return listaEventos;
	}
	
}
