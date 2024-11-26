using SoporteITMAPI.Clases;
using SoporteITMAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SoporteITMAPI.Controllers
{
    [EnableCors(origins: "https://localhost:44391/", headers: "*", methods: "*")]
    [RoutePrefix("api/Usuarios")]
    [Authorize]
    public class UsuariosController : ApiController
    {
        //[HttpGet]
        //[Route("ListadoClientesConTelefono")]
        //public IQueryable ListadoClientesConTelefono()
        //{
        //    //Se crea una instancia del objeto clsCliente y se invoca el método consultar
        //    clsUsuario usuario= new clsUsuario();
        //    return usuario.ClientesConTelefonos();
        //}
        [HttpGet]
        [Route("ConsultarXDocumento")]
        public Usuario ConsultarXDocumento(string Documento)
        {
            //Se crea una instancia del objeto clsCliente y se invoca el método consultar
            clsUsuario usuario = new clsUsuario();
            return usuario.Consultar(Documento);
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Usuario usuario)
        {
            //Se crea una instancia del objeto cliente, se pasan los datos de entrada (El objeto cliente), y se invoca él método Insertar
            clsUsuario _usuario = new clsUsuario();
            _usuario.usuario = usuario;
            return _usuario.Insertar();
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Usuario usuario)
        {
            //Se crea una instancia del objeto cliente, se pasan los datos de entrada (El objeto cliente), y se invoca él método Insertar
            clsUsuario _usuario= new clsUsuario();
            _usuario.usuario = usuario;
            return _usuario.Actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Usuario usuario)
        {
            //Se crea una instancia del objeto cliente, se pasan los datos de entrada (El objeto cliente), y se invoca él método Insertar
            clsUsuario _usuario = new clsUsuario();
            _usuario.usuario = usuario;
            return _usuario.Eliminar();
        }
    }
}