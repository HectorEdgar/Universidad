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

	public static void main(String ... args){
		
		int seleccionMenu = 0;
		int contador=0,Id=0;
	
		
		Scanner sc = new Scanner(System.in);
		
		do {
			System.out.printf("%n1.)Agregar Empleado%n2.)Desplegar informacion%n3.)Salir%n");
			seleccionMenu = sc.nextInt();
			
		
			switch(seleccionMenu){
			
				case 1:{
					Empleado EmpleadoN = new Empleado();
					Domicilio DomicilioParticularN = new Domicilio();
					Domicilio DomicilioFiscalN = new Domicilio();
					System.out.printf("Id: ");
					EmpleadoN.setId(Id+1);
					System.out.printf("Nombre: ");
					EmpleadoN.setNombre(sc.next());
					System.out.printf("Fecha de Nacimiento: ");
					EmpleadoN.setFechaNacimiento(sc.next());
					System.out.printf("Sexo: ");
					EmpleadoN.setSexo(sc.next());
					System.out.printf("Nss: ");
					EmpleadoN.setNss(sc.next());
					System.out.printf("Sueldo: ");
					EmpleadoN.setSueldo(sc.next());
					
					//domicilio Particular
					System.out.printf("Calle : ");
					DomicilioParticularN.setCalle(sc.next());
					System.out.printf("Colonia: ");
					DomicilioParticularN.setColonia(sc.next());
					System.out.printf("Municipio: ");
					DomicilioParticularN.setMunicipio(sc.next());
					System.out.printf("Entidad Federativa: ");
					DomicilioParticularN.setEntidadFederativa(sc.next());
					System.out.printf("Codigo Postal: ");
					DomicilioParticularN.setCp(sc.next());
					EmpleadoN.setDomiciliosParticular(DomicilioParticularN);
					
					//domicilio Fiscal
					System.out.printf("Calle: ");
					DomicilioFiscalN.setCalle(sc.next());
					System.out.printf("Colonia: ");
					DomicilioFiscalN.setColonia(sc.next());
					System.out.printf("Municipio: ");
					DomicilioFiscalN.setMunicipio(sc.next());
					System.out.printf("Entidad Federativa: ");
					DomicilioFiscalN.setEntidadFederativa(sc.next());
					System.out.printf("Codigo Postal: ");
					DomicilioFiscalN.setCp(sc.next());
					EmpleadoN.setDomiciliosFiscales(DomicilioFiscalN);
				
					
					ListaEmpleados.add(EmpleadoN);
					
				//	System.out.printf("%s %n ",empleadoNum.getNombre());
				}break;
			
				case 2: {
					for(contador = 0;contador < ListaEmpleados.size();contador++){
						Empleado EmpleadoEnesimo = (Empleado)ListaEmpleados.get(contador);
				
						System.out.printf("%n%s",EmpleadoEnesimo.desplegarInformacion());
					}		
				}break;
			
			}
			} while(seleccionMenu!=3);
		
		
		
		
		
		
		
	}
	
}
