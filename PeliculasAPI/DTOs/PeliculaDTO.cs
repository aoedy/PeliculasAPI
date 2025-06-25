using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTOs
{
    public class PeliculaDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Foto { get; set; }
        public string Personaje { get; set; } = null!;
    }
}
