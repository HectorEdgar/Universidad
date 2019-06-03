public class PreciosTest{
	public static void main(String ... args) {
		Precios arrayPrecio[] = new Precios[5];
		
		Precios precio1 = new Precios();
		Precios precio2 = new Precios();
		Precios precio3 = new Precios();
		Precios precio4 = new Precios();
		Precios precio5 = new Precios();
		
		precio1.setFecha("31/08/2015");
		precio1.setPrecioApertura(549.50);
		precio1.setMaxima(549.50);
		precio1.setBaja(549.50);
		precio1.setCierre(549.50);
		precio1.setVolumen(0.00);
		precio1.setCierreAjustado(549.50);

		precio2.setFecha("28/08/2015");
                precio2.setPrecioApertura(557.42);
                precio2.setMaxima(557.42);
                precio2.setBaja(556.59);
                precio2.setCierre(556.79);
                precio2.setVolumen(3300.00);
                precio2.setCierreAjustado(556.79);
		
		precio3.setFecha("27/08/2015");
                precio3.setPrecioApertura(564.51);
                precio3.setMaxima(564.51);
                precio3.setBaja(564.51);
                precio3.setCierre(564.51);
                precio3.setVolumen(0.00);
                precio3.setCierreAjustado(564.51);
		
		precio4.setFecha("26/08/2015");
                precio4.setPrecioApertura(559.53);
                precio4.setMaxima(559.53);
                precio4.setBaja(537.00);
                precio4.setCierre(546.60);
                precio4.setVolumen(900.00);
                precio4.setCierreAjustado(546.60);
	
		precio5.setFecha("25/08/2015");
                precio5.setPrecioApertura(558.00);
                precio5.setMaxima(559.53);
                precio5.setBaja(550.00);
                precio5.setCierre(559.53);
                precio5.setVolumen(2000.00);
                precio5.setCierreAjustado(559.53);
	
		arrayPrecio[0] = precio1;
		arrayPrecio[1] = precio2;
		arrayPrecio[2] = precio3;
		arrayPrecio[3] = precio4;
		arrayPrecio[4] = precio5;
		
		double Promedio=arrayPrecio[0].getCierre()+arrayPrecio[1].getCierre()+arrayPrecio[2].getCierre()+arrayPrecio[3].getCierre()+arrayPrecio[4].getCierre();
		Promedio=Promedio/5;
		Double Sumatoria=Math.pow(arrayPrecio[0].getCierre()-Promedio,2) + Math.pow(arrayPrecio[1].getCierre()-Promedio,2) + Math.pow(arrayPrecio[2].getCierre()-Promedio,2) +
		Math.pow(arrayPrecio[3].getCierre()-Promedio,2) + Math.pow(arrayPrecio[4].getCierre()-Promedio,2);
		Double DesviacionEstandar=Math.pow(Sumatoria*.25,0.5);
		System.out.printf("El resultado de la Desviacion estandar es: %.3f  %n ", DesviacionEstandar);				
	}
		
}
