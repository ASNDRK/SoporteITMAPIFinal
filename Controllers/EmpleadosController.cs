using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SoporteITMAPI.Controllers
{
    [EnableCors(origins: "https://localhost:44391", headers: "*", methods: "*")]
    [RoutePrefix("api/Empleados")]
    [Authorize]
    public class EmpleadosController : ApiController
    {
        [HttpGet]
        [Route("ConsultarXDocumento")]
        public IQueryable ConsultarXDocumento(string Documento)
        {
            clsEmpleado empleado = new clsEmpleado();
            return empleado.Consultar(Documento);
        }
        /*[HttpGet]
        [Route("ConsultarXUsuario")]
        public IQueryable ConsultarXUsuario(string Usuario)
        {
            clsEmpleado empleado = new clsEmpleado();
            return empleado.ConsultarXUsuario(Usuario);
        }*/
    }
}