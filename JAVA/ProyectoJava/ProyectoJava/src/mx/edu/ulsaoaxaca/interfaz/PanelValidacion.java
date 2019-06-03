package mx.edu.ulsaoaxaca.interfaz;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

import mx.edu.ulsaoaxaca.Dao.Dao;
import mx.edu.ulsaoaxaca.Dao.DaoImpl;
import mx.edu.ulsaoaxaca.Dominio.Cuenta;

@SuppressWarnings("serial")
public class PanelValidacion extends JPanel {
	private JLabel jlCuenta;
	private JLabel jlContrasena;
	private JLabel jlInicio;
	private JTextField jtCuenta;
	private JTextField jtContrasena;
	private JButton bValidar;

	public PanelValidacion() {
		this.setLayout(null);
		int x = 100, y = 100;

		this.jlInicio = new JLabel("Inicio de sesion");
		jlInicio.setBounds(x + 200, 20, 500, 50);

		this.jlCuenta = new JLabel("Cuenta");
		jlCuenta.setBounds(x + 225, y, 50, 50);
		this.jtCuenta = new JTextField();
		jtCuenta.setBounds(x + 140, y = y + 40, 200, 20);

		this.jlContrasena = new JLabel("Contraseña");
		jlContrasena.setBounds(x + 225, y = y + 40, 150, 60);
		this.jtContrasena = new JTextField();
		jtContrasena.setBounds(x + 140, y = y + 40, 200, 20);

		this.bValidar = new JButton("Validar");
		bValidar.setBounds(x + 220, y = y + 150, 100, 20);

		AccionBValidar listener = new AccionBValidar();
		this.bValidar.addActionListener(listener);

		this.add(jlCuenta);
		this.add(jlContrasena);
		this.add(jtCuenta);
		this.add(jtContrasena);
		this.add(bValidar);
		this.add(jlInicio);

	}

	private class AccionBValidar implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent e) {
			Cuenta cuenta1 = new Cuenta();
			Cuenta cuentaValidada = new Cuenta();
			cuenta1.setUsuario(jtCuenta.getText());
			cuenta1.setContrasena(jtContrasena.getText());
			
			Dao da = new DaoImpl();
			
			cuentaValidada=da.ValidarUsuario(cuenta1);
			if (cuentaValidada != null){
				JOptionPane.showMessageDialog(null, "ok");
			}else 
				JOptionPane.showMessageDialog(null, "Datos incorrectos");
				

		}
	}
}
