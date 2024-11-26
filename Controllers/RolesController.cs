using SoporteITMAPI.Clases;
using SoporteITMAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SoporteITMAPI.Controllers
{
    [EnableCors(origins: "https://localhost:44391/", headers: "*", methods: "*")]
    [RoutePrefix("api/Roles")]
    [Authorize]
    public class RolesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarPorId")]
        public Role ConsultarPorId(int id)
        {
            // Instancia de la clase clsRol e invocación del método para consultar por ID
            clsRol rol = new clsRol();
            return rol.Consultar(id);
        }

        [HttpGet]
        [Route("Listado")]
        public IEnumerable<Role> Listado()
        {
            // Instancia de la clase clsRol e invocación del método para obtener el listado de roles
            clsRol rol = new clsRol();
            return rol.ListarRoles();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Role rol)
        {
            // Instancia de clsRol, se pasa el objeto rol y se invoca el método Insertar
            clsRol _rol = new clsRol();
            _rol.rol = rol;
            return _rol.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Role rol)
        {
            // Instancia de clsRol, se pasa el objeto rol y se invoca el método Actualizar
            clsRol _rol = new clsRol();
            _rol.rol = rol;
            return _rol.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id)
        {
            // Instancia de clsRol y eliminación del rol por ID
            clsRol _rol = new clsRol();
            return _rol.Eliminar(id);
        }
    }
}
