using QuickBuyDominio.Contratos;
using QuickBuyDominio.Entidades;
using QuickBuyRepositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyRepositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
            
        }
    }
}
