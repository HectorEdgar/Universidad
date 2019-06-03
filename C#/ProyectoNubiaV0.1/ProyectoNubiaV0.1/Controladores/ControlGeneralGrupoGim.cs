using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoNubiaV0._1.Controladores;
using ProyectoNubiaV0._1.Modelos;

namespace ProyectoNubiaV0._1.Controladores
{
    class ControlGeneralGrupoGim
    {
        public ControlAlumno controlAlum { get; }
        public ControlGrupoAlumnos controlGrupoAlum { get; }
        public ControlGrupoGimnasio controGrupoGimnasio { get; }
        public ControlHorarioGimnasio controlHorario { get; }
        public List<GrupoGimnasio> gruposGimnasio { get; set; }
        public Alumnos_GrupoGimnasio alumno_GrupoGimnasio { get; set; }
        public List<Alumnos_GrupoGimnasio> alumnosGruposGimnasios { get; set; }
        public ControlGeneralGrupoGim()
        {
            this.controlAlum = new ControlAlumno();
            this.controlGrupoAlum = new ControlGrupoAlumnos();
            this.controGrupoGimnasio = new ControlGrupoGimnasio();
            this.controlHorario = new ControlHorarioGimnasio();
           
        }

        public void obtenerAlumnosGrupos_Gimnasio()
        {
            Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities();

            alumnosGruposGimnasios = entity.Alumnos_GrupoGimnasio.Select(p=>p).ToList();

        }

        public void buscarAlumno_GrupoGimnasio(String matricula,String nombreGimnasio)
        {
            Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities();
            alumno_GrupoGimnasio = entity.Alumnos_GrupoGimnasio.Where(p=>p.Matricula==matricula &&
               p.GrupoGimnasio.nombre==nombreGimnasio ).FirstOrDefault();
        }
       
        public void obtenerGruposGimnasio()
        {
            Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities();
            gruposGimnasio = entity.GrupoGimnasios.Select(p=>p).ToList();

        }

        public void actualizarAlumno_GrupoGimnasio(String matricula, int idGimnasio)
        {
            Sistema_GimnasioEntities entity = new Sistema_GimnasioEntities();

            Alumnos_GrupoGimnasio aux = entity.Alumnos_GrupoGimnasio.Where(p=>p.Matricula == matricula && p.idGimnasio == alumno_GrupoGimnasio.idGimnasio).First();
            aux.idGimnasio = idGimnasio;
            entity.SaveChanges();
            
        }

        public bool BuscarAlumnosGrupoGimnasio(String nombre)
        {
            if (this.controGrupoGimnasio.obtenerGrupoGim(nombre) != null)
            {
                if (this.controlGrupoAlum.obtenerAlGrupoGim(this.controlAlum.alumno.Matricula) != null)
                {
                    if (this.controlGrupoAlum.obtenerAlGrupoGim(this.controGrupoGimnasio.grupogim.idGimnasio) != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}

