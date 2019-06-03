public class EstudianteTest {
	public static void main(String ... args) { 
		Estudiante arrayEstudiante[] = new Estudiante[3]; 
		
		Estudiante estudiante1 = new Estudiante();
		estudiante1.setNombre("Luis");
		estudiante1.setFechaNacimiento("10-mar-93");
		estudiante1.setSexo("Masculino");
		estudiante1.setId("01");
		estudiante1.setEscuela("La salle");
		estudiante1.setGrado("Segundo grado");
		estudiante1.setGrupo("IS3A");
		
		arrayEstudiante[0] = estudiante1;	
		
		Estudiante estudiante2 = new Estudiante();
		estudiante2.setNombre("Edgar");
		estudiante2.setFechaNacimiento("11-sep-96");
		estudiante2.setSexo("Masculino");
		estudiante2.setId("02");
		estudiante2.setEscuela("La salle");
		estudiante2.setGrado("Segundo grado");
		estudiante2.setGrupo("IS3A");
		
		arrayEstudiante[1] = estudiante2;	
		
		Estudiante estudiante3 = new Estudiante();
		estudiante3.setNombre("Jair");
		estudiante3.setFechaNacimiento("13-ene-96");
		estudiante3.setSexo("Masculino");
		estudiante3.setId("03");
		estudiante3.setEscuela("La salle");
		estudiante3.setGrado("Segundo grado");
		estudiante3.setGrupo("IS3A");
		
		arrayEstudiante[2] = estudiante3;	
	
		for(int i=0;i<=2;i++) {
			System.out.printf("%d %n Los datos de los estudiantes es:%n %s %n %s %n %s %n %s %n %s %n %s %n"+
			"%s %n", i+1, arrayEstudiante[i].getNombre(), arrayEstudiante[i].getFechaNacimiento(),
			arrayEstudiante[i].getSexo(), arrayEstudiante[i].getId(), arrayEstudiante[i].getEscuela(),
			arrayEstudiante[i].getGrado(), arrayEstudiante[i].getGrupo());
		}
	}	
}