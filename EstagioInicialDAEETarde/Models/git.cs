using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace EstagioInicialDAEETarde.Models
{
    
    [Table("gitContent")]
    public class Git
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public string Id { get; set; }
        
        [Column("Titulo")]
        public string? Titulo { get; set; }

        [StringLength(420)]
        [Column("Descricao")]
        public string? Descricao { get; set; }

    }

}
