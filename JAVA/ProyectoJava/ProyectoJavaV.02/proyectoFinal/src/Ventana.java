import java.awt.BorderLayout;
import java.awt.CardLayout;
import java.awt.Panel;

import javax.swing.JFrame;

public class Ventana extends JFrame {
	// constantes de clase 
	public static final int ANCHO = 1024;
	public  static final  int  ALTO = 768 ;
	
	/*
public static final int ANCHO = 1024;
	public  static final  int  ALTO = 768 ;
	 */

	public Ventana (){
		Panel1 panel1 = new Panel1();
		this.setExtendedState(JFrame.MAXIMIZED_BOTH);
		this.setTitle("Ventana Test");
		this.setSize(ANCHO,ALTO);
		this.setVisible(true);
		panel1.setVisible(true);
		this.add(panel1);
		this.setLocationRelativeTo(null);
		
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
}
