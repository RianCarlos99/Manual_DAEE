using System.ComponentModel.DataAnnotations.Schema;

namespace EstagioInicialDAEETarde.Models
{
    [Table("Mvc")]
    public class Mvc
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Letra")]
        public string? Letra { get; set; }
        [Column("Cor")]
        public string? Cor { get; set; }
        [Column("Descricao")]
        public string? Descricao { get; set; }
    }
}
