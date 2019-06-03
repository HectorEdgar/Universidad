package mx.edu.ulsaoaxaca.interfaz;

import java.util.ArrayList;

import javax.swing.JLabel;
import javax.swing.JPanel;

import mx.edu.ulsaoaxaca.Dao.NominaDao;
import mx.edu.ulsaoaxaca.Dao.NominaDaoImpl;
import mx.edu.ulsaoaxaca.Dominio.Persona;

@SuppressWarnings("serial")
public class PanelCalcularNomina extends JPanel {
	private JLabel jlTitulo;
	private JLabel jlEmpleados;
	private JLabel jlEjecutivos;
	private JLabel jlDirectivos;
	private JLabel jlNominatotal;
	private JLabel jlEmpleadosNomina;
	private JLabel jlEjecutivosNomina;
	private JLabel jlDirectivosNomina;

	public PanelCalcularNomina() {
		this.setLayout(null);
		int y=300;
		double nominaEmpleado = 0.0;
		double nominaEjecutivo = 0.0;
		double nominaDirectivo = 0.0;
		double totalNomina = 0.0;
		try {
			NominaDao nomina = new NominaDaoImpl();
			ArrayList<Persona> listaEmpleados = nomina.CalcularNomina();

			
			for (Persona p : listaEmpleados) {

				Object claseEmpleado = p.getClass();
				String tipoEmpleado = claseEmpleado.toString();
				if (tipoEmpleado == "Empleado") {
					nominaEmpleado = nominaEmpleado + Double.parseDouble(p.calcularSueldo());
				}
				if (tipoEmpleado == "Ejecutivo") {
					nominaEjecutivo = nominaEjecutivo + Double.parseDouble(p.calcularSueldo());
				}
				if (tipoEmpleado == "Directivo") {
					nominaDirectivo = nominaDirectivo + Double.parseDouble(p.calcularSueldo());
				}
				totalNomina = totalNomina + Double.parseDouble(p.calcularSueldo());

				// System.out.printf("%s",p.getClass());
			}
		} catch (Exception e) {
			e.getStackTrace();

		}

		this.jlTitulo = new JLabel("Reporte de nomina");
		this.jlTitulo.setBounds(300, y, 100, 30);

		this.jlEmpleados = new JLabel("Empleados");
		this.jlEmpleados.setBounds(300, y=y+20, 100, 30);
		this.jlEmpleadosNomina = new JLabel(String.valueOf(nominaEmpleado));
		this.jlEmpleadosNomina.setBounds(300, y=y+20, 100, 30);

		this.jlEjecutivos = new JLabel("Ejecutivos");
		this.jlEjecutivos.setBounds(300, y=y+20, 100, 30);
		this.jlEjecutivosNomina = new JLabel(String.valueOf(nominaEjecutivo));
		this.jlEjecutivosNomina.setBounds(y=y+20, 100, 160, 30);

		this.jlDirectivos = new JLabel("Directivos");
		this.jlDirectivos.setBounds(300, y=y+20, 100, 30);
		this.jlDirectivosNomina = new JLabel(String.valueOf(nominaDirectivo));
		this.jlDirectivosNomina.setBounds(y=y+20, 100, 160, 30);

		this.jlNominatotal = new JLabel("Nomina Total "+String.valueOf(nominaEjecutivo));
		this.jlNominatotal.setBounds(300, y=y+20, 100, 130);

				this.add(jlTitulo);
		this.add(jlEmpleados);
		this.add(jlEjecutivos);
		this.add(jlDirectivos);
		this.add(jlNominatotal);
	}

}
