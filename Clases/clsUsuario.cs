using SoporteITMAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SoporteITMAPI.Clases
{
    public class clsUsuario
    {
        private SoporteEntities dbsoporte = new SoporteEntities();
        public Usuario usuario { get; set; }
        public string Insertar()
        {
            try
            {
                //Para grabar en la base de datos con EF, solo se invoca el método .add de la clase que se quiere gestionar
                dbsoporte.Usuarios.Add(usuario);
                //Se debe grabar en la información con el método .savechanges();
                dbsoporte.SaveChanges();
                //Retorna la respuesta
                return "Se grabó el usuario: " + usuario.Correo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                dbsoporte.Usuarios.AddOrUpdate(usuario);
                dbsoporte.SaveChanges();
                return "Se actualizaron los datos del cliente con Documento: " + usuario.Documento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar()
        {
            try
            {
                //Hay que consultar el cliente, como el método devuelve un objeto de tipo cliente, debo crear una instancia de la clase CLIEnte
                Usuario _usuario = Consultar(usuario.Documento);
                //Se valida si el cliente existe para eliminarlo
                if (_usuario == null)
                {
                    //El cliente no existe
                    return "El usuario no se encuentra en la base de datos";
                }
                else
                {
                    dbsoporte.Usuarios.Remove(_usuario);
                    dbsoporte.SaveChanges();
                    return "Se eliminó el usuario: " + _usuario.Correo;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public Usuario Consultar(string Documento)
        {
            //Para consultar se utiliza la funcion FirstOrDefault() con las condiciones de la consulta dentro del paréntesis
            //Para elaborar el filtro, se utilizan las expresioens lambda
            //Las expresiones lambda, son "variables" que se convierten en una instancia del objeto que se está "trabajando"
            //Se escribe la "variable" seguido de la instrución "=>"
            return dbsoporte.Usuarios.FirstOrDefault(u => u.Documento == Documento);
        }
        //public IQueryable ClientesConTelefonos()
        //{
        //    return from C in dbsoporte.Set<Usuario>()
        //           join T in dbSuper.Set<TELEfono>()
        //           on C.Documento equals T.Documento into TeN
        //           from x in TeN.DefaultIfEmpty()
        //           orderby C.Nombre, C.PrimerApellido, C.SegundoApellido
        //           group TeN by new { C.Documento, C.Nombre, C.PrimerApellido, C.SegundoApellido, C.FechaNacimiento, C.Email, C.Direccion }
        //           into g
        //           select new
        //           {
        //               Editar = "<img src=\"../Imagenes/Editar.png\" onclick=\"Editar('" + g.Key.Documento + "', '" + g.Key.Nombre + "', '" + g.Key.PrimerApellido +
        //                         "', '" + g.Key.SegundoApellido + "', '" + g.Key.Direccion + "', '" + g.Key.Email + "', '" + g.Key.FechaNacimiento + "') \"style=\"cursor:grab\"/>",
        //               //Editar = "<button type='button' class='btn btn-primary' data-toggle='modal' data-target='#modTelefono'>Edit</button>",
        //               NroTelefonos = g.Count(),
        //               Documento = g.Key.Documento,
        //               Nombre = g.Key.Nombre + " " + g.Key.PrimerApellido + " " + g.Key.SegundoApellido,
        //               Direccion = g.Key.Direccion,
        //               Email = g.Key.Email,
        //               FechaNacimiento = g.Key.FechaNacimiento
        //           };
    }
    
}