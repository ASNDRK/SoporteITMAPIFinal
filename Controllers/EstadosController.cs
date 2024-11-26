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
    [RoutePrefix("api/Estados")]
    [Authorize]
    public class EstadoController : ApiController
    {
        // GET api/Estados/ConsultarPorId
        [HttpGet]
        [Route("ConsultarPorId")]
        public Estado ConsultarPorId(int id)
        {
            // Instancia de la clase clsEstado e invocación del método para consultar por ID
            clsEstado estado = new clsEstado();
            return estado.Consultar(id);
        }

        // GET api/Estados/Listado
        [HttpGet]
        [Route("Listado")]
        public IEnumerable<Estado> Listado()
        {
            // Instancia de la clase clsEstado e invocación del método para obtener el listado de estados
            clsEstado estado = new clsEstado();
            return estado.ListarEstados();
        }

        // POST api/Estados/Insertar
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Estado estado)
        {
            // Instancia de clsEstado, se pasa el objeto estado y se invoca el método Insertar
            clsEstado _estado = new clsEstado();
            _estado.estado = estado;
            return _estado.Insertar();
        }

        // PUT api/Estados/Actualizar
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Estado estado)
        {
            // Instancia de clsEstado, se pasa el objeto estado y se invoca el método Actualizar
            clsEstado _estado = new clsEstado();
            _estado.estado = estado;
            return _estado.Actualizar();
        }

        // DELETE api/Estados/Eliminar
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id)
        {
            // Instancia de clsEstado y eliminación del estado por ID
            clsEstado _estado = new clsEstado();
            return _estado.Eliminar(id);
        }
    }
}
