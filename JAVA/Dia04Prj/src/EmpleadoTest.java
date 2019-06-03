
public class EmpleadoTest {
	public static void main(String ... args){
		Empleado empleado1 = new Empleado();
		empleado1.setId("1");
		empleado1.setNombre("clark kent");
		empleado1.setFechaNacimiento("01-01-1997");
		empleado1.setSexo("Hombre");
		empleado1.setNss("121");
		empleado1.setSueldo("1000");
		
		//Domicilio Particular 1
		Domicilio domicilioParticular1= new Domicilio();
		domicilioParticular1.setCalle("calle1");
		domicilioParticular1.setColonia("colonia1");
		domicilioParticular1.setMunicipio("Municipio1");
		domicilioParticular1.setEntidadFederativa("entidad1");
		domicilioParticular1.setCp("cp1");
		
		Empleado empleado2 = new Empleado();
		empleado2.setId("Id2");
		empleado2.setNombre("Nombre2");
		empleado2.setFechaNacimiento("FechaNacimiento2");
		empleado2.setSexo("Sexo2");
		empleado2.setNss("Nss2");
		empleado2.setSueldo("Sueldo2");
		
		//Domicilio Particular2 
		Domicilio domicilioParticular2= new Domicilio();
		domicilioParticular2.setCalle("calle2");
		domicilioParticular2.setColonia("colonia2");
		domicilioParticular2.setMunicipio("Municipio2");
		domicilioParticular2.setEntidadFederativa("entidad2");
		domicilioParticular2.setCp("cp2");

		Empleado empleado3 = new Empleado();
		empleado3.setId("Id3");
		empleado3.setNombre("Nombre3");
		empleado3.setFechaNacimiento("FechaNacimiento3");
		empleado3.setSexo("Sexo3");
		empleado3.setNss("Nss3");
		empleado3.setSueldo("Sueldo3");
		
		//Domicilio Particular3 
		Domicilio domicilioParticular3= new Domicilio();
		domicilioParticular3.setCalle("calle3");
		domicilioParticular3.setColonia("colonia3");
		domicilioParticular3.setMunicipio("Municipio3");
		domicilioParticular3.setEntidadFederativa("entidad3");
		domicilioParticular3.setCp("cp3");

		
		//Domicilio Fiscal 1
		Domicilio domicilioFiscal1= new Domicilio();
		domicilioFiscal1.setCalle("calle1");
		domicilioFiscal1.setColonia("colonia1");
		domicilioFiscal1.setMunicipio("Municipio1");
		domicilioFiscal1.setEntidadFederativa("entidad1");
		domicilioFiscal1.setCp("cp1");
		
		//Domicilio Fiscal 2
		Domicilio domicilioFiscal2= new Domicilio();
		domicilioFiscal2.setCalle("calle2");
		domicilioFiscal2.setColonia("colonia2");
		domicilioFiscal2.setMunicipio("Municipio2");
		domicilioFiscal2.setEntidadFederativa("entidad2");
		domicilioFiscal2.setCp("cp2");
		
		//Domicilio Fiscal 2
		Domicilio domicilioFiscal3= new Domicilio();
		domicilioFiscal3.setCalle("calle3");
		domicilioFiscal3.setColonia("colonia3");
		domicilioFiscal3.setMunicipio("Municipio3");
		domicilioFiscal3.setEntidadFederativa("entidad3");
		domicilioFiscal3.setCp("cp3");
		
		empleado1.setDomiciliosParticular(domicilioParticular1);
		empleado2.setDomiciliosParticular(domicilioParticular2);
		empleado3.setDomiciliosParticular(domicilioParticular3);
		empleado1.setDomiciliosFiscales(domicilioFiscal1);
		empleado2.setDomiciliosFiscales(domicilioFiscal2);
		empleado3.setDomiciliosFiscales(domicilioFiscal3);
		
		//Staff
		Empleado[] empleados = new Empleado[3];
		empleados[0]=empleado1;
		empleados[1]=empleado2;
		empleados[2]=empleado3;
		 
		//Alternativa
		//Empleado[] empleados2= {empleado1};
		
		for(Empleado e:empleados){
			System.out.printf("Nombre: %s %s %s %s %s %s  %n",
					e.getNombre(),
					e.getFechaNacimiento(),
					e.getId(),
					e.getNss(),
					e.getSexo(),
					e.getSueldo());
			for(Domicilio d:e.getDomiciliosParticular()){
			System.out.printf("DomicilioParticular: %s %s %s %s %s%n ",
					d.getCalle(),
					d.getColonia(),
					d.getEntidadFederativa(),
					d.getCp(),
					d.getMunicipio());}
		}
	}

}