using LojaVirtual.Context;
using LojaVirtual.Interfaces;
using LojaVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias.Include(d => d.Departamento);

        public IEnumerable<Categoria> CategoriasAtivas => _context.Categorias.Where(a => a.Ativo).Include(d => d.Departamento) ;
        
        public IEnumerable<Categoria> CategoriasVisiveis => _context.Categorias.Where(v => v.Visivel).Include(d => d.Departamento);

        public Categoria GetCategoriaByUd(int categoriaId)
        {
            return _context.Categorias.FirstOrDefault(c => c.CategoriaId == categoriaId);
        }
    }
}
