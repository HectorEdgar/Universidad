//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usser
    {
        public Usser()
        {
            this.userAutentications = new HashSet<userAutentication>();
            this.UserLoginHistories = new HashSet<UserLoginHistory>();
            this.UserRoles = new HashSet<UserRole>();
        }
    
        public string userID { get; set; }
        public bool IsAdmin { get; set; }
        public bool isActive { get; set; }
        public bool isOnline { get; set; }
    
        public virtual ICollection<userAutentication> userAutentications { get; set; }
        public virtual ICollection<UserLoginHistory> UserLoginHistories { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
