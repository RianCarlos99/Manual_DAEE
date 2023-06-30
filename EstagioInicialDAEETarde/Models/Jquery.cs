using System.ComponentModel.DataAnnotations.Schema;

namespace EstagioInicialDAEETarde.Models
{
    [Table("Jquery")]
    public class Jquery
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Titulo")]
        public string? Titulo { get; set; }
        [Column("Conteudo")]
        public string? Conteudo { get; set; }

    }
}
