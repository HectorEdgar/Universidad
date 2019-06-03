package mx.edu.ulsaoaxaca.empleado.interfaz;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Date;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

import mx.edu.ulsaoaxaca.empleado.dao1.EmpleadoDAO;
import mx.edu.ulsaoaxaca.empleado.dao1.EmpleadoDAOImpl;
import mx.edu.ulsaoaxaca.empleado.dominio.Empleado;


public class Panel1 extends JPanel {
	private JButton boton1;
	private JLabel etiqueta1;
	private JLabel etiqueta2;
	private JLabel etiqueta3;
	private JLabel etiqueta4;
	private JLabel etiqueta5;
	private JTextField caja1;
	private JTextField caja2;
	private JTextField caja3;
	private JTextField caja4;
	private JTextField caja5;

	// private ArrayList<Empleado> empleadoN = new ArrayList<Empleado>();

	public Panel1() {

		// CONTROL
		this.setLayout(null);
		int x = 10;
		int y = 20;

		this.etiqueta1 = new JLabel("Nombre:");
		etiqueta1.setBounds(x, y, 60, 20);
		y = y + 20;
		this.caja1 = new JTextField();
		this.caja1.setBounds(x, y, 200, 20);

		y = y + 20;
		this.etiqueta2 = new JLabel("Fecha de Nacimiento:");
		etiqueta2.setBounds(x, y, 150, 20);
		y = y + 20;
		this.caja2 = new JTextField();
		this.caja2.setBounds(x, y, 200, 20);
		y = y + 20;

		this.etiqueta3 = new JLabel("Sexo:");
		etiqueta3.setBounds(x, y, 150, 20);
		y = y + 20;
		this.caja3 = new JTextField();
		this.caja3.setBounds(x, y, 200, 20);
		y = y + 20;

		this.etiqueta4 = new JLabel("NSS:");
		etiqueta4.setBounds(x, y, 60, 20);
		y = y + 20;
		this.caja4 = new JTextField();
		this.caja4.setBounds(x, y, 200, 20);
		y = y + 20;

		this.etiqueta5 = new JLabel("Sueldo :");
		etiqueta5.setBounds(x, y, 150, 20);
		y = y + 20;
		this.caja5 = new JTextField();
		this.caja5.setBounds(x, y, 200, 20);

		this.boton1 = new JButton("Grabar");
		boton1.setBounds(x, 300, 80, 30);

		AccionBoton listener = new AccionBoton();
		this.boton1.addActionListener(listener);

		/*
		 * boton1.addActionListener(new ActionListener() { public void
		 * actionPerformed(ActionEvent e) { // Dao para grabar el empleado en
		 * base de datos
		 * 
		 * nombre = caja1.getText(); fechaNacimiento = caja2.getText(); sexo =
		 * caja3.getText(); nss = caja4.getText(); sueldo = caja5.getText();
		 * 
		 * 
		 * 
		 * System.out.printf("%s%s%s%s%s",nombre,fechaNacimiento,sexo,nss,sueldo
		 * ); System.out.printf("Grabar %s %n", new Date().toString()); } });
		 */
		this.add(this.boton1);
		this.add(this.caja1);
		this.add(this.caja2);
		this.add(this.caja3);
		this.add(this.caja4);
		this.add(this.caja5);
		this.add(this.etiqueta1);
		this.add(this.etiqueta2);
		this.add(this.etiqueta3);
		this.add(this.etiqueta4);
		this.add(this.etiqueta5);

	}
private void caja5KeyTyped(java.awt.event.KeyEvent evt){
	
	char c =evt.getKeyChar();
	if(c<='0' && c>='9') evt.consume();
	
}
	private class AccionBoton implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent e) {
			if (caja1.getText().trim().length() == 0) {
				JOptionPane.showMessageDialog(null, "Ingresa el Nombre");
			} else if (caja2.getText().trim().length() == 0) {
				JOptionPane.showMessageDialog(null, "Ingresa la Fecha de nacimiento");
			} else if (caja3.getText().trim().length() == 0) {
				JOptionPane.showMessageDialog(null, "Ingresa el Sexo");
			} else if (caja4.getText().trim().length() == 0) {
				JOptionPane.showMessageDialog(null, "Ingresa el Nss");
			} else if (caja5.getText().trim().length() == 0) {
				JOptionPane.showMessageDialog(null, "Ingresa el Sueldo");
				double a=Double.parseDouble(caja5.getText().trim());
				if( a == 0){
					JOptionPane.showMessageDialog(null, "Ingresa el Sueldo");
					
				}
			} else {
				int afectacionesFilas=0;
				Empleado empleado1 = new Empleado();
				empleado1.setNombre(caja1.getText());
				empleado1.setFechaNacimiento(caja2.getText());
				empleado1.setSexo(caja3.getText());
				empleado1.setNss(caja4.getText());
				empleado1.setSueldo(caja5.getText());

				EmpleadoDAO em = new EmpleadoDAOImpl();
				afectacionesFilas=em.GrabarEmpleado(empleado1);
				if(afectacionesFilas!=0){
				JOptionPane.showMessageDialog(null, "Se agrego correctamente");
				System.out.printf("Grabado el dia %s %n", new Date().toString());
				}
			}

		}

	}

}
