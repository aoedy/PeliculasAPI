using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTOs
{
    public class RatingCreacionDTO
    {
        public int PeliculaId { get; set; }
        [Range(1, 5)] // Validación para que la puntuación esté entre 1 y 5
        public int Puntuacion { get; set; }
    }
}
