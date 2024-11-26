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
    [EnableCors(origins: "https://localhost:44391", headers: "*", methods: "*")]
    [RoutePrefix("api/Usuarios")]
    public class UsuariosController : ApiController
    {
        [HttpGet]
        [Route("ListarUsuarios")]
        public IQueryable ListarUsuarios()
        {
            clsUsuario usuario = new clsUsuario();
            return usuario.ListarUsuarios();
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Usuario usuario, int Perfil)
        {
            clsUsuario Usuario = new clsUsuario();
            Usuario.usuario = usuario;
            return Usuario.Insertar(Perfil);
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Usuario usuario, int Perfil)
        {
            clsUsuario Usuario = new clsUsuario();
            Usuario.usuario = usuario;
            return Usuario.Actualizar(Perfil);
        }
        [HttpPut]
        [Route("Activar")]
        public string Activar(int idUsuarioPerfil, bool Activo)
        {
            clsUsuario Usuario = new clsUsuario();
            return Usuario.Activar(idUsuarioPerfil, Activo);
        }
    }
}