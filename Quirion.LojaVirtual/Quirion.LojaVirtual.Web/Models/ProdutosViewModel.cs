using Quirion.LojaVirtual.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quirion.LojaVirtual.Web.Models
{
    public class ProdutosViewModel
    {
        //representa itens do dominio
        public IEnumerable<Produto> Produtos { get; set; }

        public Paginacao Paginacao { get; set; }


    }
}