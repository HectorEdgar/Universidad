import java.util.Scanner;
import java.util.ArrayList;

public class EmpleadoTest2  {

	static ArrayList<Empleado> ListaEmpleados = new ArrayList<Empleado>();
	
	/*public ArrayList<Empleado> getListaEmpleados() {
		return this.ListaEmpleados;
	}
	public void setListaEmpleados(Empleado listaEmpleados) {
		this.ListaEmpleados.add(listaEmpleados);
	}
	*/

	public static void main(String ... args) {
		
		int seleccionMenu = 0;
		int contador=0;
		String Id=null;
	
		
		Scanner sc = new Scanner(System.in);
		
		do {
			System.out.printf("%n1.)Agregar Empleado%n2.)Desplegar informacion%n3.)Salir%n");
			seleccionMenu = sc.nextInt();
			sc.nextLine();
			
		
			switch(seleccionMenu) {
			
				case 1:{
					Empleado EmpleadoN = new Empleado();
					Domicilio DomicilioParticularN = new Domicilio();
					Domicilio DomicilioFiscalN = new Domicilio();
					//System.out.printf("Id: ");
					Id = java.util.UUID.randomUUID().toString();
					EmpleadoN.setId(Id);
					System.out.printf("Nombre: ");
					EmpleadoN.setNombre(sc.nextLine());
					
					System.out.printf("Fecha de Nacimiento: ");
					EmpleadoN.setFechaNacimiento(sc.nextLine());
					System.out.printf("Sexo: ");
					EmpleadoN.setSexo(sc.nextLine());
					System.out.printf("Nss: ");
					EmpleadoN.setNss(sc.nextLine());
					System.out.printf("Sueldo: ");
					EmpleadoN.setSueldo(sc.nextLine());
					
					//domicilio Particular
					System.out.printf("Domicilio Particular%n%nCalle : ");
					DomicilioParticularN.setCalle(sc.nextLine());
					System.out.printf("Colonia: ");
					DomicilioParticularN.setColonia(sc.nextLine());
					System.out.printf("Municipio: ");
					DomicilioParticularN.setMunicipio(sc.nextLine());
					System.out.printf("Entidad Federativa: ");
					DomicilioParticularN.setEntidadFederativa(sc.nextLine());
					System.out.printf("Codigo Postal: ");
					DomicilioParticularN.setCp(sc.nextLine());
					EmpleadoN.setDomiciliosParticular(DomicilioParticularN);
					
					//domicilio Fiscal
					System.out.printf("Domicilio Fiscal%n%nCalle: ");
					DomicilioFiscalN.setCalle(sc.nextLine());
					System.out.printf("Colonia: ");
					DomicilioFiscalN.setColonia(sc.nextLine());
					System.out.printf("Municipio: ");
					DomicilioFiscalN.setMunicipio(sc.nextLine());
					System.out.printf("Entidad Federativa: ");
					DomicilioFiscalN.setEntidadFederativa(sc.nextLine());
					System.out.printf("Codigo Postal: ");
					DomicilioFiscalN.setCp(sc.nextLine());
					EmpleadoN.setDomiciliosFiscales(DomicilioFiscalN);
				
					
					ListaEmpleados.add(EmpleadoN);
					
				//	System.out.printf("%s %n ",empleadoNum.getNombre());
				}break;
			
				case 2: {
					for(contador = 0;contador < ListaEmpleados.size();contador++){
						Empleado EmpleadoEnesimo = (Empleado)ListaEmpleados.get(contador);
				
						System.out.printf("%n%n%s",EmpleadoEnesimo.desplegarInformacion());
					}		
				}break;
			
			}
			} while(seleccionMenu!=3);
		
		
		
		
		sc.close();
		
		
	}
	
}
