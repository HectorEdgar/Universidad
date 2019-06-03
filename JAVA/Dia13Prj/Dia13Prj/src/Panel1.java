import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Date;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;

public class Panel1 extends JPanel{
	private JButton boton1;
	private JLabel etiqueta1;
	public Panel1 (){
		
		// Control 
		 boton1 = new JButton("Boton 1");
		 AccionBoton listener  =  new AccionBoton();
		 this.boton1.addActionListener(listener);
		 this.etiqueta1 =  new JLabel ("");
		
		this.add(boton1);
		this.add(this.etiqueta1);
	}

	//Clase interna que implementa una interface
	private class AccionBoton implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
			etiqueta1.setText(new Date().toString());
			
		}
		
		
	}
}
