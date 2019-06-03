import java.awt.BorderLayout;
import java.awt.CardLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.HeadlessException;
import java.awt.Point;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.ArrayList;
import java.util.List;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.ListSelectionModel;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import javax.swing.table.DefaultTableCellRenderer;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.JTableHeader;

import DAO.NominaDAOImpl;
import mx.edu.ulsaoaxaca.nomina.dominio.*;;

public class Panel1 extends JPanel{ 
	private JButton boton1;
	private JButton boton2;
	private JLabel etiqueta1;
	private JLabel etiqueta2;
	private JTextField caja2;
	final private JTable tabla;
	private DefaultTableModel modelo;
	private JScrollPane scrollPane;
	public static String id = "";
	public Panel1 (){



		this.setLayout(null);
		// Control 

		this.etiqueta1 =  new JLabel ("Buscar empleado");
		etiqueta1.setBounds(210, 30, 140, 20);

		this.etiqueta2 =  new JLabel ("Nombre empleado:");
		etiqueta2.setBounds(40, 90, 140, 20);

		this.caja2 = new JTextField();
		this.caja2.setBounds(160, 90, 180, 20);

		this.boton1 = new JButton("Buscar");
		this.boton1.setBounds(400, 90, 80, 20);

		this.boton2 = new JButton("Editar ");
		this.boton2.setBounds(450, 550, 90, 20);

		/*this.etiqueta1 =  new JLabel ("Buscar empleado");
		etiqueta1.setBounds(420, 30, 140, 20);

		this.etiqueta2 =  new JLabel ("Nombre del empleado:");
		etiqueta2.setBounds(80, 90, 140, 20);

		this.caja2 = new JTextField();
		this.caja2.setBounds(220, 90, 300, 20);

		this.boton1 = new JButton("Buscar");
		this.boton1.setBounds(600, 90, 80, 20);
		 */
		String titulos[] = {"Empleado","id","clase"};

		modelo = new DefaultTableModel();
		modelo.setColumnIdentifiers(titulos);

		//	this.tabla.setModel(modelo);
		tabla = new JTable(modelo);
		tabla.setColumnSelectionAllowed(true);
		tabla.setEnabled(false);
		// tabla.setAutoResizeMode(JTable.AUTO_RESIZE_OFF);

		tabla.getTableHeader().setReorderingAllowed(false);
		// tabla.setPreferredScrollableViewportSize(new Dimension(500, 70));
		scrollPane= new JScrollPane(tabla);
		scrollPane.setBounds(40, 130, 500, 400);


		//tabla.removeColumn(tabla.getColumnModel().getColumn(1));

		boton1.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e) {

				for (int i = 0; i < tabla.getRowCount(); i++) {
					modelo.removeRow(i);
					i-=1;
				}
				if (caja2.getText().trim().length() == 0){
					JOptionPane.showMessageDialog(null, "Ingresa el nombre del Empleado");
				}
				else {

					NominaDAOImpl buscar = new NominaDAOImpl();
					List<Empleado> lista = new ArrayList <Empleado>();

					lista = buscar.selectEmpleados(caja2.getText());

					String[] fila = new String[modelo.getColumnCount()];

					if (lista == null){

						JOptionPane.showMessageDialog(null, "No se encontro ningun empleado");
					}
					else{
						for(Persona l :lista){
							fila[0] = l.getNombre();
							fila[1]= l.getId();
							fila[2] = l.getClass().toString();
							modelo.addRow(fila);
						}

					}

				}

			}
		});





		tabla.addMouseListener(new MouseAdapter() {
			public void mouseClicked(MouseEvent e) {


				if (e.getClickCount() == 1) {

					JTable target = (JTable)e.getSource();
					int f = target.getSelectedRow();
					f=f+1;
					int c = target.getSelectedColumn();
					tabla.setRowSelectionInterval(0,0 );

					if (f>-1){


						System.out.printf("fila:%s, columna:%s",f,c);

						JOptionPane.showMessageDialog(null, "selecciono la fila:"+f+"y la columna: "+c+"");
						String mensaje = tabla.getValueAt(f, 1).toString();
						JOptionPane.showMessageDialog(null, "mensaje:"+mensaje+"");
						id = mensaje;
						JOptionPane.showMessageDialog(null, "id:"+id+"");
					}
				}
			}
		});


		boton2.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent k) {
				panelEditarEmpleado panelEditarEmpleado = new panelEditarEmpleado();
				//panelEditarEmpleado.setSize(1024,768);
				//panelEditarEmpleado.setLocation(650,110);
				panelEditarEmpleado.setBounds(650,110,1024,768);

				removeAll();
				add(panelEditarEmpleado,BorderLayout.CENTER);
				revalidate();
				repaint();
							}

		});



		this.add(this.etiqueta1);

		this.add(this.caja2);
		this.add(this.etiqueta2);

		this.add(this.boton1);
		this.add(this.boton2);
		this.add(scrollPane);


	}

}
