using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class SubCategoria
    {
        public int SubCategoriaId { get; set; }


        public string Nome { get; set; }


        public string Descricao { get; set; }


        public string Imagem { get; set; }


        public string ImagemThumbnail { get; set; }


        public bool Ativo { get; set; }


        public bool Visivel { get; set; }

        // relacão 1:N
        public List<Categoria> Categoria { get; set; }
    }
}
