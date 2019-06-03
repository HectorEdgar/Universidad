package beans;

import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import modelo.ProductoModelo;

public class CargaInicialBean {
	private List<ProductoModelo> listaProductos = new ArrayList<ProductoModelo>();
	private String cargaInicial;

	public List<ProductoModelo> getListaProductos() {
		return listaProductos;
	}

	public void setListaProductos(List<ProductoModelo> listaProductos) {
		this.listaProductos = listaProductos;
	}

	public String getCargaInicial() {
		ProductoModelo blusa1 = new ProductoModelo();
		blusa1.setPathImg("./img/blusa1.jpg");
		blusa1.setNombreProducto("Blusa Paola Bossi PB1528 manga corta-azul");
		blusa1.setPrecio(130.99);
		blusa1.setDescripcion(
				"Blusa de manga corta, en color azul marino, detalle de malla en la espalda y sublimado de flores en bajos esquinas, excelente para esta primavera");
		listaProductos.add(blusa1);

		ProductoModelo blusa2 = new ProductoModelo();
		blusa2.setPathImg("./img/blusa2.jpg");
		blusa2.setNombreProducto("Blusa Manga Larga Milan Mujer Ejecutivo - Tinto");
		blusa2.setPrecio(382.99);
		blusa2.setDescripcion(
				"Milan dacache. Diseño moderno con el fit perfecto para la mujer de hoy, combinado con cualquier elemento haciendo brillar tu look empresarial.");
		listaProductos.add(blusa2);

		ProductoModelo camisa1 = new ProductoModelo();
		camisa1.setPathImg("./img/camisa1.jpg");
		camisa1.setNombreProducto("Camisa Chic Turn Down-Vino Rojo");
		camisa1.setPrecio(162.22);
		camisa1.setDescripcion("Elegante gira el collar abajo camisa de manga larga color puro para los hombres.");
		listaProductos.add(camisa1);

		ProductoModelo camisa2 = new ProductoModelo();
		camisa2.setPathImg("./img/camisa2.jpg");
		camisa2.setNombreProducto("Blusa Paola Bossi PB1528 manga corta-azul");
		camisa2.setPrecio(289.88);
		camisa2.setDescripcion("Camisa de vestir modelo de la tela clásica botón casual Camisa de los hombres.");
		listaProductos.add(camisa2);

		ProductoModelo reloj = new ProductoModelo();
		reloj.setPathImg("img/blusa1.jpg");
		reloj.setNombreProducto("Relog Montblanc Sport Chronograph");
		reloj.setPrecio(409400.00);
		reloj.setDescripcion(
				"Este relog cronógrafo satisface las más altas exigencias tanto en términos de deporte externo como en apariencia. Elaborado de tantalio y oro rosa de 18K.");
		listaProductos.add(reloj);

		ProductoModelo gafas = new ProductoModelo();
		gafas.setPathImg("./img/gafas.jpg");
		gafas.setNombreProducto("Gafas de sol Christian Dior");
		gafas.setPrecio(289.99);
		gafas.setDescripcion("SKU:CH344FA190OECLMX Modelo: 588658L Color: Plateado.");
		listaProductos.add(gafas);
		
		
		return cargaInicial;
	}

