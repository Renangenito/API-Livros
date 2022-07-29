using System.ComponentModel.DataAnnotations;

namespace APICodeFirstLivros.Context
{
    public class Livro
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 5, ErrorMessage = "Este campo deve ter no mínimo 5 e no máximo 100 caracteres!")]
        public string Titulo { get; set; }

        [StringLength(100)]
        public string Genero { get; set; }
        public decimal Preco { get; set; }

        [StringLength(100, MinimumLength = 5, ErrorMessage = "Este campo deve ter no mínimo 5 e no máximo 100 caracteres!")]
        public string Autor { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }


    }
}
