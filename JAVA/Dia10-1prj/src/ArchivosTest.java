import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import java.util.Scanner;

public class ArchivosTest {
	public static void main(String... args) {

		// Cargar empleados del archivo a memoria
		ArrayList<Persona> empleados = null;
		try {
			File archivo = new File("Empleados.obj");
			if (archivo.exists()) {
				FileInputStream fis = new FileInputStream("Empleados.obj");
				ObjectInputStream ois = new ObjectInputStream(fis);
				empleados = (ArrayList<Persona>) ois.readObject();
				//ois.close();
				
				//fis.close();
			} else {
				System.out.println("Archivo no encontrado");
			}

		} catch (Exception e) {

		}

		if (empleados == null) {
			empleados = new ArrayList<Persona>();

		}

		FileOutputStream fos = null;
		ObjectOutputStream oss = null;
		// FileInputStream fos1 = null;
		// ObjectInputStream oss1 = null;

		// Empleados es una lista polimorfica
		//ArrayList<Persona> empleados = new ArrayList<Persona>();

		/*
		 * empleados.add(new Empleado()); empleados.add(new Directivo());
		 * empleados.add(new Ejecutivo()); empleados.add(new Directivo());
		 * empleados.add(new Empleado());
		 * 
		 * Directivo d1 = new Directivo();//Polimorfismo
		 * d1.setNombre("Pepper Potts"); d1.setAccion("ssss");
		 * empleados.add(d1);
		 * 
		 * //p es una variable polimorfica for(Persona p: empleados){
		 * System.out.printf("%n%n[%s]%s",p.getClass(),p.desplegarInformacion())
		 * ; }
		 */
		int seleccionMenu = 0;
		String Id = null;
		Scanner sc = new Scanner(System.in);

		do {
			System.out.printf("%n1.)Agregar Empleado%n2.)Desplegar informacion%n3.)Calcular nomina%n4.)Salir%n%n");
			seleccionMenu = sc.nextInt();
			sc.nextLine();

			switch (seleccionMenu) {

			case 1: {
				int i = 0;
				do {
					System.out.printf("%n¿Que deseas agreagar?%n1.)Empleado%n2.)Ejecutivo%n3.)Directivo%n%n");
					seleccionMenu = sc.nextInt();
					sc.nextLine();

					switch (seleccionMenu) {

					case 1: {
						Empleado EmpleadoN = new Empleado();

						// System.out.printf("Id: ");
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

						do {
							Domicilio DomicilioParticularN = new Domicilio();
							Domicilio DomicilioFiscalN = new Domicilio();

							// domicilio Particular
							System.out.printf("%nDomicilio Particular%n%nCalle : ");
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

							System.out.printf("%nDeseas agregar un domicilio fiscal %n1.si%n2.no%n%n ");
							i = sc.nextInt();
							sc.nextLine();
							if (i == 1) {
								// domicilio Fiscal
								System.out.printf("%nDomicilio Fiscal%n%nCalle: ");
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
							}

							System.out.printf("%n¿Desea agregar mas direcciones?%n1.)Si%n2.)No%n%n");
							seleccionMenu = sc.nextInt();
							sc.nextLine();
						} while (seleccionMenu != 2);
						empleados.add(EmpleadoN);
						/*
						 * //Archivo de Empleados try { fos = new
						 * FileOutputStream ("Empleado.bin",true); oss = new
						 * ObjectOutputStream (fos);
						 * 
						 * oss.writeObject(EmpleadoN+"\n");
						 * 
						 * }catch (Exception e){
						 * 
						 * 
						 * }finally { try { if (oss != null) oss.close(); if(fos
						 * != null) fos.close(); } catch (IOException e) {
						 * 
						 * e.printStackTrace(); } }
						 */
					}
					break;

					case 2: {

						Ejecutivo EmpleadoN = new Ejecutivo();

						// System.out.printf("Id: ");
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
						System.out.printf("Sueldo: ");
						EmpleadoN.setBono(sc.nextLine());

						do {
							Domicilio DomicilioParticularN = new Domicilio();
							Domicilio DomicilioFiscalN = new Domicilio();
							// domicilio Particular
							System.out.printf("%nDomicilio Particular%n%nCalle : ");
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

							System.out.printf("%nDeseas agregar un domicilio fiscal %n1.si%n2.no%n%n ");
							i = sc.nextInt();
							sc.nextLine();
							if (i == 1) {
								// domicilio Fiscal
								System.out.printf("%nDomicilio Fiscal%n%nCalle: ");
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

							}
							/*
							 * //Archivo de Ejecutivos try { fos = new
							 * FileOutputStream ("Ejecutivos.bin",true); oss =
							 * new ObjectOutputStream (fos);
							 * 
							 * oss.writeObject(EmpleadoN+"\n");
							 * 
							 * }catch (Exception e){
							 * 
							 * 
							 * }finally { try { if (oss != null) oss.close();
							 * if(fos != null) fos.close(); } catch (IOException
							 * e) {
							 * 
							 * e.printStackTrace(); } }
							 * 
							 */
							System.out.printf("%n¿Que deseas agreagar?%n1.)Empleado%n2.)Ejecutivo%n3.)Directivo%n%n");
							seleccionMenu = sc.nextInt();
							sc.nextLine();
						} while (seleccionMenu != 2);
						empleados.add(EmpleadoN);
					}
					break;

					case 3: {

						Directivo EmpleadoN = new Directivo();

						// System.out.printf("Id: ");
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
						System.out.printf("Sueldo: ");
						EmpleadoN.setAccion(sc.nextLine());

						do {
							Domicilio DomicilioParticularN = new Domicilio();
							Domicilio DomicilioFiscalN = new Domicilio();

							// domicilio Particular
							System.out.printf("%nDomicilio Particular%n%nCalle : ");
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

							System.out.printf("%nDeseas agregar un domicilio fiscal %n1.si%n2.no%n%n ");
							i = sc.nextInt();
							sc.nextLine();
							if (i == 1) {
								// domicilio Fiscal
								System.out.printf("%nDomicilio Fiscal%n%nCalle: ");
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
							}

							/*
							 * //Archivo de Ejecutivos try { fos = new
							 * FileOutputStream ("Ejecutivos.bin",true); oss =
							 * new ObjectOutputStream (fos);
							 * 
							 * oss.writeObject(EmpleadoN+"\n");
							 * 
							 * }catch (Exception e){
							 * 
							 * 
							 * }finally { try { if (oss != null) oss.close();
							 * if(fos != null) fos.close(); } catch (IOException
							 * e) {
							 * 
							 * e.printStackTrace(); } }
							 * 
							 */
							System.out.printf("%n¿Que deseas agreagar?%n1.)Empleado%n2.)Ejecutivo%n3.)Directivo%n%n");
							seleccionMenu = sc.nextInt();
							sc.nextLine();

						} while (seleccionMenu != 2);
						empleados.add(EmpleadoN);
						// FileOutputStream fos = null;
						// ObjectOutputStream oss = null;

					}
					break;
					}
					System.out.printf("%n�Deseas agregar otro empleado?%n**1.Si%n**2.No%n%n ");
					i = sc.nextInt();
					sc.nextLine();
					try {
						fos = new FileOutputStream("Empleados.obj", true);
						oss = new ObjectOutputStream(fos);
System.out.println("Se guardo");
						//for (int i2 = 0; i2 < empleados.size(); i2++) {
							oss.writeObject(empleados);
						//}
						// oss.flush();
							oss.close();
							fos.close();
							
					} catch (Exception e) {
						e.printStackTrace();
					}
				} while (i != 2);

				// System.out.printf("%s %n ",empleadoNum.getNombre());
			}
			break;

			case 2: {

				/*
				 * FileInputStream fos1 = null; ObjectInputStream oss1 = null;
				 * 
				 * try{
				 * 
				 * fos1 = new FileInputStream ("Empleados.bin"); oss1 = new
				 * ObjectInputStream (fos1); empleados=(ArrayList<Persona>)
				 * oss1.readObject(); //System.out.println(((Alumno)
				 * oss1.readObject()).getMatricula()); //Persona EmpleadosN
				 * =(Persona) oss1.readObject();
				 * //System.out.printf("%s%s%s",ed.getCarrera(),ed.getNombre(),
				 * ed.getSemestre());
				 * 
				 * //Persona ed =(Persona) oss.readObject(); for(Persona p:
				 * empleados){ System.out.printf("%n%n[%s]%s",p.getClass(),p.
				 * desplegarInformacion()); } }catch(Exception e){
				 * e.printStackTrace(); }
				 */
				for (Persona p : empleados) {
					System.out.printf("%n%n[%s]%s", p.getClass(), p.desplegarInformacion());
				}
			}
			break;

			case 3: {
				Double contadorSueldo = 0.0;

				for (Persona p : empleados) {
					// System.out.printf("%n%n[%s]%s",p.getClass(),p.calcularSueldo());
					contadorSueldo = contadorSueldo + Double.parseDouble(p.calcularSueldo());
				}
				// Archivo de Empleados
				try {
					fos = new FileOutputStream("Empleados.obj");
					oss = new ObjectOutputStream(fos);

					oss.writeObject(contadorSueldo + "\n");

				} catch (Exception e) {

				} finally {
					try {
						if (oss != null)
							oss.close();
						if (fos != null)
							fos.close();
					} catch (IOException e) {

						e.printStackTrace();
					}
				}

				System.out.printf("La nomina es: %s%n", String.valueOf(contadorSueldo));

			}
			break;
			
			}
			
			
		} while (seleccionMenu != 4);

		
		sc.close();
	}
}

