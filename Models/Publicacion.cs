namespace PC4.Models
{
    public class Publicacion
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Foto { get; set; }

        public int UsuarioId{get; set;}
        public Usuario Usuario{get; set;}
    }
}