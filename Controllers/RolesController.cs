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
    //[Authorize]
    public class RolesController : ApiController
    {


        [HttpGet]
        [Route("LlenarCombo")]
        public IQueryable LlenarCombo()
        {


            clsRol rol = new clsRol();
            return rol.LlenarCombo();
        }
        
    }
}
