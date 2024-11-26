using SoporteITMAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SoporteITMAPI.Clases
{
    public class clsRol
    {
        private SoporteEntities dbsoporte = new SoporteEntities();
        public Role rol { get; set; }

        // Método para insertar un nuevo rol
        public string Insertar()
        {
            try
            {
                // Se agrega el rol a la base de datos con EF
                dbsoporte.Roles.Add(rol);
                dbsoporte.SaveChanges();
                return "Se grabó el rol: " + rol.NombreRol;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para actualizar un rol existente
        public string Actualizar()
        {
            try
            {
                // Se utiliza AddOrUpdate para actualizar los datos si el rol ya existe
                dbsoporte.Roles.AddOrUpdate(rol);
                dbsoporte.SaveChanges();
                return "Se actualizaron los datos del rol: " + rol.NombreRol;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para eliminar un rol
        public string Eliminar(int id)
        {
            try
            {
                // Se consulta el rol por ID
                Role _rol = Consultar(id);
                if (_rol == null)
                {
                    // Si el rol no existe, se devuelve un mensaje
                    return "El rol no se encuentra en la base de datos";
                }
                else
                {
                    // Se elimina el rol
                    dbsoporte.Roles.Remove(_rol);
                    dbsoporte.SaveChanges();
                    return "Se eliminó el rol: " + _rol.NombreRol;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para consultar un rol por ID
        public Role Consultar(int id)
        {
            // Se consulta el rol usando el ID
            return dbsoporte.Roles.FirstOrDefault(r => r.IdRol == id);
        }

        // Método para listar todos los roles
        public IQueryable<Role> ListarRoles()
        {
            // Se retorna la lista completa de roles
            return dbsoporte.Roles;
        }
    }
}
