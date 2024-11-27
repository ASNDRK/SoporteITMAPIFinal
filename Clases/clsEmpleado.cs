using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoporteITMAPI.Clases
{
    public class clsEmpleado
    {
<<<<<<< HEAD
        private SoporteEntities dbSoporte = new SoporteEntities();
        public EMPLeado empleado { get; set; }
        public IQueryable Consultar(string Documento)
        {
            return from U in dbSoporte.Set<Usuario>()
                   join E in dbSoporte.Set<Empleado>()
                   on U.IdUsuario equals E.IdUsuario
                   join UR in dbSoporte.Set<Usuario_Rol>()
                   on UR.IdUsuario equals U.IdUsuario
                   join R in dbSoporte.Set<Role>()
                   on UR.IdRol equals R.IdRol
                   where E.Documento == Documento
                   select new
                   {
                       Empleado = E.Nombre + " " + E.PrimerApellido + " " + E.SegundoApellido,
                       Role = R.NombreRol
                   };
        }
        /*public IQueryable ConsultarXUsuario(string Usuario)
        {
            return from U in dbSoporte.Set<Usuario>()
                   join E in dbSoporte.Set<Empleado>()
                   on U.IdUsuario equals E.IdUsuario
                   join UR in dbSoporte.Set<Usuario_Rol>()
                   on U.IdUsuario equals UR.IdUsuario
                   join U in dbSoporte.Set<Usuario>()
                   on E.Documento equals U.Documento_Empleado
                   where U.userName == Usuario
                   select new
                   {
                       idEmpleadoCargo = EC.Codigo,
                       Empleado = E.Nombre + " " + E.PrimerApellido + " " + E.SegundoApellido,
                       Role = R.NombreRol
                   };
        }*/
=======
        
>>>>>>> c01f27451e9a719a8decfceb6aa5e00c2b3e6e6d
    }
}