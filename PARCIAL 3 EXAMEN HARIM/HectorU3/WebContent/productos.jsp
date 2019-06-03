<%@page import="beans.CargaInicialBean,modelo.ProductoModelo,java.util.*"%>
<jsp:useBean id="carga" class="beans.CargaInicialBean" scope="session" />
<%
if(carga.getProductosEnDB().size()==0){
	carga.getCargaInicialDb();
}

List<ProductoModelo> listaProductos = carga.getProductosEnDB();
for(ProductoModelo pm: listaProductos) {

%>

<div class="col-lg-4 col-md-6 mb-4">
	<div class="card h-100">
	<a href="#"><img class="card-img-top img-fluid" src="<%=pm.getPathImg() %>" alt=""></a>
		<div class="card-block">
			<h4 class="card-title"><a href="#"><%=pm.getNombreProducto() %></a></h4>
			<h5>$<%=pm.getPrecio() %></h5>
			<p class="card-text"><%=pm.getDescripcion() %></p>
		</div>
		<div class="card-footer">
			<small class="text-muted">&#9733; &#9733; &#9733; &#9733;&#9734;</small>
		</div>
	</div>
</div>

<%
}
%>
