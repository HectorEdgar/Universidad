package mx.edu.ulsaoaxaca.interfaz;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

import mx.edu.ulsaoaxaca.Dao.EmpleadoDao;
import mx.edu.ulsaoaxaca.Dao.EmpleadoDaoImpl;
import mx.edu.ulsaoaxaca.Dominio.Domicilio;
import mx.edu.ulsaoaxaca.Dominio.Empleado;

@SuppressWarnings("serial")
public class PanelAltaEmpleado extends JPanel {

	private JLabel jlTituloRegistro;

	private JLabel jlNombre;
	private JTextField jtNombre;

	private JLabel jlFechaNacimiento;
	private JTextField jtFechaNacimiento;

	private JLabel jlSexo;
	private JTextField jtSexo;

	private JLabel jlNss;
	private JTextField jtNss;

	private JLabel jlSueldo;
	private JTextField jtSueldo;

	private JLabel jlDomicilioParticular;

	private JLabel jlDomicilioParticularCalle;
	private JTextField jtDomicilioParticularCalle;

	private JLabel jlDomicilioParticularColonia;
	private JTextField jtDomicilioParticularColonia;

	private JLabel jlDomicilioParticularEntidadFederativa;
	private JTextField jtDomicilioParticularEntidadFederativa;

	private JLabel jlDomicilioParticularMunicipio;
	private JTextField jtDomicilioParticularMunicipio;

	private JLabel jlDomicilioParticularCodigoPostal;
	private JTextField jtDomicilioParticularCodigoPostal;

	private JCheckBox jcDomicilioFiscal;
	private JCheckBox jcDomicilioParticular;
	private JButton jbAgregarDomicilios;
	public int numeroDomicilios = 0;
	public int numeroDomiciliosParticulares = 0;

	private JButton jbAgregar;

