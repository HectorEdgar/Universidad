package mx.edu.ulsaoaxaca.interfaz;

import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;

@SuppressWarnings("serial")
public class PanelMenuAltaEmpleados extends JPanel {
	private JLabel jlTituloAlta;
	private JButton jbEmpleado;
	private JButton jbDirectivo;
	private JButton jbEjecutivo;

	public PanelMenuAltaEmpleados() {
		this.setLayout(null);
		int y = 130;
		this.jlTituloAlta = new JLabel("Menu alta de empleado");
		this.jlTituloAlta.setBounds(330, y-30, 200, 40);

		this.jbEmpleado = new JButton("Empleado");
		this.jbEmpleado.setBounds(300, y+50, 200, 40);

		this.jbDirectivo = new JButton("Directivo");
		this.jbDirectivo.setBounds(300, y+100, 200, 40);

		this.jbEjecutivo = new JButton("Ejecutivo");
		this.jbEjecutivo.setBounds(300, y+150, 200, 40);

		this.add(jlTituloAlta);
		this.add(jbEmpleado);
		this.add(jbDirectivo);
		this.add(jbEjecutivo);

		this.jbEmpleado.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent arg0) {
				PanelAltaEmpleado panelempleado = new PanelAltaEmpleado();
				panelempleado.setBounds(0, 0, 840, 680);
				removeAll();
				repaint();
				revalidate();
				add(panelempleado, BorderLayout.CENTER);

			}

		});

		this.jbEjecutivo.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				PanelAltaEjecutivo panelEjecutivo = new PanelAltaEjecutivo();
				panelEjecutivo.setBounds(0, 0, 840, 680);
				removeAll();
				repaint();
				revalidate();
				add(panelEjecutivo, BorderLayout.CENTER);

			}
		});

		this.jbDirectivo.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				PanelAltaDirectivo panelDirectivo = new PanelAltaDirectivo();
				panelDirectivo.setBounds(0, 0, 840, 680);
				removeAll();
				repaint();
				revalidate();
				add(panelDirectivo, BorderLayout.CENTER);

			}

		});

	}

}
