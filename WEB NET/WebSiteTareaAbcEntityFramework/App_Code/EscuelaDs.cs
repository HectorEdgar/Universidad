using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class EscuelaDs
{
    public EscuelaDs()
    {
  

    }



    public List<Calificacion> getCalificaciones(int startIndex, int maxRows)
    {
       

        using (escuelaEntities entities = new escuelaEntities())
        {
            return (from calificacion in entities.Calificaciones select calificacion)
                .OrderBy(calificacion => calificacion.AluId)
                .Skip(startIndex)
                .Take(maxRows).ToList();
        }
    }

    public Calificacion findCalificacion(string nombreAlumno, String nombreMateria)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {

            return (from calificacion in entities.Calificaciones select calificacion)
                .Where(p=>p.Alumno.AluNombre.Equals(nombreAlumno))
                .Where(p=>p.Materia.MatNombre.Equals(nombreMateria))
                .First();
        }
    }

    public int getCalificacionesCount()
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            return entities.Calificaciones.Count();
        }
    }
    public int addCalificacion(Calificacion calificacion)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            entities.Calificaciones.Add(calificacion);
            return entities.SaveChanges();
        }
    }
    public int updateCalificacion(int calificacionId,Calificacion calificacion)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            var aux = entities.Calificaciones.Find(calificacionId);
            aux.AluId = calificacion.AluId;
            aux.MatId = calificacion.MatId;
            aux.NotNota = calificacion.NotNota;
            aux.NotId = calificacion.NotId;

            
            return entities.SaveChanges();
        }
    }
    public int deleteCalificacion(int calificacionId)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            var aux = entities.Calificaciones.Find(calificacionId);
            entities.Calificaciones.Remove(aux);
            return entities.SaveChanges();
        }
    }
    public List<Alumno> getAlumnos(int startIndex, int maxRows)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            return (from alumno in entities.Alumnos select alumno)
                .OrderBy(alumno => alumno.AluId)
                .Skip(startIndex)
                .Take(maxRows).ToList();
        }
    }
    public List<String> getNombresAlumnos(int startIndex, int maxRows)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            return (from alumno in entities.Alumnos select alumno.AluNombre)
                .OrderBy(alumno => alumno)
                .Skip(startIndex)
                .Take(maxRows).ToList();
                           
        }
    }
    public Alumno findAlumno(String nombre, String apellido)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            
            return (from alumno in entities.Alumnos select alumno)
                .Where(alumno => alumno.AluNombre.Contains(nombre)).Where(alumno => alumno.AluApellido.Contains(apellido)).FirstOrDefault();
                
        }
    }
    public int getAlumnosCount()
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            return entities.Alumnos.Count();
        }
    }
    public int addAlumno(Alumno alumno)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            entities.Alumnos.Add(alumno);
            return entities.SaveChanges();
        }
    }
    public int updateAlumno(int AluId, Alumno alumno)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            var aux = entities.Alumnos.Find(AluId);
            aux.AluId = alumno.AluId;
            aux.AluNombre = alumno.AluNombre;
            aux.AluApellido = alumno.AluApellido;
            aux.AluEdad = alumno.AluEdad;
            aux.AluDireccion = alumno.AluDireccion;


            return entities.SaveChanges();
        }
    }
    public int deleteAlumno(int alumnoId)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            var aux = entities.Alumnos.Find(alumnoId);
            entities.Alumnos.Remove(aux);
            return entities.SaveChanges();
        }
    }
    public List<Materia> getMaterias(int startIndex, int maxRows)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            return (from materia in entities.Materias select materia)
                .OrderBy(materia => materia.MatId)
                .Skip(startIndex)
                .Take(maxRows).ToList();
        }
    }
    public Materia findMateria(String materiaNombre)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            return (from materia in entities.Materias select materia)
                .Where(p=>p.MatNombre.Contains(materiaNombre)).First();
        }
    }

    public List<String> getNombresMaterias(int startIndex, int maxRows)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            return (from materia in entities.Materias select materia.MatNombre)
                .OrderBy(materia => materia)
                .Skip(startIndex)
                .Take(maxRows).ToList();
        }

    }
    public int getMateriasCount()
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            return entities.Materias.Count();
        }
    }
    public int addMateria(Materia materia)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            entities.Materias.Add(materia);
            return entities.SaveChanges();
        }
    }
    public int updateMateria(int materiaId, Materia materia)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            var aux = entities.Materias.Find(materiaId);
            aux.MatId = materia.MatId;
            aux.MatNombre = materia.MatNombre;


            return entities.SaveChanges();
        }
    }
    public int deleteMateria(int materiaId)
    {
        using (escuelaEntities entities = new escuelaEntities())
        {
            var aux = entities.Materias.Find(materiaId);
            entities.Materias.Remove(aux);
            return entities.SaveChanges();
        }
    }




}