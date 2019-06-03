package Visual;

import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.List;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;
import DAO.LoginDao;
import DAO.LoginDaoImpl;
import Dominio.Administrador;




public class PanelLogin extends JPanel{
	private JTextField caja1;
	private JPasswordField caja2;
	private JLabel etiqueta1;
	private JLabel etiqueta2;
	private JButton boton1;

	public PanelLogin(){
		this.setLayout(null);

		this.etiqueta1 = new JLabel("Usuario:");
		etiqueta1.setBounds(20, 50 , 60, 20);
		this.caja1 = new JTextField();
		this.caja1.setBounds(20, 90, 300, 20);
		this.etiqueta2 = new JLabel("Contrasena:");
		etiqueta2.setBounds(20, 120, 150, 20);
		this.caja2 = new JPasswordField();
		this.caja2.setBounds(20, 160, 300, 20);
		this.boton1=new JButton("Iniciar Sesion");
		this.boton1.setBounds(50, 200, 200, 20);

		this.add(boton1);
		this.add(caja1);
		this.add(caja2);
		this.add(etiqueta2);
		this.add(etiqueta1);

		boton1.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent e) {
				try{
					if(caja1.getText().trim().length() == 0 || String.valueOf(caja2.getPassword()).trim().length()==0){
						JOptionPane.showMessageDialog(null, "Dejo un campo Vacio");
					}
					else{
						int retorno=0;						
						LoginDao dao=new LoginDaoImpl();
						Administrador admin=new Administrador();
						admin.setContrasena(String.valueOf(caja2.getPassword()));
						admin.setUsuario(caja1.getText());
						List<Administrador> administradores=new ArrayList();
						administradores=dao.validarUsarioF();
						for(Administrador a : administradores){
							if(admin.getContrasena().equals(a.getContrasena())&&admin.getUsuario().equals(a.getUsuario())){
								retorno+=1;
							}
						}


						if(retorno!=0){
							
							panelMenu panelMenu=new panelMenu();
							panelMenu.setSize(1024,768);
							panelMenu.setLocation(100, 100);
						
							removeAll();
							add(panelMenu,BorderLayout.CENTER);
							revalidate();
							repaint();
						
						}else if(retorno==0){
							JOptionPane.showMessageDialog(null, "Credenciales incorrectas");
						}

					}
					//opcion para parsear a string passwords String password = String.valueOf(caja2.getPassword());

				}catch(Exception ex){
					ex.printStackTrace();
				}




			}
		});

	}
}
