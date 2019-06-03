package mx.edu.ulsaoaxaca.interfaz;

import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
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
		this.jlInicio.setBounds(x+180, 40, 500, 50);
		
		this.jlCuenta=new JLabel("Cuenta");
		this.jlCuenta.setBounds(x+120, y, 50, 50);
		this.jtCuenta=new JTextField();
		this.jtCuenta.setBounds(x+120, y=y+40, 200, 20);
		
		
		this.jlContrasena = new JLabel("Contraseña");
		this.jlContrasena.setBounds(x+120, y=y+40, 150, 60);
		this.jtContrasena = new JPasswordField();
		this.jtContrasena.setBounds(x+120, y=y+40, 200, 20);
		
		this.bValidar = new JButton("Validar");
		this.bValidar.setBounds(x+218, y=y+50, 100, 20);
		
		this.add(jlCuenta);
		this.add(jlContrasena);
		this.add(jtCuenta);
		this.add(jtContrasena);
		this.add(bValidar);
		this.add(jlInicio);
		
		this.bValidar.addActionListener(new ActionListener (){

			@Override
			public void actionPerformed(ActionEvent e) {
				PanelMenuPrincipal menu1 = new PanelMenuPrincipal();
				menu1.setBounds(0,0,1024,768);
				
				removeAll();
				
				revalidate();
				
				add(menu1,BorderLayout.CENTER);
				repaint();
				
			}
			
			
			
			
			
		});
		
	}
	
	
}
