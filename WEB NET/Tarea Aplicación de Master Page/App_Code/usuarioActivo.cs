using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for usuarioActivo
/// </summary>
public class usuarioActivo
{
    private static Usuario usuario;
    public usuarioActivo()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static Usuario Usuario
    {
        get
        {
            return usuario;
        }

        set
        {
            usuario = value;
        }
    }
}