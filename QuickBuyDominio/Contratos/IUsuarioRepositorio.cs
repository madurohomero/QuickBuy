using QuickBuyDominio.Entidades;

namespace QuickBuyDominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario Obter(string email, string senha);

        Usuario Obter(string email);
    }
}
