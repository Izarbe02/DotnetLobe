using Microsoft.AspNetCore.Mvc;
using CineApi;


public class Pelicula
{
    public int Id { get; set; } 
    public string Nombre { get; set; }
    public string Director { get; set; }
    public string Sinopsis { get; set; } 
    // public List<int> Peliculas { get; set; } // Lista de las películas


 public Pelicula(int id , string nombre, string director, string sinopsis) {
        Id = id;
        Nombre = nombre;
        Director = director;
         Sinopsis = sinopsis;


    }


 //Pelicula.InicializarDatos();
}