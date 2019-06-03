package mx.edu.ulsaoaxaca.interfaz;

import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;

@SuppressWarnings("serial")
public class PanelMenuPrincipal extends JPanel {

	private JButton jbAlta;
	private JButton jbReporte;
	private JButton jbBusqueda;
	private JButton jbNomina;
	private JButton jbSalir;
	private JLabel jlMenu;

	public PanelMenuPrincipal() {
		this.setLayout(null);
		int y = 130;
		this.jbAlta = new JButton("Alta de empleado");
		this.jbAlta.setBounds(300, y, 200, 40);

		this.jbReporte = new JButton("Generar reporte");
		this.jbReporte.setBounds(300, y + 50, 200, 40);

		this.jbBusqueda = new JButton("Buscar empleado");
		this.jbBusqueda.setBounds(300, y + 100, 200, 40);

		this.jbNomina = new JButton("Calcular nomina");
		this.jbNomina.setBounds(300, y + 150, 200, 40);

		this.jbSalir = new JButton("Salir");
		this.jbSalir.setBounds(300, y + 200, 200, 40);

		this.jlMenu = new JLabel("Menu principal");
		this.jlMenu.setBounds(361, y - 60, 100, 30);

		this.add(jbAlta);
		this.add(jbReporte);
		this.add(jbBusqueda);
		this.add(jbNomina);
		this.add(jbSalir);
		this.add(jlMenu);

		this.jbAlta.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent arg0) {
				PanelMenuAltaEmpleados panelAlta =new PanelMenuAltaEmpleados();
				panelAlta.setBounds(0, 0, 840, 640);
				revalidate();
				removeAll();
				repaint();
				add(panelAlta, BorderLayout.CENTER);
			}

		});

		this.jbBusqueda.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub

			}
		});

		this.jbNomina.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				PanelCalcularNomina panelCalcularNomina = new PanelCalcularNomina();
				panelCalcularNomina.setBounds(0, 0, 840, 640);
				revalidate();
				removeAll();
				repaint();
				add(panelCalcularNomina, BorderLayout.CENTER);
			}
		});
		;

		this.jbReporte.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub

			}
		});
		;

		this.jbSalir.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub

			}
		});
		;

	}

}
