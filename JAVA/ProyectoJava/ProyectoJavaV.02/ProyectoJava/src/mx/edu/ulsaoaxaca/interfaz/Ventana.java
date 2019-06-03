package mx.edu.ulsaoaxaca.interfaz;


import javax.swing.JFrame;

@SuppressWarnings("serial")
public class Ventana extends JFrame {

	public static final int ANCHO = 840;
	public static final int ALTO = 640;

	public Ventana() {
		PanelValidacion panel1 =new PanelValidacion();
		
		this.add(panel1);
	
		//this.setExtendedState(JFrame.MAXIMIZED_BOTH);
		this.setTitle("Ventana Test");
		this.setSize(ANCHO, ALTO);
		panel1.setVisible(true);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.setVisible(true);
		this.setLocationRelativeTo(null);
	}
}
