using LojaVirtual.Context;
using LojaVirtual.Interfaces;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private readonly AppDbContext _context;

        public DepartamentoRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Departamento> Departamentos => _context.Departamentos;
    }
}
