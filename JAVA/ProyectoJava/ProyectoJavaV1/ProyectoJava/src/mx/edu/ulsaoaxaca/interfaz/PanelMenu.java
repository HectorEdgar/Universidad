package mx.edu.ulsaoaxaca.interfaz;

import javax.swing.JButton;
import javax.swing.JPanel;

public class PanelMenu extends JPanel{
	private JButton jbAlta;
	private JButton jbReporte;
	private JButton jbBuscar;
	private JButton jbNomina;
	private JButton jbSalir;
	
	
	public PanelMenu(){
		this.setLayout(null);
		
		int x = 100, y = 100;
		
		this.jbAlta =new JButton("Alta de empleados");
		this.jbAlta.setBounds(x, y, 20, 20);
		
		
		this.add(jbAlta);
	}
	

}
