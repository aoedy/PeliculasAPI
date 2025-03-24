using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.AspNetCore.Razor.TagHelpers;
using PeliculasAPI.Entidades;
using System.Threading.Tasks;

namespace PeliculasAPI.Controllers
{
    [Route("api/generos")]
    public class GenerosController: ControllerBase
    {
        [HttpGet] //api/generos
        [HttpGet("listado")] //api/generos/listado
        [HttpGet("/listado-generos")] //listado-generos

        public List<Genero> Get()
        {
            var repositorio = new RepositorioEnMemoria();
            var generos = repositorio.ObtenerTodosLosGeneros();
            return generos;
        }

        [HttpGet("{id:int}")] //api/generos/500
        [OutputCache]
        public async Task<ActionResult<Genero>> Get(int id)
        {
            var repositorio = new RepositorioEnMemoria();
            var genero =  await  repositorio.ObtenerPorId(id);

            if (genero is null)
            {
                return NotFound();
            }
            return genero;
        }

        [HttpGet("{nombre}")] //api/generos/Felipe
        public async Task<Genero?> Get(string nombre)
        {
            var repositorio = new RepositorioEnMemoria();
            var genero = await repositorio.ObtenerPorId(1);
            return genero;
        }

        [HttpPost]
        public void Post()
        {

        }

        [HttpPut]
        public void Put()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }
    }
}
