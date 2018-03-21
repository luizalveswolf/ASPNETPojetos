using Quirion.LojaVirtual.Dominio.Repositorio;
using Quirion.LojaVirtual.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quirion.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        private ProdutoRepositorio _repositorio;

        public int ProdutosPorPagina = 8;

        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutoRepositorio();

            ProdutosViewModel model = new ProdutosViewModel()
            {

                  Produtos = _repositorio.Produto.OrderBy(p => p.Descricao)
                  .Skip((pagina - 1) * ProdutosPorPagina)
                  .Take(ProdutosPorPagina),

                Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = _repositorio.Produto.Count()

                }

            };
           

            return View(model);
        }
    }
}