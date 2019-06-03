<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
	<title>Noticias</title>
	<%@ include file="../librerias.jsp" %>
</head>
<body>
	<!-- Noticias
    	================================================== -->
	<jsp:useBean id="mensajesBean" class="modelo.MensajesBean" />
	
	<div class="container">
		
		<!-- menus -->
		<jsp:include page="encabezado.jsp"/>
		<jsp:setProperty name="mensajesBean" property="mensaje" 
						value="concursos de programación y robótica" />
								
		<!-- Jumbotron -->
		<div class="jumbotron">
			<h1>Noticias</h1>
			<p class="lead">Eventos proximos...<br/>
				<jsp:getProperty name="mensajesBean" property="mensaje" />
			</p>
			<p>
				<a class="btn btn-lg btn-success" href="http://www.conacyt.mx/posgrados" role="button">Conacyt</a>
			</p>
		</div>
		
		<!-- Un renglon y tres columnas -->
		<div class="row">
			<div class="col-lg-4">
				<jsp:include page="articuloUno.jsp">
					<jsp:param value="<%=request.getContextPath() + \"/img/sanJuan.png\" %>" name="imgPath"/>
				</jsp:include>
			</div>
			<!-- /.span4 -->
			<div class="col-lg-4">
				<jsp:include page="articuloDos.jsp">
						<jsp:param value="<%=request.getContextPath() + \"/img/ulsatron.png\" %>" name="imgPath"/>
				</jsp:include>
			</div>
			<!-- /.span4 -->
			<div class="col-lg-4">
				<jsp:include page="articuloTres.jsp">
					<jsp:param value="<%=request.getContextPath() + \"/img/culturas.png\" %>" name="imgPath"/>
				</jsp:include>
			</div>
			<!-- /.span4 -->
		</div>
		<!-- /.row -->
		
	</div>
</body>
</html>