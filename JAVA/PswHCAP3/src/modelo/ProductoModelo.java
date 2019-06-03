package modelo;

public class ProductoModelo implements Comparable<ProductoModelo> {

    //Las columnas que tiene la tabla Producto
    private int codigoProducto;
    private String nombre;
    private double precio;
    
    //Constructor de la clase sin parametros
    public ProductoModelo() {
    }
    
    //Constructor de la clase con parametros
    public ProductoModelo(int codigoProducto, String nombre, double precio) {
        this.codigoProducto = codigoProducto;
        this.nombre = nombre;
        this.precio = precio;
    }
    
    public int getCodigoProducto() {
        return codigoProducto;
    }

    public void setCodigoProducto(int codigoProducto) {
        this.codigoProducto = codigoProducto;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }
    
    //Metodo toString de la clase que nos retorna el nombre del producto
    @Override
    public String toString() {
        return codigoProducto + "";
    }

	@Override
	public int compareTo(ProductoModelo pm) {
		return (codigoProducto + "").compareTo(pm.codigoProducto + "");
	}
    
}
