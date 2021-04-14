using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace APIBOLSA.Controllers
{
    [Route("[controller]")]
    public class PosterController : ControllerBase
    {
        private readonly IPublicacionService _publicacionService;

        public PosterController(IPublicacionService publicacionService)
        {
            _publicacionService = publicacionService;


        }
        // GET: api/Poster
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                _publicacionService.Obtener()
                );
            
        }

        // GET: api/Poster/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _publicacionService.Get(id)
                ) ; 
        }


        // POST: api/Poster
        [HttpPost]
        public IActionResult Post([FromBody] Publicacion model)
        {
            return Ok(
                _publicacionService.Agregar(model)
                );
        }


        // PUT: api/Poster/5
        [HttpPut("{id}")]
        public IActionResult Put( [FromBody] Publicacion model)
        {
            return Ok(
                _publicacionService.Actualizar(model)

                );
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _publicacionService.Eliminar(id)
                );
        }
    }
}
