

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet("/MRHEServlet")
public class MRHEServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public MRHEServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		PrintWriter out = response.getWriter();
		response.setContentType("text/html");
		Cookie[] cookies=request.getCookies();
		if(cookies!=null){
			for (int i = 0; i < cookies.length; i++) {
				if(cookies[i].getName().equals("diezSegundos")){
					
					out.println("<form action='./MARHESesionServlet' method='get'>"
							+ "<input type='submit' value='Continuar'>"
							+ "</form>"
							+ "");
					return;
				}
			}
			
		}
		
		out.println("No se encontro la cookie creando...");
		mrheCookie10(response);
		
		
		//response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	private void mrheCookie10(HttpServletResponse response){
		Cookie c = new Cookie("diezSegundos", null);
		c.setMaxAge(10);
		response.addCookie(c);
		
	}
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
