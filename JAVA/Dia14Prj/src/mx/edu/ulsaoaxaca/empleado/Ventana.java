package mx.edu.ulsaoaxaca.empleado;
import javax.swing.JFrame;

import mx.edu.ulsaoaxaca.empleado.Panel1;

public class Ventana extends javax.swing.JFrame {
	public static final int ANCHO=640;
	public static final int ALTO=480;
	public Ventana(){
		this.setTitle("Ventana Test");
		this.setSize(ANCHO, ALTO);
		this.setVisible(true);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		//Seteo de Boton
		
		Panel1 panel1=new Panel1();
		panel1.setVisible(true);
		this.add(panel1);
	}
}
