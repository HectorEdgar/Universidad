<%
	String parametro = (request.getParameter("activo") != null) ? request.getParameter("activo") : "";
%>
<div class="masthead">
	<nav>
		<ul class="nav nav-pills pull-right">
			<li class="<%=parametro.equals("inicio") ? "active" : "" %>">
				<a href="<%=request.getContextPath() + "/vista/home.jsp?activo=inicio" %>">Inicio</a>
			</li>
			<li class="<%=parametro.equals("producto") ? "active" : "" %>">
				<a href="<%=request.getContextPath() + "/vista/agregarProducto.jsp?activo=inicio" %>">Productos</a>
			</li>
			<li class="<%=parametro.equals("evento") ? "active" : "" %>">
				<a href="<%=request.getContextPath() + "/vista/evento.jsp?activo=inicio" %>">Eventos</a>
			</li>
			<li class="<%=parametro.equals("contacto") ? "active" : "" %>">
				<a href="<%=request.getContextPath() + "/vista/contacto.jsp?activo=contacto" %>">Contacto</a>
			</li>
			<li>
				<form id="frmLogout" action="../index.jsp">
					<input type="hidden" id="logout" name="logout" value="cerrarSesion" />
					<button type="submit" class="btn btn-success">Cerrar Sesion</button>
				</form>
			</li>
		</ul>
		<h3 class="muted">JSP Unidad Tres</h3>
	</nav>
</div>