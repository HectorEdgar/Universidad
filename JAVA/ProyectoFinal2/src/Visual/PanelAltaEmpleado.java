package Visual;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class PanelAltaEmpleado extends JPanel{
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
	private JLabel etiqueta13;
	private JLabel etiqueta14;
	private JLabel etiqueta15;
	private JLabel etiquetadatos;
	private JLabel etiquetadomicilio;
	private JLabel etiquetadomiciliof;
	private JTextField caja1,caja2,caja3,caja4,caja5,caja6,caja7,caja8,caja9,caja10,caja11,caja12
						,caja13,caja14,caja15;
	private JButton boton1;
	private JButton boton2;
	public PanelAltaEmpleado(){
		this.setLayout(null);
	
		this.etiquetadatos=new JLabel ("Datos Personales");
		etiquetadatos.setBounds(100, 0, 250, 20);
		this.etiqueta1=new JLabel("Nombre");
		etiqueta1.setBounds(20,20,250,20);
		this.caja1=new JTextField();
		caja1.setBounds(20, 45, 250, 20);
		this.etiqueta2=new JLabel("sexo");
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
		
		this.boton1=new JButton("Registrar Empleado");
		boton1.setBounds(20,280,250,20);
		this.boton2=new JButton("Registrar Domicilio Fiscal");
		boton2.setBounds(300,280,250,20);

		etiquetadomiciliof=new JLabel ("Domicilio Fiscal");
		etiquetadomiciliof.setBounds(10, 280, 250, 20);
		etiqueta11=new JLabel("Calle");
		etiqueta11.setBounds(100,300,250,20);
		caja11=new JTextField();
		caja11.setBounds(100, 325, 250, 20);
		etiqueta12=new JLabel("Colonia");
		etiqueta12.setBounds(100,350,250,20);
		caja12=new JTextField();
		caja12.setBounds(100, 375, 250, 20);
		etiqueta13=new JLabel("Municipio");
		etiqueta13.setBounds(100,400,250,20);
		caja13=new JTextField();
		caja13.setBounds(100, 425, 250, 20);
		etiqueta14=new JLabel("Entidad Federativa");
		etiqueta14.setBounds(100,450,250,20);
		caja14=new JTextField();
		caja14.setBounds(100, 475, 250, 20);
		etiqueta15=new JLabel("Codigo Postal");
		etiqueta15.setBounds(100,500,250,20);
		caja15=new JTextField();
		caja15.setBounds(100, 525, 250, 20);
		
		add(caja11);
		add(caja12);
		add(caja13);
		add(caja14);
		add(caja15);
		add(etiqueta11);
		add(etiqueta12);
		add(etiqueta13);
		add(etiqueta14);
		add(etiqueta15);
		add(etiquetadomiciliof);
		
		
		
		
		
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
		
		this.add(boton1);
		this.add(boton2);
		
		boton2.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent e) {
				
				etiquetadomiciliof=new JLabel ("Domicilio Fiscal");
				etiquetadomiciliof.setBounds(620, 0, 250, 20);
				etiqueta11=new JLabel("Calle");
				etiqueta11.setBounds(580,20,250,20);
				caja11=new JTextField();
				caja11.setBounds(580, 45, 250, 20);
				etiqueta12=new JLabel("Colonia");
				etiqueta12.setBounds(580,70,250,20);
				caja12=new JTextField();
				caja12.setBounds(580, 95, 250, 20);
				etiqueta13=new JLabel("Municipio");
				etiqueta13.setBounds(580,120,250,20);
				caja13=new JTextField();
				caja13.setBounds(580, 145, 250, 20);
				etiqueta14=new JLabel("Entidad Federativa");
				etiqueta14.setBounds(580,170,250,20);
				caja14=new JTextField();
				caja14.setBounds(580, 195, 250, 20);
				etiqueta15=new JLabel("Codigo Postal");
				etiqueta15.setBounds(580,220,250,20);
				caja15=new JTextField();
				caja15.setBounds(580, 245, 250, 20);
				
				add(caja11);
				add(caja12);
				add(caja13);
				add(caja14);
				add(caja15);
				add(etiqueta11);
				add(etiqueta12);
				add(etiqueta13);
				add(etiqueta14);
				add(etiqueta15);
				add(etiquetadomiciliof);
				
			}
		});
	}
	
	
}
