using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase2
{
    class CuentaDaoImpl : CuentaDAO
    {
        private MySqlDataReader reader;

        public Cuenta obtenerCuenta(string usuario, string contrasena)
        {
            DataSource ds = new DataSourceImpl();
            String consulta = "SELECT * FROM CUENTA as c, persona AS pers, perfil as perf WHERE c.USUARIO='" +
                usuario + "' AND c.CONTRASENA='" +
                contrasena + "' AND pers.persona_id=c.persona_id AND perf.perfil_id = c.perfil_id;";

            reader = (MySqlDataReader)ds.EjecutarConsulta(consulta);

            while (reader.Read())
            {


                Cuenta cuenta = new Cuenta();
                Perfil perfil = new Perfil();
                Persona persona = new Persona();

                cuenta.cuenta_id = Convert.ToInt32(reader["cuenta_id"]);
                cuenta.usuario = Convert.ToString(reader["usuario"]);
                cuenta.contrasena = Convert.ToString(reader["contrasena"]);
                cuenta.correoelectronico = Convert.ToString(reader["correoelectronico"]);
                cuenta.estado = Convert.ToString(reader["estado"]);
                persona.persona_id = Convert.ToInt32(reader["persona_id"]);
                persona.nombre = Convert.ToString(reader["nombre"]);
                persona.estado = Convert.ToString(reader["estado"]);
                perfil.perfil_id = Convert.ToInt32(reader["perfil_id"]);
                perfil.nombre = Convert.ToString(reader["nombre"]);
                perfil.descripcion = Convert.ToString(reader["descripcion"]);
                perfil.estado = Convert.ToString(reader["estado"]);

                cuenta.persona = persona;
                cuenta.perfil = perfil;

                return cuenta;
            }
            return null;
        }

        public List<Cuenta> obtenerCuentas()
        {
            DataSource ds = new DataSourceImpl();
            String consulta = "SELECT * FROM CUENTA INNER JOIN PERSONA on " +
                "PERSONA.persona_id = CUENTA.persona_id INNER JOIN PERFIL ON PERFIL.perfil_id = CUENTA.perfil_id;";

            reader = (MySqlDataReader)ds.EjecutarConsulta(consulta);

            List<Cuenta> cuentas = new List<Cuenta>();
            while (reader.Read())
            {


                Cuenta cuenta = new Cuenta();
                Perfil perfil = new Perfil();
                Persona persona = new Persona();

                cuenta.cuenta_id = Convert.ToInt32(reader["cuenta_id"]);
                cuenta.usuario = Convert.ToString(reader["usuario"]);
                cuenta.contrasena = Convert.ToString(reader["contrasena"]);
                cuenta.correoelectronico = Convert.ToString(reader["correoelectronico"]);
                cuenta.estado = Convert.ToString(reader["estado"]);
                persona.persona_id = Convert.ToInt32(reader["persona_id"]);
                persona.nombre = Convert.ToString(reader["nombre"]);
                persona.estado = Convert.ToString(reader["estado"]);
                perfil.perfil_id = Convert.ToInt32(reader["perfil_id"]);
                perfil.nombre = Convert.ToString(reader[12]);
                perfil.descripcion = Convert.ToString(reader["descripcion"]);
                perfil.estado = Convert.ToString(reader["estado"]);

                cuenta.persona = persona;
                cuenta.perfil = perfil;

                cuentas.Add(cuenta);

            }
            return cuentas;
        }

        public List<Cuenta> obtenerCuentas(string filtro)
        {

            DataSource ds = new DataSourceImpl();

            String consulta = ("SELECT cuenta.cuenta_id as CuentaCuenta_id,"+
                "cuenta.usuario as CuentaUsuario,"+
                "cuenta.contrasena as CuentaContrasena,"+
                "cuenta.correoelectronico as CuentaCorreoElectronico,"+
                "cuenta.estado as CuentaEstado,"+
                "persona.persona_id as PersonaPersona_id,"+
                "persona.nombre as PersonaNombre,"+
                "persona.estado as PersonaEstado,"+
                "perfil.perfil_id as PerfilPerfil_id,"+
                "perfil.nombre as PerfilNombre,"+
                "perfil.descripcion as PerfilDescripcion,"+
                "perfil.estado as PerfilEstado"+
                " FROM CUENTA INNER JOIN PERSONA on  PERSONA.persona_id = "+
                "CUENTA.persona_id INNER JOIN PERFIL ON PERFIL.perfil_id = CUENTA.perfil_id where cuenta.usuario LIKE '%"+filtro+"%'; ");

            //Console.WriteLine(consulta);
            reader = (MySqlDataReader)ds.EjecutarConsulta(consulta);

            List<Cuenta> cuentas = new List<Cuenta>();
            while (reader.Read())
            {


                Cuenta cuenta = new Cuenta();
                Perfil perfil = new Perfil();
                Persona persona = new Persona();

                cuenta.cuenta_id = Convert.ToInt32(reader["CuentaCuenta_id"]);
                cuenta.usuario = Convert.ToString(reader["CuentaUsuario"]);
                cuenta.contrasena = Convert.ToString(reader["CuentaContrasena"]);
                cuenta.correoelectronico = Convert.ToString(reader["CuentaCorreoElectronico"]);
                cuenta.estado = Convert.ToString(reader["CuentaEstado"]);
                persona.persona_id = Convert.ToInt32(reader["PersonaPersona_id"]);
                persona.nombre = Convert.ToString(reader["PersonaNombre"]);
                persona.estado = Convert.ToString(reader["PersonaEstado"]);
                perfil.perfil_id = Convert.ToInt32(reader["PerfilPerfil_id"]);
                perfil.nombre = Convert.ToString(reader["PerfilNombre"]);
                perfil.descripcion = Convert.ToString(reader["PerfilDescripcion"]);
                perfil.estado = Convert.ToString(reader["PerfilEstado"]);

                cuenta.persona = persona;
                cuenta.perfil = perfil;

                cuentas.Add(cuenta);

            }
            return cuentas;
        }

        public int registrarCuenta(Cuenta c)
        {
            DataSource ds = new DataSourceImpl();

            String consulta = "INSERT INTO PERSONA (persona_id, nombre, estado) VALUES " +
                "(" + c.persona.persona_id + ", '" + c.persona.nombre + "', '" + c.persona.estado + "');" +
                "INSERT INTO CUENTA (cuenta_id, usuario, contrasena, correoelectronico, estado, persona_id, perfil_id) VALUES " +
                "(" + c.cuenta_id + ", '" + c.usuario + "', '" + c.contrasena + "', '" + c.correoelectronico + "', '" + c.estado + "', " + c.persona.persona_id +", " + c.perfil.perfil_id + ");";

            return ds.EjecutarActualizacion(consulta);
        }

        public int actualizarCuenta(Cuenta c)
        {
            DataSource ds = new DataSourceImpl();

            String consulta =
                "UPDATE cuenta " +
                "SET usuario = '" + c.usuario + "', contrasena = '" + c.contrasena + "', correoelectronico = '" + c.correoelectronico + "' " +
                "WHERE cuenta_id = " + c.cuenta_id +";";

            return ds.EjecutarActualizacion(consulta);
        }

        public int eliminarCuenta(Cuenta c)
        {
            DataSource ds = new DataSourceImpl();

            string consulta =
                "DELETE FROM cuenta " +
                "WHERE cuenta_id = " + c.cuenta_id + ";" +
                "DELETE FROM persona " +
                "WHERE persona_id = " + c.persona.persona_id + ";";

            return ds.EjecutarActualizacion(consulta);
        }
    }
}
