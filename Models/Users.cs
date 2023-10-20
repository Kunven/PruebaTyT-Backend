namespace PruebaTyT_Backend.Models
{
    public class Users
    {
        public int id { get; set; }
        public string? usuario { get; set; }
        public string? email { get; set; }
        public string? primerNombre { get; set; }
        public string? segundoNombre { get; set; }
        public string? primerApellido { get; set; }
        public string? segundoApellido { get; set; }
        public int idDepartamento { get; set; }
        public int idCargo { get; set; }
    }
}
