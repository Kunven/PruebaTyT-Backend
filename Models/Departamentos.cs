namespace PruebaTyT_Backend.Models
{
    public class Departamentos
    {
        public int id { get; set; }
        public string? codigo { get; set; }
        public string? nombre { get; set; }
        public bool activo { get; set; }
        public int idUsuario { get; set; }

    }
}
