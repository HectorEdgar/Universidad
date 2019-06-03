import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.Scanner;

public class Test3 {
	public static void main(String ... args){
		
		//File archivo = new File("archivo.txt");
		String sFichero = "archivo.txt";
		File fichero = new File(sFichero);
		 
		if (fichero.exists()) {
			System.out.printf("Dame 5 numeros");
			Double[] a =new Double[5];
			double contador=0.0;
			Scanner sc = new Scanner(System.in);
			
			for(int i=0;i<5;i++){
				a[i]=Double.parseDouble(sc.nextLine());
			}
			sc.close();
			
			
			
		
				try{
					BufferedWriter bw = new BufferedWriter(new FileWriter(sFichero));
					for(int i=0;i<5;i++){
						//FileWriter fw=new FileWriter("archivo.txt");
						bw.write(String.valueOf(a[i])+"\n");
						contador=contador+a[i];
					} 
					bw.write("La suma de los 5 numeros es: "+String.valueOf(contador));
					
					/*FileReader f = new FileReader(fichero);
					 
			        BufferedReader b = new BufferedReader(f);
			        String cadena;
			        while((cadena = b.readLine())!=null) {
			            System.out.println(cadena+"ll");
			        }
			        b.close();
					*/
					bw.close();
				}
				catch(Exception e){		
					e.printStackTrace();
				}
			
		}
	}		
}
	

