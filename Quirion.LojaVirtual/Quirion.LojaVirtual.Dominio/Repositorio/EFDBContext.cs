using Quirion.LojaVirtual.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quirion.LojaVirtual.Dominio.Repositorio
{
    public class EFDBContext: DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

    }



}
