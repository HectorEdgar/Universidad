public class EmpleadoTest2 {
	public static void main(String ... args){
		Empleado empleado1 = new Empleado();
		empleado1.setId("1");
		empleado1.setNombre("clark kent");
		empleado1.setFechaNacimiento("01-01-1997");
		empleado1.setSexo("Hombre");
		empleado1.setNss("121");
		empleado1.setSueldo("1000");

		
		System.out.printf("%s ",empleado1.desplegarInformacion());
		
		//Domicilio Particular 1
		Domicilio domicilioParticular1= new Domicilio();
		domicilioParticular1.setCalle("calle1");
		domicilioParticular1.setColonia("colonia1");
		domicilioParticular1.setMunicipio("Municipio1");
		domicilioParticular1.setEntidadFederativa("entidad1");
		domicilioParticular1.setCp("cp1");
		
		Empleado empleado2 = new Empleado();
		empleado2.setId("Id2");
		empleado2.setNombre("zorra");
		empleado2.setFechaNacimiento("2045");
		empleado2.setSexo("homosexual y zorrra a la ves");
		empleado2.setNss("Nss2");
		empleado2.setSueldo("en la esquina gana 1000 por sexo");
		
		//Domicilio Particular2 
		Domicilio domicilioParticular2= new Domicilio();
		domicilioParticular2.setCalle("calle2");
		domicilioParticular2.setColonia("colonia2");
		domicilioParticular2.setMunicipio("Municipio2");
		domicilioParticular2.setEntidadFederativa("entidad2");
		domicilioParticular2.setCp("cp2");

		Empleado empleado3 = new Empleado();
		empleado3.setId("Id3");
		empleado3.setNombre("El gran ed");
		empleado3.setFechaNacimiento("666");
		empleado3.setSexo("homosexual");
		empleado3.setNss("Nss3");
		empleado3.setSueldo("no trabaja");
		
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
	}
}
