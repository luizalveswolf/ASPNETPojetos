using Quirion.LojaVirtual.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quirion.LojaVirtual.Dominio.Repositorio
{
    public class ProdutoRepositorio
    {
        private readonly EFDBContext _context = new EFDBContext();

        public IEnumerable<Produto> Produto
        {
            get { return _context.Produtos; }
        }

        
    }
}
