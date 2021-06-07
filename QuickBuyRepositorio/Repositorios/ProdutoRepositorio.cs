using QuickBuyDominio.Contratos;
using QuickBuyDominio.Entidades;
using QuickBuyRepositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyRepositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {

        }
    }
}
