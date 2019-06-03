<%@page import="dao.EventoJdbc"%>
<%@page import="modelo.EventoModelo"%>
<%@page import="java.util.List"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
	<title>Contacto</title>
	<%@ include file="../librerias.jsp" %>
</head>
<body>

	<div class="container">
		
		<!-- menus -->
		<jsp:include page="encabezado.jsp"/>
		
		<!-- salto de linea -->
		<div class="clearfix">&nbsp</div>
		<div class="clearfix">&nbsp</div>
		
		<div class="row">
			<form action="../EventoControlador" class="form-horizontal" >
				<input type="hidden" name="accion" value="RegistrarProducto" />
				<div class="form-group">
					<label for="txtNombre" class="control-label col-xs-2">Nombre</label>
					<div class="col-xs-10">
						<input type="text" class="form-control" id="txtNombre" name="txtNombre">
					</div>
				</div>
				<div class="form-group">
					<label for="txtFecha" class="control-label col-xs-2">Fecha</label>
					<div class="col-xs-10">
						<input type="text" class="form-control" id="txtFecha" name="txtFecha">
					</div>
				</div>
				<div class="form-group">
					<label for="txtLugar" class="control-label col-xs-2">Lugar</label>
					<div class="col-xs-10">
						<input type="text" class="form-control" id="txtLugar" name="txtLugar">
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
                    <td colspan="3">Lista de Eventos</td>

                </tr>
                <tr class="info">
                    <td>Nombre</td>
                    <td>Fecha</td>
                    <td>Lugar</td>
                </tr>
                <%
					List<EventoModelo> lista = EventoJdbc.obtenerListaEventos();
                    for (EventoModelo em : lista) {
                %>
                <tr>
                    <td><%= em.getNombre() %></td>
                    <td><%= em.getFecha() %></td>
                    <td>$<%= em.getLugar() %></td>
                </tr>
                <%
					}
                %>

            </table>
        </div>
		
	</div>

</body>
</html>