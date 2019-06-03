import javax.swing.JFrame;

public class Ventana extends JFrame {
	// constantes de clase
	public static final int ANCHO = 640;
	public static final int ALTO = 480;

	public Ventana() {

		Panel1 panel1 = new Panel1();
		panel1.setVisible(true);
		this.add(panel1);
		
		this.setTitle("Ventana Test");
		this.setSize(ANCHO, ALTO);
		setLocationRelativeTo(null);

		this.setVisible(true);

		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

	}
}
