using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AWSSApiExamen.Models
{
    [Table("categoriaevento")]
    public class CategoriasEvento
    {
        [Key]
        [Column("idcategoria")]
        public int IdCategoria { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }
    }
}
