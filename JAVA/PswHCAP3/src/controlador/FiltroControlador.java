package controlador;

import java.io.IOException;
import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;
import javax.servlet.annotation.WebFilter;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import dao.LoginJdbc;

/**
 * Servlet Filter implementation class FiltroControlador
 */
@WebFilter("/FiltroControlador")
public class FiltroControlador implements Filter {

    /**
     * Default constructor. 
     */
    public FiltroControlador() {
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see Filter#destroy()
	 */
	public void destroy() {
		// TODO Auto-generated method stub
	}

	/**
	 * @see Filter#doFilter(ServletRequest, ServletResponse, FilterChain)
	 */
	public void doFilter(ServletRequest request, ServletResponse response, FilterChain chain) throws IOException, ServletException {
		System.out.println("Trabajando el filtro");
		HttpServletRequest req = (HttpServletRequest) request;
        HttpServletResponse res = (HttpServletResponse) response;
        HttpSession session = req.getSession(false);
        String loginURI = req.getContextPath() + "/index.jsp"; //"/LoginControler";
        
        System.out.println("loginURI: " + loginURI);
        
        boolean loggedIn = session != null && session.getAttribute("usuarioLogeado") != null;
        boolean loginRequest = req.getRequestURI().equals(loginURI);
        
        if (loggedIn || loginRequest) {
        	
        	//Cerrar sesion
        	String logout = req.getParameter("logout");
        	System.out.println("logout: " + logout);
        	if(logout != null) {
        		
        		System.out.println("Cerrando session");
        		HttpSession ses = req.getSession();
            	ses.removeAttribute("usuarioLogeado");
            	ses.invalidate();
            	
            	res.setContentType("text/html");
            	res.setHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
                res.setHeader("Pragma", "no-cache"); // HTTP 1.0.
                //res.setDateHeader("Expires", 0); // Proxies.
                res.setDateHeader("Expires", -1);
                
            	//res.sendRedirect(loginURI);
        	}
        	chain.doFilter(request, response);
        } else {
        	//Autenticacion
        	String usuario = req.getParameter("usuario");
			String clave = req.getParameter("clave");
			System.out.println("usuario: " + usuario + "\tclave: " + clave);
			if(LoginJdbc.login(usuario,clave)==1) {
				session.setAttribute("usuarioLogeado", usuario);
				res.sendRedirect("vista/home.jsp");
			} else {
				res.sendRedirect(loginURI);
			}
        }
	}

	/**
	 * @see Filter#init(FilterConfig)
	 */
	public void init(FilterConfig fConfig) throws ServletException {
		// TODO Auto-generated method stub
	}

}
