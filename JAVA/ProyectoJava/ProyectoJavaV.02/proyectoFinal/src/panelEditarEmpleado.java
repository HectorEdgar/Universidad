import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.List;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

import DAO.NominaDAOImpl;
import mx.edu.ulsaoaxaca.nomina.dominio.Directivo;
import mx.edu.ulsaoaxaca.nomina.dominio.Domicilio;
import mx.edu.ulsaoaxaca.nomina.dominio.Ejecutivo;
import mx.edu.ulsaoaxaca.nomina.dominio.Empleado;
import mx.edu.ulsaoaxaca.nomina.dominio.Persona;

public class panelEditarEmpleado extends JPanel{

	private JLabel etiqueta1;
	private JLabel etiqueta2;
	private JLabel etiqueta3;
	private JLabel etiqueta4;
	private JLabel etiqueta5;
	private JLabel etiqueta6;
	private JLabel etiqueta7;
	private JLabel etiqueta8;
	private JLabel etiqueta9;
	private JLabel etiqueta10;
	private JLabel etiqueta11;
	private JLabel etiqueta12;
	private JLabel etiquetadatos;
	private JLabel etiquetadomicilio;
	private JTextField caja1,caja2,caja3,caja4,caja5,caja6,caja7,caja8,caja9,caja10,caja11,caja12;
	private JButton boton1;
	private JButton boton2;

