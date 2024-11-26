using SoporteITMAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SoporteITMAPI.Clases
{
    public class clsCategoria
    {
        private SoporteEntities dbsoporte = new SoporteEntities();
        public Categoria categoria { get; set; }

        // Método para insertar una nueva categoría
        public string Insertar()
        {
            try
            {
                // Se agrega la categoría a la base de datos con EF
                dbsoporte.Categorias.Add(categoria);
                dbsoporte.SaveChanges();
                return "Se grabó la categoría: " + categoria.NombreCategoria;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para actualizar una categoría existente
        public string Actualizar()
        {
            try
            {
                // Se utiliza AddOrUpdate para actualizar los datos si la categoría ya existe
                dbsoporte.Categorias.AddOrUpdate(categoria);
                dbsoporte.SaveChanges();
                return "Se actualizaron los datos de la categoría: " + categoria.NombreCategoria;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para eliminar una categoría
        public string Eliminar(int id)
        {
            try
            {
                // Se consulta la categoría por ID
                Categoria _categoria = Consultar(id);
                if (_categoria == null)
                {
                    // Si la categoría no existe, se devuelve un mensaje
                    return "La categoría no se encuentra en la base de datos";
                }
                else
                {
                    // Se elimina la categoría
                    dbsoporte.Categorias.Remove(_categoria);
                    dbsoporte.SaveChanges();
                    return "Se eliminó la categoría: " + _categoria.NombreCategoria;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Método para consultar una categoría por ID
        public Categoria Consultar(int id)
        {
            // Se consulta la categoría usando el ID
            return dbsoporte.Categorias.FirstOrDefault(c => c.IdCategoria == id);
        }

        // Método para listar todas las categorías
        public IQueryable<Categoria> ListarCategorias()
        {
            // Se retorna la lista completa de categorías
            return dbsoporte.Categorias;
        }
    }
}
