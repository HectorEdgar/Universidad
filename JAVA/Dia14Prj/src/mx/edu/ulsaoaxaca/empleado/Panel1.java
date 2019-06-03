package mx.edu.ulsaoaxaca.empleado;

import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Calendar;
import java.util.Date;
import java.sql.*;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

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

	// nombre, fecha, sueldo,nss,sexo
	public Panel1() {
		this.setLayout(null);
		int x = 20;
		int y = 50;
		// Controles
		this.etiqueta1 = new JLabel("Nombre:");
		etiqueta1.setBounds(x, 20, 60, 20);
		this.etiqueta2 = new JLabel("Fecha Nacimiento");
		etiqueta2.setBounds(x, 60, 150, 20);
		this.etiqueta3 = new JLabel("Sexo:");
		etiqueta3.setBounds(x, 100, 200, 20);
		this.etiqueta4 = new JLabel("Nss:");
		etiqueta4.setBounds(x, 140, 150, 20);
		this.etiqueta5 = new JLabel("Sueldo:");
		etiqueta5.setBounds(x, 180, 60, 20);

		this.caja1 = new JTextField();
		caja1.setBounds(x, 40, 200, 20);
		this.caja2 = new JTextField();
		caja2.setBounds(x, 80, 200, 20);
		this.caja3 = new JTextField();
		caja3.setBounds(x, 120, 200, 20);
		this.caja4 = new JTextField();
		caja4.setBounds(x, 160, 200, 20);
		this.caja5 = new JTextField();
		caja5.setBounds(x, 200, 200, 20);

		this.boton1 = new JButton("Registrar un Usuario");
		boton1.setBounds(x, 250, 200, 20);
		boton1.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// System.out.printf("Grabar %s %n",new Date().toString())

				try {
					// create a mysql database connection
					/*
					 * String puerto = "3306"; String usuario = "mysql"; String
					 * contrasena = "admin"; String protocolo =
					 * "jdbc:mysql://172.16.21.222:"+puerto+"/empresa";
					 * Connection conex = null;
					 */
					/*
					 * String puerto = "3306"; String myDriver =
					 * "org.gjt.mm.mysql.Driver"; String myUrl =
					 * "jdbc:mysql://172.16.21.222:"+puerto+"/empresa";
					 * Class.forName(myDriver); Connection conex =
					 * DriverManager.getConnection(myUrl, "mysql", "admin");
					 */
					

		});

		this.add(this.etiqueta1);
		this.add(this.caja1);
		this.add(this.boton1);
		this.add(this.etiqueta2);
		this.add(this.caja2);
		this.add(this.etiqueta3);
		this.add(this.etiqueta4);
		this.add(this.etiqueta5);
		this.add(this.caja3);
		this.add(this.caja4);
		this.add(this.caja5);

	}

}