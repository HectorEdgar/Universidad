package dao;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

import modelo.ProductoModelo;

public class ProductoJdbc {

    public static synchronized boolean insertarProducto(ProductoModelo paramProducto) {
        Connection cn = null;
        CallableStatement callStm = null;
        boolean respuesta = false;
        try {
            String call = "{CALL spI_producto(?,?,?)}"; //Nombre del procedimiento almacenado, espera tres parametros
            cn = Conexion.getConexion(); 
            cn.setAutoCommit(false); //crear una transaccion
            callStm = cn.prepareCall(call); //Preparamos la sentecia
            callStm.setInt(1, paramProducto.getCodigoProducto()); //Como el codigo se autogenera y es del tipo OUT en el procedimiento almacenado le decimos que es OUT y el del tipo Integer en Java cl.registerOutParameter(1, Types.INTEGER);
            callStm.setString(2, paramProducto.getNombre()); //El siguiente parametro del procedimiento almacenado es el nombre
            callStm.setDouble(3, paramProducto.getPrecio()); //ultimo el precio 
            respuesta = callStm.executeUpdate() == 1 ? true : false; //ejecutar, si regresa 1 es correcta la ejecucion
            if (respuesta) {
                cn.commit(); //Confirmamos la transaccion
            } else {
                Conexion.deshacerCambios(cn); //Negamos la transaccion
            }
            Conexion.cerrarCall(callStm);
            Conexion.cerrarConexion(cn);
        } catch (SQLException e) {
            e.printStackTrace();
            Conexion.deshacerCambios(cn);
            Conexion.cerrarCall(callStm);
            Conexion.cerrarConexion(cn);
        } catch (Exception e) {
            e.printStackTrace();
            Conexion.deshacerCambios(cn);
            Conexion.cerrarCall(callStm);
            Conexion.cerrarConexion(cn);
        }
        return respuesta;
    }
    
    public static synchronized List<ProductoModelo> obtenerListaProductos() {
        List<ProductoModelo> lista = new ArrayList<ProductoModelo>();
        Connection cn = null;
        CallableStatement cl = null;
        ResultSet rs = null;
        try {
            //Nombre del procedimiento almacenado
            String call = "{CALL spF_producto_all()}";
            cn = Conexion.getConexion();
            cl = cn.prepareCall(call);
            //La sentencia lo almacenamos en un resulset
            rs = cl.executeQuery();
            //Consultamos si hay datos para recorrerlo
            //e insertarlo en nuestro array
            while (rs.next()) {
                ProductoModelo p = new ProductoModelo();
                //Obtenemos los valores de la consulta y creamos
                //nuestro objeto producto
                p.setCodigoProducto(rs.getInt("codigoProducto"));
                p.setNombre(rs.getString("nombre"));
                p.setPrecio(rs.getDouble("precio"));
                //Lo adicionamos a nuestra lista
                lista.add(p);
            }
            Collections.sort(lista);
            Conexion.cerrarCall(cl);
            Conexion.cerrarConexion(cn);
        } catch (SQLException e) {
            e.printStackTrace();
            Conexion.cerrarCall(cl);
            Conexion.cerrarConexion(cn);
        } catch (Exception e) {
            e.printStackTrace();
            Conexion.cerrarCall(cl);
            Conexion.cerrarConexion(cn);
        }
        return lista;
    }
}
