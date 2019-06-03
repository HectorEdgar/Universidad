package Visual;


import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JPanel;


public class panelMenu extends JPanel{
	private JButton boton1;
	private JButton boton2;
	private JButton boton3;
	private JButton boton4;
	private JButton boton5;
	
	public panelMenu(){
		this.setLayout(null);
		this.boton1=new JButton("Dar de alta Empleados");
		boton1.setBounds(100, 100, 300, 30);
		this.boton2=new JButton("Editar informacion Empleados");
		boton2.setBounds(100,170 , 300, 30);
		this.boton3=new JButton("Salir");
		boton3.setBounds(100, 240, 300, 30);
		
		this.add(boton1);
		this.add(boton2);
		this.add(boton3);
		
		boton1.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent e) {
				PanelRegistro panelRegistro =new PanelRegistro();
				panelRegistro.setSize(1024, 768);
				panelRegistro.setLocation(-10,-10);

				removeAll();
				add(panelRegistro,BorderLayout.CENTER);
				revalidate();
				repaint();
			}
		});
	}
}
