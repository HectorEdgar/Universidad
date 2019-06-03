<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
	<title>Contacto</title>
	<%@ include file="../librerias.jsp"%>
</head>
<body>
	<jsp:useBean id="mensajesBean" class="modelo.MensajesBean" />
	<div class="container">
		<!-- menus -->
		<jsp:include page="encabezado.jsp" />
		<!-- salto de linea -->
		<div class="clearfix">&nbsp</div>
		<div class="clearfix">&nbsp</div>

		<!-- procesar envio -->
		<jsp:useBean id="contactoBean" class="modelo.ContactoBean" scope="session" />

		<ul class="list-group">
			<li class="list-group-item list-group-item-info">
				<%
					modelo.ContactoBean bean = (modelo.ContactoBean) session.getAttribute("contactoBean");
					if (bean != null) {
						out.println("El bean \"ContactoBean\" esta en session");
					}
				%>
			</li>
			<li class="list-group-item">
				<p class="bg-success col-xs-2">Email:</p>
				<jsp:getProperty name="contactoBean" property="email" />
			</li>
			<li class="list-group-item">
				<p class="bg-success col-xs-2">Comentarios:</p>
				<jsp:getProperty name="contactoBean" property="comentarios" />
			</li>
			<li class="list-group-item">
				<p class="bg-success col-xs-2">Recibir novedades:</p>
				<%=bean.getNovedades().equals("on") ? "Si" : "No"%>
			</li>
		</ul>
	</div>
	
	<% //Eliminar el bean de sesion 
		session.removeAttribute("contactoBean");
	%>
	
</body>
</html>