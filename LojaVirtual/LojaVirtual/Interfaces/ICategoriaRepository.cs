using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
        IEnumerable<Categoria> CategoriasAtivas { get; }
        IEnumerable<Categoria> CategoriasVisiveis { get; }
        Categoria GetCategoriaByUd(int CategoriaId);

    }
}
