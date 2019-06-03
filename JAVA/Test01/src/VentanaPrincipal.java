import java.awt.BorderLayout;

import javax.swing.Box;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class VentanaPrincipal extends JFrame
{
    VentanaPrincipal()
    {   
        setSize(400,400);
        setTitle("ventana principal");        
              
         
        setLocationRelativeTo(null);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
 
    public void mostrar()
    {
        setVisible(true);
    }
 
}