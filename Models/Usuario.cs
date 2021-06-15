using System.ComponentModel.DataAnnotations;

namespace PC4.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string UsuarioId { get; set; }
        [Required]
        public string Contraseña { get; set; }
        [Required]
        public string Nick{get; set;}
        public string Foto{get; set;}

    }
}