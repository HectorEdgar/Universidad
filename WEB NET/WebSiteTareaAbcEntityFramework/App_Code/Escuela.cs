﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Alumno
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Alumno()
    {
        this.Calificacions = new HashSet<Calificacion>();
    }

    public int AluId { get; set; }
    public string AluNombre { get; set; }
    public string AluApellido { get; set; }
    public int AluEdad { get; set; }
    public string AluDireccion { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Calificacion> Calificacions { get; set; }
}

public partial class Calificacion
{
    public int NotId { get; set; }
    public string NotNota { get; set; }
    public int MatId { get; set; }
    public int AluId { get; set; }

    public virtual Alumno Alumno { get; set; }
    public virtual Materia Materia { get; set; }
}

public partial class Materia
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Materia()
    {
        this.Calificacions = new HashSet<Calificacion>();
    }

    public int MatId { get; set; }
    public string MatNombre { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Calificacion> Calificacions { get; set; }
}