package mx.edu.ulsaoaxaca.interfaz;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

@SuppressWarnings("serial")
public class PanelValidacion extends JPanel {
	private JLabel jlCuenta;
	private JLabel jlContrasena;
	private JLabel jlInicio;
	private JTextField jtCuenta;
	private JTextField jtContrasena;
	private JButton bValidar;
	
	public PanelValidacion(){
		this.setLayout(null);
		int x=100,y=100;
		
		this.jlInicio =  new JLabel("Inicio de sesion");
		jlInicio.setBounds(x+195, 20, 500, 50);
		
		this.jlCuenta=new JLabel("Cuenta");
		jlCuenta.setBounds(x+195, y, 50, 50);
		this.jtCuenta=new JTextField();
		jtCuenta.setBounds(x+120, y=y+40, 200, 20);
		
		
		this.jlContrasena = new JLabel("Contraseña");
		jlContrasena.setBounds(x+195, y=y+40, 150, 60);
		this.jtContrasena = new JTextField();
		jtContrasena.setBounds(x+120, y=y+40, 200, 20);
		
		this.bValidar = new JButton("Validar");
		bValidar.setBounds(x+220, y=y+50, 100, 20);
		
		this.add(jlCuenta);
		this.add(jlContrasena);
		this.add(jtCuenta);
		this.add(jtContrasena);
		this.add(bValidar);
		this.add(jlInicio);
		
	}
	
	
}
