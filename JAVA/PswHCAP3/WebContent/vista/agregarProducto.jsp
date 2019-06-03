<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
	<title>Contacto</title>
	<%@ include file="../librerias.jsp" %>
	<%@ page import="dao.ProductoJdbc, modelo.ProductoModelo, java.util.List"%>
</head>
<body>

	<div class="container">
		
		<!-- menus -->
		<jsp:include page="encabezado.jsp"/>
		
		<!-- salto de linea -->
		<div class="clearfix">&nbsp</div>
		<div class="clearfix">&nbsp</div>
		
		<div class="row">
			<form action="../ProductoControlador" class="form-horizontal" >
				<input type="hidden" name="accion" value="RegistrarProducto" />
				<div class="form-group">
					<label for="txtNombre" class="control-label col-xs-2">Nombre</label>
					<div class="col-xs-10">
						<input type="text" class="form-control" id="txtNombre" name="txtNombre">
					</div>
				</div>
				<div class="form-group">
					<label for="txtPrecio" class="control-label col-xs-2">Precio</label>
					<div class="col-xs-10">
						<input type="text" class="form-control" id="txtPrecio" name="txtPrecio">
					</div>
				</div>
				<div class="form-group">
					<div class="col-xs-offset-2 col-xs-10">
						<button type="submit" class="btn btn-primary">Registrar</button>
					</div>
				</div>
			</form>
		</div>
		
		<!-- salto de linea -->
		<div class="clearfix">&nbsp</div>
		<div class="clearfix">&nbsp</div>
		
		<%
		String insertar = request.getParameter("insertar") != null ? request.getParameter("insertar") : "";
		if( !insertar.equals("") ) {
			String cssClass = insertar.equals("true") ? "alert-success" : "alert-warning";
		%>
		<div class="row">
			<div class="alert <%=cssClass %>" role="alert">
				<%= request.getParameter("mensaje")%>
			</div>
		</div>
		<%
		}
		%>
		
		<div class="row">
            <table class="table table-hover">
                <tr class="danger">
                    <td colspan="3">Lista de Productos</td>

                </tr>
                <tr class="info">
                    <td>Codigo</td>
                    <td>Nombre</td>
                    <td>Precio</td>
                </tr>
                <%
					List<ProductoModelo> lista = ProductoJdbc.obtenerListaProductos();
                    for (ProductoModelo pm : lista) {
                %>
                <tr>
                    <td><%= pm.getCodigoProducto() %></td>
                    <td><%= pm.getNombre() %></td>
                    <td>$<%= pm.getPrecio() %></td>
                </tr>
                <%
					}
                %>

            </table>
        </div>
		
	</div>

</body>
</html>