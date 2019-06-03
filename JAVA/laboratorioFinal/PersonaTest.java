import java.util.Scanner;
public class PersonaTest{
	public static void main(String ... args){
		String nombre,fechaNacimiento,sexo,id;	
		Persona persona1 = new Persona();
		Scanner scan= new Scanner(System.in);
		System.out.printf("dame tu nombre");
		nombre  = scan.nextLine();			
		System.out.printf("dame tu fecha de nacimiento");
		fechaNacimiento  = scan.nextLine();
                System.out.printf("dame tu sexo");
		sexo  = scan.nextLine();
               
		id  = scan.nextLine();
               

	}

}
