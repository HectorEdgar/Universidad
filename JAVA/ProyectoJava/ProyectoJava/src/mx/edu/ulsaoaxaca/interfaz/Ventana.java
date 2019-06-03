package mx.edu.ulsaoaxaca.interfaz;


import javax.swing.JFrame;

@SuppressWarnings("serial")
public class Ventana extends JFrame {

	public static final int ANCHO = 1024;
	public static final int ALTO = 768;

	public Ventana() {
		PanelValidacion panel1 =new PanelValidacion();
		
		this.add(panel1);
	
		
		this.setTitle("Ventana Test");
		this.setSize(ANCHO, ALTO);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.setVisible(true);

	}
}
