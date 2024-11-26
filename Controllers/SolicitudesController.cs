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
    [RoutePrefix("api/Solicitudes")]
    [Authorize]
    public class SolicitudesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarPorId")]
        public Solicitude ConsultarPorId(int id)
        {
            // Instancia de la clase clsSolicitud e invocación del método para consultar por ID
            clsSolicitud solicitud = new clsSolicitud();
            return solicitud.Consultar(id);
        }

        [HttpGet]
        [Route("Listado")]
        public IEnumerable<Solicitude> Listado()
        {
            // Instancia de la clase clsSolicitud e invocación del método para obtener el listado de solicitudes
            clsSolicitud solicitud = new clsSolicitud();
            return solicitud.ListarSolicitudes();
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Solicitude solicitud)
        {
            // Instancia de clsSolicitud, se pasa el objeto solicitud y se invoca el método Insertar
            clsSolicitud _solicitud = new clsSolicitud();
            _solicitud.solicitud = solicitud;
            return _solicitud.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Solicitude solicitud)
        {
            // Instancia de clsSolicitud, se pasa el objeto solicitud y se invoca el método Actualizar
            clsSolicitud _solicitud = new clsSolicitud();
            _solicitud.solicitud = solicitud;
            return _solicitud.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id)
        {
            // Instancia de clsSolicitud y eliminación de la solicitud por ID
            clsSolicitud _solicitud = new clsSolicitud();
            return _solicitud.Eliminar(id);
        }
    }
}
