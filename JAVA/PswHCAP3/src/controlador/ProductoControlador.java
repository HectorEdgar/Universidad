package controlador;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import dao.ProductoJdbc;
import modelo.ProductoModelo;

/**
 * Servlet implementation class ProductoControlador
 */
@WebServlet("/ProductoControlador")
public class ProductoControlador extends HttpServlet {
	
	private void procesarSolicitud(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String accion = request.getParameter("accion");
        if (accion.equals("RegistrarProducto")) {
            this.registrarProducto(request, response);
        }
	}
	
	private void registrarProducto(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        ProductoModelo p = new ProductoModelo();
        p.setNombre(request.getParameter("txtNombre").toUpperCase());
        p.setPrecio(Double.parseDouble(request.getParameter("txtPrecio")));
        boolean respuesta = ProductoJdbc.insertarProducto(p);
        if (respuesta) {
            //Si inserto lo redireccionamos a otra pagina que se llama "agregarProducto.jsp"
            response.sendRedirect("vista/agregarProducto.jsp?insertar=true&mensaje=Se registro del producto de manera correcta");
        } else {
            //Si no se inserto lo redireccionamos a otra pagina que se llama "agregarProducto.jsp"
            response.sendRedirect("vista/agregarProducto.jsp?insertar=false&mensaje=No se registro el producto");
        }
    }
    
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		procesarSolicitud(request, response);
	}
	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		procesarSolicitud(request, response);
	}

}
