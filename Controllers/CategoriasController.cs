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
    [RoutePrefix("api/Categorias")]
    [Authorize]
    public class CategoriasController : ApiController
    {
        // GET api/Categorias/Listar
        [HttpGet]
        [Route("Listar")]
        public IQueryable<Categoria> Listar()
        {
            clsCategoria categoria = new clsCategoria();
            return categoria.ListarCategorias();
        }

        // GET api/Categorias/Consultar/5
        [HttpGet]
        [Route("Consultar/{id}")]
        public Categoria Consultar(int id)
        {
            clsCategoria categoria = new clsCategoria();
            return categoria.Consultar(id);
        }

        // POST api/Categorias/Insertar
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Categoria categoria)
        {
            clsCategoria _categoria = new clsCategoria();
            _categoria.categoria = categoria;
            return _categoria.Insertar();
        }

        // PUT api/Categorias/Actualizar
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Categoria categoria)
        {
            clsCategoria _categoria = new clsCategoria();
            _categoria.categoria = categoria;
            return _categoria.Actualizar();
        }

        // DELETE api/Categorias/Eliminar/5
        [HttpDelete]
        [Route("Eliminar/{id}")]
        public string Eliminar(int id)
        {
            clsCategoria _categoria = new clsCategoria();
            return _categoria.Eliminar(id);
        }
    }
}
