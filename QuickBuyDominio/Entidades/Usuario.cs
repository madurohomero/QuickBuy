using System.Collections.Generic;

namespace QuickBuyDominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public bool EhAdministrador { get; set; }
        
        /// <summary>
        /// Um usuário pode ter nenhum ou mais pedidos
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não foi informado");
            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não foi informada");
        }
    }
}
