using Domain.Pedidos;

namespace Domain.Common
{
    public class Cliente : Pessoa
    {
        #region Variaveis
        #endregion

        #region Constructor
        public Cliente(string nome, long cpf, string senha, Guid? pessoaID = null) : base()
        {
            Nome = nome;
            CPF = cpf;
            Senha = senha;
            PessoaID = pessoaID;
            //base.applyValidations();
        }
        #endregion

    }
}
