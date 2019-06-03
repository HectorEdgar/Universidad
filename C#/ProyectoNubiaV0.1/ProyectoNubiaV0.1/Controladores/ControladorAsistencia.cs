using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNubiaV0._1.Modelos;
using System.Windows.Forms;

namespace ProyectoNubiaV0._1.Controladores
{
    class ControladorAsistencia
    {

        public GrupoGimnasio grupoGimnasio { get; set; }
        public List<GrupoGimnasio> gruposGimnasio { get; set; }
        public List<Alumnos_GrupoGimnasio> alumnosGrupoGimnasio { get; set; }
        public List<Asistencia> asistencias { get; set; }
        public Asistencia asistencia { get; set; }
        public ControlHorarioGimnasio_Horas controlHorarioGimnasioHoras { get; set; }
        public ControlHoras ControlHoras { get; set; }
        public List<Alumno> alumnos { get; set; }


        public ControladorAsistencia()
        {
            this.controlHorarioGimnasioHoras = new ControlHorarioGimnasio_Horas();
            this.ControlHoras = new ControlHoras();
        }

        public void obtenerAlumnos()
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                alumnos = entity.Alumnoes.Select(p=>p).ToList();
            }
        }

        public void buscarHorario(int idHorarioGimnasio)
        {
            controlHorarioGimnasioHoras.obtenerHorarioGimnasio_Horas(idHorarioGimnasio);
            ControlHoras.buscarHora(controlHorarioGimnasioHoras.horarioGimnasio_Horas[0].IdHora);

        }
        public List<GrupoGimnasio> obtenerGruposGimnasio()
        {
            Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities();


            gruposGimnasio = entity.GrupoGimnasios.Select(p => p).ToList();
            return gruposGimnasio;


        }

        public string fechasFaltas { get; set; }
        public int contarFaltas(String matricula,int idGimnasio)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                fechasFaltas = "";
                asistencias= entity.Asistencias.Where(p=>
                p.Matricula == matricula &&
                p.idGimnasio==idGimnasio &&
                p.Estado.Contains("Falta")).ToList();
                
                for (int i = 0; i < asistencias.Count; i++)
                {
                    fechasFaltas = fechasFaltas  + asistencias[i].Fecha + "     ";
                }
                return asistencias.Count;
            }
        }

        
        public List<Alumnos_GrupoGimnasio> obtenerAlumnosGimnasio()
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                alumnosGrupoGimnasio = entity.Alumnos_GrupoGimnasio.Select(p => p).ToList();
                return alumnosGrupoGimnasio;
            }
        }


        public List<Alumnos_GrupoGimnasio> obtenerAlumnosGimnasio(int idGimnasio)
        {
            Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities();

            alumnosGrupoGimnasio = entity.Alumnos_GrupoGimnasio.Where(p => p.idGimnasio == idGimnasio).ToList();
            return alumnosGrupoGimnasio;

        }
        public bool comprobarDia(String dia)
        {
            for (int i = 0; i < controlHorarioGimnasioHoras.horarioGimnasio_Horas.Count; i++)
            {
                //MessageBox.Show("/" + controlHorarioGimnasioHoras.horarioGimnasio_Horas[i].Dia + "/" + dia + "/");
                if (controlHorarioGimnasioHoras.horarioGimnasio_Horas[i].Dia.Equals(dia))
                {

                    return true;
                }
            }
            return false;
        }

        public void actualizarAsistencias(DateTime fecha, String estado, String matricula, int idGimnasio)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                Asistencia asistencia = entity.Asistencias.Where(
                    p => p.idGimnasio == idGimnasio
                    && p.Matricula == matricula
                    && p.Fecha.Year == fecha.Year
                    && p.Fecha.Month == fecha.Month
                    && p.Fecha.Day == fecha.Day).First();

                asistencia.Estado = estado;
                entity.SaveChanges();

            }
        }

        public void agregarAsistencia(DateTime fecha, String estado, String matricula, int idGimnasio)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {
                Asistencia asistencia = new Asistencia();
                asistencia.Fecha = fecha;
                asistencia.Estado = estado;
                asistencia.Matricula = matricula;
                asistencia.idGimnasio = idGimnasio;

                entity.Asistencias.Add(asistencia);
                entity.SaveChanges();

            }

        }
        public void obtenerAsistencias(int idGimnasio, DateTime fecha)
        {
            Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities();
            asistencias = entity.Asistencias.Where(
                    p => p.idGimnasio == idGimnasio
                    && p.Fecha.Year == fecha.Year
                    && p.Fecha.Month == fecha.Month
                    && p.Fecha.Day == fecha.Day).ToList();
        }

        public void buscarAsistencia(String matricula)
        {
            Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities();
            
                asistencias = entity.Asistencias.Where(p => p.Matricula.Equals(matricula)).ToList();
        }

        public bool tieneAsistencia(String matricula, int idGimnasio, DateTime fecha)
        {
            Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities();
            

                asistencia= entity.Asistencias.Where(
                    p => p.Matricula == matricula
                    && p.idGimnasio == idGimnasio
                    && p.Fecha.Year == fecha.Year
                    && p.Fecha.Month == fecha.Month
                    && p.Fecha.Day == fecha.Day).FirstOrDefault();

                if (asistencia != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }

        public int contarAsistencia(String matricula, int idGimnasio, DateTime fecha)
        {
            using (Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities())
            {

                return entity.Asistencias.Where(
                    p => p.Matricula == matricula
                    && p.idGimnasio == idGimnasio
                    && p.Fecha.Year == fecha.Year
                    && p.Fecha.Month == fecha.Month
                    && p.Fecha.Day == fecha.Day).ToList().Count;
            }
        }


    }
}
