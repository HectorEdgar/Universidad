package mx.edu.ulsaoaxaca.empleado.interfaz;

import javax.swing.JFrame;

public class Ventana extends JFrame {
	// constantes de clase
	public static final int ANCHO = 840;
	public static final int ALTO = 580;

	// definir su constructor
	public Ventana() {
		// tamaño de la ventana
		this.setTitle("Ventana Test");
		this.setSize(ANCHO, ALTO);

		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.setVisible(true);
		// agregar el boton al panel

		Panel1 panel1 = new Panel1();
		this.add(panel1);
	}
}
