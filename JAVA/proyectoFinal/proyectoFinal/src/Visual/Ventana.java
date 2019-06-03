package Visual;

import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JFrame;
import javax.swing.JOptionPane;

public class Ventana extends JFrame{
	public static final int ANCHO = 1024;
	public static final int ALTO = 768;
	
	public Ventana() {
		this.setTitle("Sistema Final");
		this.setSize(ANCHO, ALTO);
		this.setVisible(true);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.setExtendedState(JFrame.MAXIMIZED_BOTH);
		
		PanelLogin panelLogin = new PanelLogin();
		this.add(panelLogin);
		//this.pack();
		
	
		}
}
