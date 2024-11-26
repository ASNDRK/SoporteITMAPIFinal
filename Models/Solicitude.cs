//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoporteITMAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Solicitude
    {
        public int IdSolicitud { get; set; }
        public string NumeroSolicitud { get; set; }
        public string Tipo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaResolucion { get; set; }
        public int IdUsuarioSolicitante { get; set; }
        public Nullable<int> IdUsuarioAsignado { get; set; }
        public int IdEstado { get; set; }
        public int IdCategoria { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}
