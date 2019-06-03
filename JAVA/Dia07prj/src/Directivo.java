
public class Directivo extends Empleado {

    private String accion;

    public Directivo() {

    }

    public String getAccion() {
        return accion;
    }

    public void setAccion(String accion) {
        this.accion = accion;
    }

    @Override
    public String desplegarInformacion() {

        return super.desplegarInformacion() + "\nAccion: " + this.accion;

    }

}
