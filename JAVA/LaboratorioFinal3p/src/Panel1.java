

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class Panel1 extends JPanel{

	private JTextField caja1;
	private JTextField caja2;
	private JLabel etiqueta1;
	private JLabel etiqueta2;
	private JButton boton1;
	
	public Panel1(){
		this.setLayout(null);
		
		this.etiqueta1=new JLabel("Usuario");
		this.etiqueta1.setBounds(20, 20, 100, 10);
		this.caja1=new JTextField();
		this.caja1.setBounds(20, 35, 200, 20);
		
		this.etiqueta2=new JLabel("Contraseña");
		this.etiqueta2.setBounds(20, 65, 100, 20);
		this.caja2=new JTextField();
		this.caja2.setBounds(20, 85, 200, 20);
		
		
		this.boton1 = new JButton("ok");
		this.boton1.setBounds(80, 120, 60, 20);
		
		AccionBoton listener = new AccionBoton();
		this.boton1.addActionListener(listener);
		
		
		this.add(this.boton1);
		this.add(this.caja1);
		this.add(this.caja2);
		this.add(this.etiqueta1);
		this.add(this.etiqueta2);
		
	}
	
	private class AccionBoton implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent e) {
			if(caja1.getText().trim().length()==0){
				JOptionPane.showMessageDialog(null, "ha ocurrido un error");
			}else if(caja2.getText().compareTo("123456")==1){
				
				JOptionPane.showMessageDialog(null, "ha ocurrido un error");
			}
			else{
			Usuario usuarioN = new Usuario();
			usuarioN.setNombre(caja1.getText());
			usuarioN.setContrasena(caja2.getText());
			
			UsuarioDAO us = new UsuarioDAOImpl();
			
			if(us.ValidarUsuario(usuarioN)==true){
			JOptionPane.showMessageDialog(null, "se han agregado correctamente");
				
			}
			JOptionPane.showMessageDialog(null, "ha ocurrido un error");
				

		}}
	};
	
}
