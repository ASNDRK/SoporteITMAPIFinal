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

        public IQueryable LlenarCombo()
        {
            return from R in dbsoporte.Set<Role>()
                   orderby R.NombreRol
                   select new
                   {
                       Codigo = R.IdRol,
                       Nombre = R.NombreRol,
                   };
        }
    }
}
