﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Comentario
{
    public int idcomentario { get; set; }
    public string usuario { get; set; }
    public Nullable<int> idpost { get; set; }
    public string comentario1 { get; set; }
    public System.DateTime hora { get; set; }

    public virtual Post Post { get; set; }
    public virtual Usuario Usuario1 { get; set; }
}

public partial class Post
{
    public Post()
    {
        this.Comentarios = new HashSet<Comentario>();
    }

    public int idpost { get; set; }
    public string nombre { get; set; }
    public string descripcion { get; set; }
    public string usuario { get; set; }

    public virtual ICollection<Comentario> Comentarios { get; set; }
    public virtual Usuario Usuario1 { get; set; }
}

public partial class Usuario
{
    public Usuario()
    {
        this.Comentarios = new HashSet<Comentario>();
        this.Posts = new HashSet<Post>();
    }

    public string usuario1 { get; set; }
    public string password { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public int pais { get; set; }
    public string sexo { get; set; }
    public string correo { get; set; }
    public string telefono { get; set; }

    public virtual ICollection<Comentario> Comentarios { get; set; }
    public virtual ICollection<Post> Posts { get; set; }
}
