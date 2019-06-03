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
			<form action="contacto.jsp" class="form-horizontal">
				<div class="form-group">
					<label for="email" class="control-label col-xs-2">Email</label>
					<div class="col-xs-10">
						<input type="email" class="form-control" id="email" name="email" placeholder="ejemplo@mail.com">
					</div>
				</div>
				<div class="form-group">
					<label for="comentarios" class="control-label col-xs-2">Comentarios</label>
					<div class="col-xs-10">
			            <textarea class="form-control" id="comentarios" name="comentarios"></textarea>
			        </div>
				</div>
				<div class="form-group">
					<div class="col-xs-offset-2 col-xs-10">
						<div class="checkbox">
							<label><input type="checkbox" id="novedades" name="novedades">Recibir novedades</label>
						</div>
					</div>
				</div>
				<div class="form-group">
					<div class="col-xs-offset-2 col-xs-10">
						<button type="submit" class="btn btn-primary">Enviar</button>
					</div>
				</div>
			</form>
		</div>
		
		<%
		String email = request.getParameter("email") != null ? request.getParameter("email") : "";
		String comentarios = request.getParameter("comentarios") != null ? request.getParameter("comentarios") : "";
		String novedades = request.getParameter("novedades") != null ? request.getParameter("novedades") : "";
		
		if( !email.equals("") && !comentarios.equals("") ) {
		
		%>
			<!-- procesar envio -->
			<jsp:useBean id="contactoBean" class="modelo.ContactoBean" scope="session" />
			
			<jsp:setProperty name="contactoBean" property="email" value="<%=email %>"/>
			<jsp:setProperty name="contactoBean" property="comentarios" value="<%=comentarios %>"/>
			<jsp:setProperty name="contactoBean" property="novedades" value="<%=novedades %>"/>
			
			<jsp:forward page="procesarContacto.jsp" >
				<jsp:param name="activo" value="contacto"/>
			</jsp:forward>
		<%
		}
		%>
		
	</div>

</body>
</html>