using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
   public  class Publicacion
    {
        [Key]
        public int idPublicaciones { get; set; }

        public int idpais { get; set; }

        public int IdCategoria { get; set; }

        public int idEmpleado { get; set; }

        public int idAdministrador { get; set; }

        public string Nombre_Compañia { get; set; }

        public string Tipo_Horario { get; set; }

        public string Fecha_Publicacion { get; set; }

        public string Correo { get; set; }

        public string Logo { get; set; }

        public string Url_Pagina { get; set; }

        public string Posicion { get; set; }

        public string Dirreccion { get; set; }
    }
}
