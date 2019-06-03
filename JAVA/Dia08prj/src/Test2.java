import java.io.File;
import java.util.Scanner;

public class Test2 {
	public static void main(String ... args){
		File archivo = new File("archivo.txt");
		
		try{
			Scanner sc = new Scanner(archivo);
			sc.useDelimiter(" ");
			while(sc.hasNext()){
				System.out.printf("%s ", sc.next());
				sc.close();
			}
		} catch(Exception e){
			e.printStackTrace();
		}
	}
	

}
