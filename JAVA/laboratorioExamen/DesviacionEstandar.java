public class DesviacionEstandar{
	private Double desviacionEstandar;
	private Double promedio;
	private Double sumatoria;

	public DesviacionEstandar(){

	}
	public void getPromedio(Double cierre1,Double cierre2,Double cierre3,Double cierre4,Double cierre5){
	Promedio=cierre1+cierre2+cierre3+cierre4+cierre5;
	Promedio=promedio/5;
	this.promedio=Promedio;
	
	}

}