	public void getCargaInicialDb(){
		listaProductos=  new ArrayList<ProductoModelo>();
		ProductoModelo blusa1 = new ProductoModelo();
		blusa1.setPathImg("./img/blusa1.jpg");
		blusa1.setNombreProducto("Blusa Paola Bossi PB1528 manga corta-azul");
		blusa1.setPrecio(130.99);
		blusa1.setDescripcion(
				"Blusa de manga corta, en color azul marino, detalle de malla en la espalda y sublimado de flores en bajos esquinas, excelente para esta primavera");
		listaProductos.add(blusa1);

		ProductoModelo blusa2 = new ProductoModelo();
		blusa2.setPathImg("./img/blusa2.jpg");
		blusa2.setNombreProducto("Blusa Manga Larga Milan Mujer Ejecutivo - Tinto");
		blusa2.setPrecio(382.99);
		blusa2.setDescripcion(
				"Milan dacache. Diseño moderno con el fit perfecto para la mujer de hoy, combinado con cualquier elemento haciendo brillar tu look empresarial.");
		listaProductos.add(blusa2);

		ProductoModelo camisa1 = new ProductoModelo();
		camisa1.setPathImg("./img/camisa1.jpg");
		camisa1.setNombreProducto("Camisa Chic Turn Down-Vino Rojo");
		camisa1.setPrecio(162.22);
		camisa1.setDescripcion("Elegante gira el collar abajo camisa de manga larga color puro para los hombres.");
		listaProductos.add(camisa1);

		ProductoModelo camisa2 = new ProductoModelo();
		camisa2.setPathImg("./img/camisa2.jpg");
		camisa2.setNombreProducto("Blusa Paola Bossi PB1528 manga corta-azul");
		camisa2.setPrecio(289.88);
		camisa2.setDescripcion("Camisa de vestir modelo de la tela clásica botón casual Camisa de los hombres.");
		listaProductos.add(camisa2);

		ProductoModelo reloj = new ProductoModelo();
		reloj.setPathImg("img/blusa1.jpg");
		reloj.setNombreProducto("Relog Montblanc Sport Chronograph");
		reloj.setPrecio(409400.00);
		reloj.setDescripcion(
				"Este relog cronógrafo satisface las más altas exigencias tanto en términos de deporte externo como en apariencia. Elaborado de tantalio y oro rosa de 18K.");
		listaProductos.add(reloj);

		ProductoModelo gafas = new ProductoModelo();
		gafas.setPathImg("./img/gafas.jpg");
		gafas.setNombreProducto("Gafas de sol Christian Dior");
		gafas.setPrecio(289.99);
		gafas.setDescripcion("SKU:CH344FA190OECLMX Modelo: 588658L Color: Plateado.");
		listaProductos.add(gafas);
		
		for (ProductoModelo productoModelo : listaProductos) {
			insertarProductoEnBd(productoModelo.getPathImg(), productoModelo.getNombreProducto(), productoModelo.getPrecio(), productoModelo.getDescripcion());
		}
		
	}
	public synchronized  boolean insertarProductoEnBd(String pathImg, String nombreProducto, Double precio,
			String descripcion) {
		Connection cn = null;
		PreparedStatement statement = null;
		boolean respuesta = false;
		String url = "jdbc:mysql://localhost:3306/tienda_en_linea";
		String user = "root";
		String password = "admin";

		String sql = "INSERT INTO productos(pathImg, nombreProducto, precio, descripcion) VALUES ('" + pathImg + "', '"
				+ nombreProducto + "', " + precio.doubleValue() + ", '" + descripcion + "')";
		try {

			Class.forName("com.mysql.jdbc.Driver");
			cn = DriverManager.getConnection(url, user, password);

			statement = cn.prepareStatement(sql);

			int rows = statement.executeUpdate(sql);
			if (rows > 0) {

				respuesta = true;
			}
			statement.close();
			cn.close();
		} catch (SQLException e) {
			e.printStackTrace();

		} catch (Exception e) {
			e.printStackTrace();
		} finally{
			cn=null;
			statement=null;
		}
		return respuesta;
	}

	public synchronized List<ProductoModelo> getProductosEnDB() {
		List<ProductoModelo> listaEventos = new ArrayList<ProductoModelo>();
		Connection cn = null;
		PreparedStatement statement = null;
		boolean respuesta = false;
		String url = "jdbc:mysql://localhost:3306/tienda_en_linea";
		String user = "root";
		String password = "admin";
		String sql = "SELECT * FROM productos";
		try {
			Class.forName("com.mysql.jdbc.Driver");
			cn = DriverManager.getConnection(url, user, password);

			statement = cn.prepareStatement(sql);
			ResultSet result = statement.executeQuery();
			while (result.next()) {
				ProductoModelo eventoModelo = new ProductoModelo();
				eventoModelo.setPathImg(result.getString(2)); 
				eventoModelo.setNombreProducto(result.getString(3)); 
				eventoModelo.setPrecio(Double.parseDouble(result.getString(4)));  
				eventoModelo.setDescripcion(result.getString(5));
				listaEventos.add(eventoModelo);
			}
			cn.close();
		} catch (SQLException e) {
			e.printStackTrace();
		} catch (Exception e) {
			e.printStackTrace();
		}
		return listaEventos;
	}

	public void setCargaInicial(String cargaInicial) {
		this.cargaInicial = cargaInicial;
	}

}
