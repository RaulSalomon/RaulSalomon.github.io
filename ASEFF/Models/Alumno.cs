//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASEFF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumno()
        {
            this.User = new HashSet<User>();
        }
    
        public int MATRICULA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO_PAT { get; set; }
        public string APELLIDO_MAT { get; set; }
        public string TELEFONO { get; set; }
        public int ESTADO { get; set; }
        public System.DateTime CUMPLEANIOS { get; set; }
        public byte[] FOTO { get; set; }
        public string CORREO { get; set; }
        public string CARRERA { get; set; }
        public string SEMESTRE { get; set; }
        public string FRATERNIDAD { get; set; }
    
        public virtual Carrera Carrera1 { get; set; }
        public virtual Estado Estado1 { get; set; }
        public virtual Fraternidad Fraternidad1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }
    }
}
