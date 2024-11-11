

using Microsoft.AspNetCore.Mvc;


namespace CineAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PeliculaController : ControllerBase
{
    private static List<Pelicula> peliculas = new List<Pelicula>();

    // Método para inicializar datos



    [HttpGet]
    public ActionResult<IEnumerable<Pelicula>> GetPeliculas()
    {
        return Ok(peliculas);
    }

    [HttpGet("{id}")]
    public ActionResult<Pelicula> GetPelicula(int id)
    {
        var pelicula = peliculas.FirstOrDefault(p => p.Id == id);
        if (pelicula == null)
        {
            return NotFound();
        }
        return Ok(pelicula);
    }

    [HttpPost]
    public ActionResult<Pelicula> CreatePelicula(Pelicula pelicula)
    {
        peliculas.Add(pelicula);
        return CreatedAtAction(nameof(GetPelicula), new { id = pelicula.Id }, pelicula);
    }

    [HttpPut("{id}")]
    public IActionResult UpdatePelicula(int id, Pelicula updatedpelicula)
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


        return NoContent();
    }

    public static void InicializarDatos()
    {
        peliculas.Add(new Pelicula(nombre: "Reservoir Dogs", id: 1, director: "Quentin Tarantino", sinopsis: "Seis criminales profesionales son contratados para robar en un almacén de diamantes, pero la policía aparece inesperadamente en el momento del atraco. Algunos miembros de la banda mueren en el enfrentamiento y otros logran huir."));
        peliculas.Add(new Pelicula(nombre: "Star Wars", id: 2, director: "George Lucas", sinopsis: "La nave en la que viaja la princesa Leia es capturada por las tropas imperiales al mando del temible Darth Vader. Antes de ser atrapada, Leia consigue introducir un mensaje en su robot R2-D2, quien acompañado de su inseparable C-3PO logran escapar."));
        peliculas.Add(new Pelicula(nombre: "Akira", id: 3, director: "Katsuhiro Otomo", sinopsis: "En el Neo-Tokio de 2019, tras la Tercera Guerra Mundial, los viejos amigos Kaneda y Tetsuo son miembros de una violenta banda de motociclistas. Durante una pelea con una banda rival, un extraño niño pequeño con la cara arrugada entra en la refriega."));
        peliculas.Add(new Pelicula(nombre: "2001: A Space Odyssey", id: 4, director: "Stanley Kubrick", sinopsis: "La película de ciencia ficción por antonomasia de la historia del cine narra los diversos periodos de la historia de la humanidad, no sólo del pasado, sino también del futuro."));
        peliculas.Add(new Pelicula(nombre: "Casino Royale", id: 5, director: "Martin Campbell", sinopsis: "La primera misión del agente británico James Bond como agente 007 lo lleva hasta Le Chiffre, banquero de los terroristas de todo el mundo. Para detenerlo y desmantelar la red de terrorismo, Bond debe derrotarlo en una arriesgada partida de póquer en el Casino Royale."));
        peliculas.Add(new Pelicula(nombre: "Enter the Void", id: 6, director: "Gaspar Noé", sinopsis: "Óscar (Nathaniel Brown) vive en Tokio con su hermana, Linda (Paz de la Huerta), y se sustenta a sí mismo vendiendo drogas, contra el consejo de su amigo, Alex (Cyril Roy). Alex intenta reubicar el interés de Óscar en el Libro tibetano de los muertos, un libro budista sobre la vida después de la muerte."));
    }



}
