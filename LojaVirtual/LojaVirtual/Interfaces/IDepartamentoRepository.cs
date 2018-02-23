using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Interfaces
{
    public interface IDepartamentoRepository
    {
        IEnumerable<Departamento> Departamentos { get; }
    }
}
