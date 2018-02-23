using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaVirtual.Models
{
    [Table("SubCategoria")]
    public class SubCategoria
    {
        public int SubCategoriaId { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(1200)]
        public string Descricao { get; set; }

        [MaxLength(200)]
        public string Imagem { get; set; }

        [MaxLength(200)]
        public string ImagemThumbnail { get; set; }


        public bool Ativo { get; set; }


        public bool Visivel { get; set; }

        // relacão 1:N
        public List<Categoria> Categoria { get; set; }
    }
}
