using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public interface IPublicacionService
    {
        IEnumerable<Publicacion> Obtener();
        bool Agregar(Publicacion model);
        bool Actualizar(Publicacion model);
        bool Eliminar(int id);
        Publicacion Get(int id);




    }

   public class PublicacionService:IPublicacionService
    {
        private readonly DbPublicacion _dbPublicacion;

        public PublicacionService(
           DbPublicacion dbPublicacion
            )
        {
            _dbPublicacion = dbPublicacion;
        }

        public IEnumerable<Publicacion> Obtener()
        {
            var resultados = new List<Publicacion>();
            try
            {

                resultados = _dbPublicacion.Publicacion.ToList();


            }
            catch (System.Exception)
            {

            }

            return resultados;

        }

        public Publicacion Get(int id)
        {
            var result = new Publicacion();
            try
            {
                result = _dbPublicacion.Publicacion.Single(X => X.idPublicaciones == id);
            }
            catch (System.Exception)
            {

                
            }
            return result;

        }




        //Agregar
        public bool Agregar(Publicacion model) 
        {
            try
            {
                _dbPublicacion.Add(model);
                _dbPublicacion.SaveChanges();

            }
            catch (System.Exception)
            {

                return false;
            }

            return true;
           
        }

        //Actualizar
        public bool Actualizar(Publicacion model)
        {
            try
            {
                var originalModel = _dbPublicacion.Publicacion.Single(x => x.idPublicaciones == model.idPublicaciones);

                originalModel.idPublicaciones = model.idPublicaciones;
                originalModel.idpais = model.idpais;
                originalModel.IdCategoria = model.IdCategoria;
                originalModel.idEmpleado = model.idEmpleado;
                originalModel.idAdministrador = model.idAdministrador;
                originalModel.Nombre_Compañia = model.Nombre_Compañia;
                originalModel.Tipo_Horario = model.Tipo_Horario;
                originalModel.Correo = model.Correo;
                originalModel.Logo = model.Logo;
                originalModel.Url_Pagina = model.Url_Pagina;
                originalModel.Posicion = model.Posicion;
                originalModel.Dirreccion = model.Dirreccion;

                

                _dbPublicacion.Update(originalModel);
                _dbPublicacion.SaveChanges();

            }
            catch (System.Exception)
            {

                return false;
            }

            return true;

        }

        //Eliminar  
        public bool Eliminar(int id)
        {
            try
            {
                _dbPublicacion.Entry(new Publicacion {idPublicaciones = id}).State = EntityState.Deleted;
                _dbPublicacion.SaveChanges();

            }
            catch (System.Exception)
            {

                return false;
            }

            return true;

        }





    }
}
