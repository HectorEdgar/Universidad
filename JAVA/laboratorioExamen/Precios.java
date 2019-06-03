public class Precios {
	private String fecha;
	private Double precioApertura;
	private Double maxima;
	private Double baja;
	private Double cierre;
	private Double volumen;
	private Double cierreAjustado;

	public Precios() {
	
	}
	
	public void setFecha(String fecha) {
		this.fecha=fecha;
	}
	public String getFecha() {
		return this.fecha;
	}
	public void setPrecioApertura(Double precioApertura) {
                this.precioApertura=precioApertura;
        }
        public Double getPrecioApertura() {
                return this.precioApertura;
        }
	public void setMaxima(Double maxima) {
                this.maxima=maxima;
        }
        public Double getMaxima() {
                return this.maxima;
        }
	public void setBaja(Double baja) {
                this.baja=baja;
        }
        public Double getBaja(){
                return this.baja;
        }
	public void setCierre(Double cierre) {
                this.cierre=cierre;
        }
        public Double getCierre() {
                return this.cierre;
        }
	public void setVolumen(Double volumen) {
                this.volumen=volumen;
        }
        public Double getVolumen() {
                return this.volumen;
        }
	public void setCierreAjustado(Double cierreAjustado) {
                this.cierreAjustado=cierreAjustado;
        }
        public Double getCierreAjustado() {
                return this.cierreAjustado;
        }

}
