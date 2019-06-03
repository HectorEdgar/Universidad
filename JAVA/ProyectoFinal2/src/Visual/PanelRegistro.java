package Visual;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.List;

import javax.swing.JButton;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

import DAO.LoginDao;
import DAO.LoginDaoImpl;
import Dominio.Administrador;

public class PanelRegistro extends JPanel{
	private JButton boton1;
	private JButton boton2;
	private JButton boton3;
	private JButton boton4;
	
	public PanelRegistro(){
		this.setLocation(0,0);
		
		this.setLayout(null);
		
		this.boton1=new JButton("Dar de Alta Empleado");
		this.boton1.setBounds(50, 20, 200, 20);
		this.boton2=new JButton("Dar de Alta Ejecutivo");
		this.boton2.setBounds(50, 60, 200, 20);
		this.boton3=new JButton("Dar de Alta Directivo");
		this.boton3.setBounds(50, 100, 200, 20);
		this.boton4=new JButton("Regresar Al menu anterior");
		this.boton4.setBounds(50, 140, 200, 20);
		
		this.add(boton1);
		this.add(boton2);
		this.add(boton3);
		this.add(boton4);

		boton1.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent e) {
				PanelAltaEmpleado panelempleado=new PanelAltaEmpleado();
				panelempleado.setSize(new Dimension(1024,768));
				panelempleado.setLocation(0,0);
				
				removeAll();
				add(panelempleado,BorderLayout.CENTER);
				revalidate();
				repaint();
				
			}
		});

	}
}
