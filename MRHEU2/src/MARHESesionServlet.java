
import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.apache.coyote.Request;

@WebServlet("/MARHESesionServlet")
public class MARHESesionServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;

	public MARHESesionServlet() {
		super();
		// TODO Auto-generated constructor stub
	}

	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		PrintWriter out = response.getWriter();
		HttpSession session = request.getSession();
		if (session.getAttribute("cronos") == null) {

			session.setAttribute("cronos", "1");

		} else {
			session.setAttribute("cronos", (Integer.parseInt((session.getAttribute("cronos").toString())) + 1));
		}

		response.setContentType("text/html");
		out.println("Matias Rodriguez Héctor Edgar" 
		+ request.getSession().getAttribute("cronos"));
		
		if (Integer.parseInt(session.getAttribute("cronos").toString()) == 15) {
			session.setAttribute("cronos", "0");
		} else {
			if (Integer.parseInt(session.getAttribute("cronos").toString()) >= 10) {
				out.println("<form action='./HectorEdgarTablero.jsp' method='get'>" 
			+"...<input type='submit' value='Continuar'>"
			+ "</form>");
			}
		}
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
