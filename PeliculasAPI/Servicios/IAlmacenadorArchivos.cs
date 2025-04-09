namespace PeliculasAPI.Servicios
{
    public interface IAlmacenadorArchivos
    {
        Task<string> Almacenar(string contenedor, IFormFile archivo);
        Task Borrar(string? ruta, string contenedor);
        async Task<string> Editar(string? ruta, string contendor, IFormFile archivo)
        {
            await Borrar(ruta, contendor);
            return await Almacenar(contendor, archivo);
        }
    }
}
