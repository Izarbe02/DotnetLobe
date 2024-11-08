
using Microsoft.AspNetCore.Mvc;
using Models;

namespace RestauranteAPI.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class PeliculaController : ControllerBase
   {
       private static List<Peliculas> peliclula = new List<Peliculas>();

       [HttpGet]
       public ActionResult<IEnumerable<Peliculas>> GetPeliculas()
       {
           return Ok(peliculas);
       }

       [HttpGet("{id}")]
       public ActionResult<Peliculas> GetPelicula(int id)
       {
           var pelicula = peliculas.FirstOrDefault(p => p.Id == id);
           if (pelicula == null)
           {
               return NotFound();
           }
           return Ok(pelicula);
       }

       [HttpPost]
       public ActionResult<Peliculas> CreatePelicula(Peliculas pelicula)
       {
           peliculas.Add(pelicula);
           return CreatedAtAction(nameof(GetPelicula), new { id = pelicula.Id }, pelicula);
       }

       [HttpPut("{id}")]
       public IActionResult UpdatePelicula(int id, Peliculas updatedpelicula)
       {
           var pelicula = peliculas.FirstOrDefault(p => p.Id == id);
           if (pelicula == null)
           {
               return NotFound();
           }
           pelicula.Nombre = updatedpelicula.Nombre;
           pelicula.Id = updatedpelicula.Id;
           pelicula.Director = updatedpelicula.Director;
           pelicula.Sinopsis = updatedpelicula.Sinopsis;
           pelicula.Precio = updatedpelicula.Precio;
        
           return NoContent();
       }

       [HttpDelete("{id}")]
       public IActionResult DeletePelicula(int id)
       {
           var pelicula = peliculas.FirstOrDefault(p => p.Id == id);
           if (pelicula == null)
           {
               return NotFound();
           }
           peliculas.Remove(pelicula);
           return NoContent();
       }

       public static void InicializarDatos()
       {
            peliculas.Add(new Pelicula{Nombre = "Reservovirr dogs", Id = 1, Director = "Quentin Tarantino", Sinopsis = "Seis criminales profesionales son contratados para robar en un almacén de diamantes, pero la policía aparece inesperadamente en el momento del atraco. Algunos miembros de la banda mueren en el enfrentamiento y otros logran huir.", Precio= 5.5 });   
            peliculas.Add(new Pelicula{Nombre = "Star Wars", Id = 2, Director = "George Lucas", Sinopsis = "La nave en la que viaja la princesa Leia es capturada por las tropas imperiales al mando del temible Darth Vader. Antes de ser atrapada, Leia consigue introducir un mensaje en su robot R2-D2, quien acompañado de su inseparable C-3PO logran escapar.", Precio= 5.5});    
            peliculas.Add(new Pelicula{Nombre = "Akira", Id = 3, Director = "Katsuhiro Otomo", Sinopsis = " En el Neo-Tokio de 2019, tras la Tercera Guerra Mundial, los viejos amigos Kaneda y Tetsuo son miembros de una violenta banda de motociclistas. Durante una pelea con una banda rival, un extraño niño pequeño con la cara arrugada entra en la refriega.", Precio= 5.5});    
            peliculas.Add(new Pelicula{Nombre = "2001: A Space Odyssey", Id = 4, Director = "Stanley Kubrick", Sinopsis = "La película de ciencia ficción por antonomasia de la historia del cine narra los diversos periodos de la historia de la humanidad, no sólo del pasado, sino también del futuro.", Precio= 5.5});    
            peliculas.Add(new Pelicula{Nombre = "Casino Royale", Id = 5.5, Director = "Martin Campbell", Sinopsis = "La primera misión del agente británico James Bond como agente 007 lo lleva hasta Le Chiffre, banquero de los terroristas de todo el mundo. Para detenerlo y desmantelar la red de terrorismo, Bond debe derrotarlo en una arriesgada partida de póquer en el Casino Royale.", Precio= 5.5});    
            peliculas.Add(new Pelicula{Nombre = "Enter the void", Id =6, Director = "Gaspar Noe", Sinopsis = "Argumento. Óscar (Nathaniel Brown) vive en Tokio con su hermana, Linda (Paz de la Huerta), y se sustenta a sí mismo vendiendo drogas, contra el consejo de su amigo, Alex (Cyril Roy). Alex intenta reubicar el interés de Óscar en el Libro tibetano de los muertos, un libro budista sobre la vida después de la muerte.", Precio= 5.5});     
          }
   }
}

