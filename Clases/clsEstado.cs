using SoporteITMAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SoporteITMAPI.Clases
{
    public class clsEstado
    {
        private SoporteEntities dbsoporte = new SoporteEntities();
        public Estado estado { get; set; }

        // Método para insertar un nuevo estado
        public string Insertar()
        {
            try
            {
                dbsoporte.Estadoes.Add(estado);
                dbsoporte.SaveChanges();
                return "Se grabó el estado: " + estado.NombreEstado;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para actualizar un estado
        public string Actualizar()
        {
            try
            {
                dbsoporte.Estadoes.AddOrUpdate(estado);
                dbsoporte.SaveChanges();
                return "Se actualizaron los datos del estado: " + estado.NombreEstado;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para eliminar un estado
        public string Eliminar(int id)
        {
            try
            {
                Estado _estado = Consultar(id);
                if (_estado == null)
                {
                    return "El estado no se encuentra en la base de datos";
                }
                else
                {
                    dbsoporte.Estadoes.Remove(_estado);
                    dbsoporte.SaveChanges();
                    return "Se eliminó el estado: " + _estado.NombreEstado;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para consultar un estado por ID
        public Estado Consultar(int id)
        {
            return dbsoporte.Estadoes.FirstOrDefault(e => e.IdEstado == id);
        }

        // Método para listar todos los estados
        public IQueryable<Estado> ListarEstados()
        {
            return dbsoporte.Estadoes;
        }
    }
}