	public PanelAltaEmpleado() {

		Empleado emp = new Empleado();

		this.setLayout(null);
		int y = 50;
		int x = 20;
		this.jlTituloRegistro = new JLabel("Registro de empleados: ");
		this.jlTituloRegistro.setBounds(x + 320, y - 30, 150, 30);

		this.jlNombre = new JLabel("Nombre: ");
		this.jlNombre.setBounds(x, y + 30, 250, 20);
		this.jtNombre = new JTextField();
		this.jtNombre.setBounds(x + 300, y + 30, 200, 20);

		this.jlFechaNacimiento = new JLabel("Fecha de nacimiento (yyyy-mm-dd): ");
		this.jlFechaNacimiento.setBounds(x, y + 60, 250, 20);
		this.jtFechaNacimiento = new JTextField();

		this.jtFechaNacimiento.setBounds(x + 300, y + 60, 200, 20);

		this.jlSexo = new JLabel("Sexo (M/F): ");
		this.jlSexo.setBounds(x, y + 90, 250, 20);
		this.jtSexo = new JTextField();
		this.jtSexo.setBounds(x + 300, y + 90, 200, 20);

		this.jlNss = new JLabel("Nss: ");
		this.jlNss.setBounds(x, y + 120, 250, 20);
		this.jtNss = new JTextField();
		this.jtNss.setBounds(x + 300, y + 120, 200, 20);

		this.jlSueldo = new JLabel("Sueldo: ");
		this.jlSueldo.setBounds(x, y + 150, 250, 20);
		this.jtSueldo = new JTextField();
		this.jtSueldo.setBounds(x + 300, y + 150, 200, 20);

		this.jlDomicilioParticular = new JLabel("Domicilio Particular: ");
		this.jlDomicilioParticular.setBounds(x, y + 200, 250, 20);

		this.jlDomicilioParticularCalle = new JLabel("Calle : ");
		this.jlDomicilioParticularCalle.setBounds(x, y + 230, 250, 20);
		this.jtDomicilioParticularCalle = new JTextField();
		this.jtDomicilioParticularCalle.setBounds(x + 300, y + 230, 200, 20);

		this.jlDomicilioParticularColonia = new JLabel("Colonia : ");
		this.jlDomicilioParticularColonia.setBounds(x, y + 260, 250, 20);
		this.jtDomicilioParticularColonia = new JTextField();
		this.jtDomicilioParticularColonia.setBounds(x + 300, y + 260, 200, 20);

		this.jlDomicilioParticularEntidadFederativa = new JLabel("Entidad federativa : ");
		this.jlDomicilioParticularEntidadFederativa.setBounds(x, y + 290, 250, 20);
		this.jtDomicilioParticularEntidadFederativa = new JTextField();
		this.jtDomicilioParticularEntidadFederativa.setBounds(x + 300, y + 290, 200, 20);

		this.jlDomicilioParticularMunicipio = new JLabel("Municipio : ");
		this.jlDomicilioParticularMunicipio.setBounds(x, y + 320, 250, 20);
		this.jtDomicilioParticularMunicipio = new JTextField();
		this.jtDomicilioParticularMunicipio.setBounds(x + 300, y + 320, 200, 20);

		this.jlDomicilioParticularCodigoPostal = new JLabel("Codigo postal : ");
		this.jlDomicilioParticularCodigoPostal.setBounds(x, y + 350, 250, 20);
		this.jtDomicilioParticularCodigoPostal = new JTextField();
		this.jtDomicilioParticularCodigoPostal.setBounds(x + 300, y + 350, 200, 20);

		this.jbAgregar = new JButton("Registrar");
		this.jbAgregar.setBounds(x + 600, y + 480, 150, 30);

		this.jcDomicilioFiscal = new JCheckBox("Domicilio Fiscal");
		this.jcDomicilioFiscal.setBounds(x + 200, y + 200, 150, 20);

		this.jcDomicilioParticular = new JCheckBox("Domicilio Particular");
		this.jcDomicilioParticular.setBounds(x + 350, y + 200, 160, 20);

		this.jbAgregarDomicilios = new JButton("Agregar Domicilio");
		this.jbAgregarDomicilios.setBounds(x + 520, y + 200, 150, 20);

		this.add(jlTituloRegistro);
		this.add(jlNombre);
		this.add(jtNombre);
		this.add(jlSexo);
		this.add(jtSexo);
		this.add(jlNss);
		this.add(jtNss);
		this.add(jlSueldo);
		this.add(jtSueldo);
		this.add(jlDomicilioParticular);
		this.add(jbAgregar);
		this.add(jtFechaNacimiento);
		this.add(jlFechaNacimiento);
		this.add(jlDomicilioParticularCalle);
		this.add(jtDomicilioParticularCalle);
		this.add(jlDomicilioParticularColonia);
		this.add(jtDomicilioParticularColonia);
		this.add(jlDomicilioParticularEntidadFederativa);
		this.add(jtDomicilioParticularEntidadFederativa);
		this.add(jlDomicilioParticularMunicipio);
		this.add(jtDomicilioParticularMunicipio);
		this.add(jlDomicilioParticularCodigoPostal);
		this.add(jtDomicilioParticularCodigoPostal);
		this.add(jbAgregarDomicilios);
		this.add(jcDomicilioFiscal);
		this.add(jcDomicilioParticular);

		this.jbAgregar.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {

				if (jcDomicilioParticular.isSelected() == false && jcDomicilioFiscal.isSelected() == false) {
					JOptionPane.showMessageDialog(null, "Marque una casilla");

				} else if (numeroDomiciliosParticulares == 0) {
					JOptionPane.showMessageDialog(null, "Agrege un domicilio particular");
				} else if (jtNombre.getText().trim().length() == 0) {
					JOptionPane.showMessageDialog(null, "Ingresa el Nombre");
				} else if (jtFechaNacimiento.getText().trim().length() == 0) {
					JOptionPane.showMessageDialog(null, "Ingresa la Fecha de nacimiento");
				} else if (jtSexo.getText().trim().length() == 0) {
					JOptionPane.showMessageDialog(null, "Ingresa el Sexo");
				} else if (jtNss.getText().trim().length() == 0) {
					JOptionPane.showMessageDialog(null, "Ingresa el Nss");
				} else if (jtSueldo.getText().trim().length() == 0) {
					JOptionPane.showMessageDialog(null, "Ingresa el Sueldo");
				} else {
					int id = (int) System.currentTimeMillis();
					emp.setId(String.valueOf(id));
					emp.setNombre(jtNombre.getText());
					emp.setFechaNacimiento(jtFechaNacimiento.getText());
					emp.setSexo(jtSexo.getText());
					emp.setNss(jtNss.getText());
					emp.setSueldo(jtSueldo.getText());

					EmpleadoDao empDao = new EmpleadoDaoImpl();
					int filasAfectadas = empDao.GrabarEmpleado(emp);
					if (filasAfectadas != 0) {
						JOptionPane.showMessageDialog(null, "Datos agregados Correctamente");
					} else {
						JOptionPane.showMessageDialog(null, "Ha ocurrido un error");
					}
				}
			}
		});

		this.jbAgregarDomicilios.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent arg0) {

				Domicilio dom = new Domicilio();
				if (jtDomicilioParticularCalle.getText().trim().length() == 0) {
					JOptionPane.showMessageDialog(null, "Ingresa la calle");
				} else if (jtDomicilioParticularColonia.getText().trim().length() == 0) {
					JOptionPane.showMessageDialog(null, "Ingresa Colonia");
				} else if (jtDomicilioParticularMunicipio.getText().trim().length() == 0) {
					JOptionPane.showMessageDialog(null, "Ingresa el municipio");
				} else if (jtDomicilioParticularEntidadFederativa.getText().trim().length() == 0) {
					JOptionPane.showMessageDialog(null, "Ingresa la entidad federativa");
				} else if (jtDomicilioParticularCodigoPostal.getText().trim().length() == 0) {
					JOptionPane.showMessageDialog(null, "Ingresa el codigo postal");
				} else if (jcDomicilioParticular.isSelected() == true && jcDomicilioFiscal.isSelected() == false) {
					dom.setCalle(jtDomicilioParticularCalle.getText());
					dom.setColonia(jtDomicilioParticularColonia.getText());
					dom.setMunicipio(jtDomicilioParticularMunicipio.getText());
					dom.setEntidadFederativa(jtDomicilioParticularEntidadFederativa.getText());
					dom.setCp(jtDomicilioParticularCodigoPostal.getText());
					emp.setDomicilioParticular(dom);
					numeroDomicilios = numeroDomicilios + 1;
					numeroDomiciliosParticulares = numeroDomiciliosParticulares + 1;
					JOptionPane.showMessageDialog(null, "Se agreg� Domicilio");

				} else if (jcDomicilioParticular.isSelected() == false && jcDomicilioFiscal.isSelected() == true) {
					dom.setCalle(jtDomicilioParticularCalle.getText());
					dom.setColonia(jtDomicilioParticularColonia.getText());
					dom.setMunicipio(jtDomicilioParticularMunicipio.getText());
					dom.setEntidadFederativa(jtDomicilioParticularEntidadFederativa.getText());
					dom.setCp(jtDomicilioParticularCodigoPostal.getText());
					emp.setDomicilioFiscal(dom);
					numeroDomicilios = numeroDomicilios + 1;
					JOptionPane.showMessageDialog(null, "Se agreg� Domicilio");
				} else {
					JOptionPane.showMessageDialog(null, "Marque una casilla");
				}

			}
		});

	}

}
