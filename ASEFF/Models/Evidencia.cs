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
    
    public partial class Evidencia
    {
        public int ID_ACTIVIDAD { get; set; }
        public byte[] EVIDENCIA1 { get; set; }
    
        public virtual Actividad Actividad { get; set; }
    }
}