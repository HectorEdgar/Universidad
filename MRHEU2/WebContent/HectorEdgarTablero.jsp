<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body bgcolor="#ECF6CE">
	<center>
		<h1>Matias Rodriguez Héctor Edgar</h1>
	</center>
	<center>
		
			<%String texto="";
			if(request.getParameter("radiobtn")!=null){
				texto=request.getParameter("radiobtn");
			}else{
				texto="";
			}
			
				out.println("<Table >");
				int cont = 0;
				for (int i = 0; i <= 7; i++) {

					out.println("<tr>");

					for (int j = 0; j <= 7; j++) {

						if ((cont % 2) == 0) {
							out.println("<td height='50px' width='50px' bgcolor='black'></td>");

						} else {
							out.println("<td height='50px' width='50px' bgcolor='white'>"+texto+"</td>");
						}
						cont++;

					}
					cont++;
					out.println("</tr>");
				}
				out.println("</Table>");
				
				if(texto.equals("Rey")){
					
				}
			%>
	<form action="#" method="get">
	
		Rey<input type="radio" name="radiobtn" value="Rey"><br>
		Caballo<input type="radio" name="radiobtn" value="Caballo"><br>
		Alfil<input type="radio" name="radiobtn" value="Alfil"><br>
		Torre<input type="radio" name="radiobtn" value="Torre"><br>
		Torre<input type="radio" name="radiobtn" value="Rey"><br>
		<input type="submit" value="Colocar">
	</form>
	</center>
</body>
</html>