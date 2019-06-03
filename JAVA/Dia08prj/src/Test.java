
public class Test {
	public static void main(String ... args) {
		String[] arreglo = new String[3];
		arreglo[0]="Cadena 0";
		
		
		
		for(int i = 0; i<3; i++){
		System.out.printf("%s %n",arreglo[i]);
		}
		try{
		double a= 1/0;
		}catch(Exception e){
			e.printStackTrace();
			
		}
		try{
			double a= 1/0;
			arreglo[3]="Cadena 0";//excepcion no marcada
			} catch(ArithmeticException e) {
				System.out.printf("%nNo es posible dividir entre cero%n");
				//e.printStackTrace();
				try{
					double b=1/0;
				} 
					catch(Exception j) {
						System.out.printf("%n¡No es posible dividir entre cero!%n");
					}
			} finally{//finally es opcional
				System.out.printf("Clausula FINALLY %n");
			}
		
	}
}
