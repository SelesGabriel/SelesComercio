using System.ComponentModel.DataAnnotations.Schema;

namespace SelesMiudeza.Model
{
    public class Produto
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Sobrenome")]
        public string Sobrenome { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("CPF")]
        public string CPF { get; set; }
        [Column("DataNascimento")]
        public string DataNascimento { get; set; }
        public string Imagem{ get; set; }

        [Column("IdCategoria")]
        public int IdCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
