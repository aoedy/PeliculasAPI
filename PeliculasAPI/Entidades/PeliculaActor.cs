using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.Entidades
{
    public class PeliculaActor
    {
        public int ActorId { get; set; }
        public int PeliculaId { get; set; }
        [StringLength(300)]
        public required string Personaje { get; set; } = null!; // Personaje que interpreta el actor en la pelicula
        public int Orden { get; set; } // Para el orden de los actores en la pelicula
        public Actor Actor { get; set; } = null!;
        public Pelicula Pelicula { get; set; } = null!;
    }
}
