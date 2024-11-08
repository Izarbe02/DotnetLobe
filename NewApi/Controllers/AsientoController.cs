
using Microsoft.AspNetCore.Mvc;
using Models;

namespace RestauranteAPI.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class Asientos : ControllerBase
   {
       private static List<Asientos> Asiento = new List<Asientos>();

       [HttpGet]
       public ActionResult<IEnumerable<Asientos> GetAsientos()
       {
           return Ok(entradas);
       }

       [HttpGet("{id}")]
       public ActionResult<Entradas>GetEntradas(int id)
       {
                var entrada = entradas.FirstOrDefault(p => p.Id == id);
        if (entrada == null)
                {
                    return NotFound();
                }
                return Ok(entrada);
       }

       [HttpPost]

       public ActionResult<Entradas> CreateEntrada(Entradas entrada)
       entrada.Add(entrada);
       return CreatedAtAction(nameof(GetEntradas), new { id = entrada.Id }, entrada);
   
        [HttpPut("{id}")]
       public IActionResult UpdateEntrada(int id, Entradas updatedEntrada)
       {
           var entrada = entradas.FirstOrDefault(p => p.Id == id);
           if (entrada == null)
           {
               return NotFound();
           }
           entrada.Nombre = updatedEntrada.Fila;
           entrada.Columna = updatedEntrada.Columna;
           entrada.Id = updatedEntrada.Id;
            entrada.Ocupado = updatedEntrada.Ocupado
           return NoContent();
       }



       [HttpDelete("{id}")]
       public IActionResult DeleteEntrada(int id)
       {
           var entrada = entradas.FirstOrDefault(p => p.Id == id);
           if (entrada == null)
           {
               return NotFound();
           }
           entradas.Remove(entrada);
           return NoContent();
       }

       public static void InicializarDatos()
       {    
        entradas.Add(new Entradas());
       }
   }
}

