using System.ComponentModel.DataAnnotations.Schema;

namespace EstagioInicialDAEETarde.Models
{
    [Table("Scrum")]
    public class Scrum
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Definicao")]
        public string? Definicao { get; set; }
    }
}