	public panelEditarEmpleado(){

		this.setLayout(null);

		this.etiquetadatos=new JLabel ("Datos Personales");
		etiquetadatos.setBounds(100, 0, 250, 20);
		this.etiqueta1=new JLabel("Nombre");
		etiqueta1.setBounds(20,20,250,20);
		this.caja1=new JTextField();
		caja1.setBounds(20, 45, 250, 20);
		this.etiqueta2=new JLabel("Sexo");
		etiqueta2.setBounds(20,70,250,20);
		this.caja2=new JTextField();
		caja2.setBounds(20, 95, 250, 20);
		this.etiqueta3=new JLabel("fecha Nacimiento");
		etiqueta3.setBounds(20,120,250,20);
		this.caja3=new JTextField();
		caja3.setBounds(20, 145, 250, 20);
		this.etiqueta4=new JLabel("Numero de Seguridad Social (NSS)");
		etiqueta4.setBounds(20,170,250,20);
		this.caja4=new JTextField();
		caja4.setBounds(20, 195, 250, 20);
		this.etiqueta5=new JLabel("Sueldo");
		etiqueta5.setBounds(20,220,250,20);
		this.caja5=new JTextField();
		caja5.setBounds(20, 245, 250, 20);
		this.etiqueta11 = new JLabel("Bono");
		etiqueta11.setBounds(20, 270, 250, 20);
		this.caja11 = new JTextField();
		caja11.setBounds(20,295,250,20);
		this.etiqueta12 = new JLabel("Acciones");
		etiqueta12.setBounds(20, 320, 250, 20);
		this.caja12 = new JTextField();
		caja12.setBounds(20,345,250,20);


		this.etiquetadomicilio=new JLabel ("Domicilio Particular");
		etiquetadomicilio.setBounds(380, 0, 250, 20);
		this.etiqueta6=new JLabel("Calle");
		etiqueta6.setBounds(300,20,250,20);
		this.caja6=new JTextField();
		caja6.setBounds(300, 45, 250, 20);
		this.etiqueta7=new JLabel("Colonia");
		etiqueta7.setBounds(300,70,250,20);
		this.caja7=new JTextField();
		caja7.setBounds(300, 95, 250, 20);
		this.etiqueta8=new JLabel("Municipio");
		etiqueta8.setBounds(300,120,250,20);
		this.caja8=new JTextField();
		caja8.setBounds(300, 145, 250, 20);
		this.etiqueta9=new JLabel("Entidad Federativa");
		etiqueta9.setBounds(300,170,250,20);
		this.caja9=new JTextField();
		caja9.setBounds(300, 195, 250, 20);
		this.etiqueta10=new JLabel("Codigo Postal");
		etiqueta10.setBounds(300,220,250,20);
		this.caja10=new JTextField();
		caja10.setBounds(300, 245, 250, 20);













		this.boton1=new JButton("Actualizar Información");
		boton1.setBounds(300,390,250,20);

		this.boton2=new JButton("Cancelar");
		boton2.setBounds(50,390,100,20);
		boton2.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e) {
				Panel1 buscarEmpleado = new Panel1 ();

				buscarEmpleado.setSize(1024,768);
				buscarEmpleado.setLocation(30,0);
				removeAll();
				add(buscarEmpleado,BorderLayout.CENTER);
				revalidate();
				repaint();
				Panel1.id = "";
			}
		});




		boton1.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e) {



				if (Panel1.id != ""){
				
					NominaDAOImpl editar = new NominaDAOImpl();
					Persona obj = editar.editarEmpleado(Panel1.id);
					if(obj instanceof Empleado){

						Empleado empleado = new Empleado();
						empleado = (Empleado) obj;

						caja1.setText(empleado.getNombre()); 
						caja2.setText(empleado.getSexo());
						caja3.setText(empleado.getFechaNacimiento());
						caja4.setText(empleado.getNss());
						caja5.setText(empleado.getSueldo());
						caja11.setEditable(false);
						caja11.setEnabled(false);
						caja12.setEditable(false);
						caja12.setEnabled(false);

						//
						for (Domicilio k :empleado.getDomiciliosParticulares()){

							caja6.setText(k.getCalle());
							caja7.setText(k.getColonia());
							caja8.setText(k.getMunicipio());
							caja9.setText(k.getEntidadFederativa());
							caja10.setText(k.getCp());
						}


					}

					if(obj instanceof Ejecutivo){

						Ejecutivo ejecutivo = new Ejecutivo();
						ejecutivo = (Ejecutivo) obj;

						caja1.setText(ejecutivo.getNombre()); 
						caja2.setText(ejecutivo.getSexo());
						caja3.setText(ejecutivo.getFechaNacimiento());
						caja4.setText(ejecutivo.getNss());
						caja5.setText(ejecutivo.getSueldo());
						caja11.setText(ejecutivo.getBono());
						caja12.setEditable(false);
						caja12.setEnabled(false);

						for (Domicilio k :ejecutivo.getDomiciliosParticulares()){

							caja6.setText(k.getCalle());
							caja7.setText(k.getColonia());
							caja8.setText(k.getMunicipio());
							caja9.setText(k.getEntidadFederativa());
							caja10.setText(k.getCp());
						}

					}
					if(obj instanceof Directivo){

						Directivo directivo = new Directivo();
						directivo = (Directivo) obj;

						caja1.setText(directivo.getNombre()); 
						caja2.setText(directivo.getSexo());
						caja3.setText(directivo.getFechaNacimiento());
						caja4.setText(directivo.getNss());
						caja5.setText(directivo.getSueldo());
						caja12.setText(directivo.getAccion());
						caja11.setEditable(false);
						caja11.setEnabled(false);

						for (Domicilio k :directivo.getDomiciliosParticulares()){

							caja6.setText(k.getCalle());
							caja7.setText(k.getColonia());
							caja8.setText(k.getMunicipio());
							caja9.setText(k.getEntidadFederativa());
							caja10.setText(k.getCp());
						}	
					}




				}

			}
		});


		this.add(caja1);
		this.add(caja2);
		this.add(caja3);
		this.add(caja4);
		this.add(caja5);
		this.add(caja6);
		this.add(caja7);
		this.add(caja8);
		this.add(caja9);
		this.add(caja10);
		this.add(caja11);
		this.add(caja12);

		this.add(etiquetadatos);
		this.add(etiquetadomicilio);
		this.add(etiqueta1);
		this.add(etiqueta2);
		this.add(etiqueta3);
		this.add(etiqueta4);
		this.add(etiqueta5);
		this.add(etiqueta6);
		this.add(etiqueta7);
		this.add(etiqueta8);
		this.add(etiqueta9);
		this.add(etiqueta10);
		this.add(etiqueta11);
		this.add(etiqueta12);

		this.add(boton1);
		this.add(boton2);



	}


}
