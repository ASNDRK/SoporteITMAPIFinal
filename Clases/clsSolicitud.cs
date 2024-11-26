using SoporteITMAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SoporteITMAPI.Clases
{
    public class clsSolicitud
    {
        private SoporteEntities dbsoporte = new SoporteEntities();
        public Solicitude solicitud { get; set; }

        // Método para insertar una nueva solicitud
        public string Insertar()
        {
            try
            {
                dbsoporte.Solicitudes.Add(solicitud);
                dbsoporte.SaveChanges();
                return "Se grabó la solicitud con el ID: " + solicitud.IdSolicitud;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para actualizar una solicitud existente
        public string Actualizar()
        {
            try
            {
                dbsoporte.Solicitudes.AddOrUpdate(solicitud);
                dbsoporte.SaveChanges();
                return "Se actualizaron los datos de la solicitud con ID: " + solicitud.IdSolicitud;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para eliminar una solicitud
        public string Eliminar(int id)
        {
            try
            {
                Solicitude _solicitud = Consultar(id);
                if (_solicitud == null)
                {
                    return "La solicitud no se encuentra en la base de datos";
                }
                else
                {
                    dbsoporte.Solicitudes.Remove(_solicitud);
                    dbsoporte.SaveChanges();
                    return "Se eliminó la solicitud con ID: " + _solicitud.IdSolicitud;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para consultar una solicitud por ID
        public Solicitude Consultar(int id)
        {
            return dbsoporte.Solicitudes.FirstOrDefault(s => s.IdSolicitud == id);
        }

        // Método para obtener una lista de todas las solicitudes
        public IEnumerable<Solicitude> ListarSolicitudes()
        {
            return dbsoporte.Solicitudes.ToList();
        }
    }
}
