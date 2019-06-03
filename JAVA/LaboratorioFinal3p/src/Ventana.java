import javax.swing.JFrame;

public class Ventana extends JFrame {
	
	public void ventana(){
		
		Panel1 panel1 = new Panel1();
		panel1.setVisible(true);
		this.add(panel1);
		
	
		this.setTitle("Inicio de secion");
		this.setSize(400, 400);
		setLocationRelativeTo(null);
		this.setVisible(true);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

}
