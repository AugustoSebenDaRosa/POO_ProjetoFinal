namespace Domain.Common
{
    public class Contato
    {
        #region Variaveis
        public Guid? ContatoID { get; set; }
        public Guid? PessoaID { get; set; }
        public long Telefone { get; private set; }
        public string Email { get; private set; }
        #endregion

        #region Constructor
        public Contato(long telefone, string email, Guid? pessoaID = null, Guid? contatoID = null)
        {
            Telefone = telefone;
            Email = email;
            PessoaID = pessoaID;
            ContatoID = contatoID;
        }
        #endregion

        #region Metodos
        public void ChangeEmail(string email)
        {
            Email = email;
        }

        public string ObterEmail()
        { 
            return Email;
        }

        public void ChangeTelefone(long telefone)
        {
            Telefone = telefone;
        }

        public long ObterTelefone()
        {
            return Telefone;
        }
        #endregion
    }
}
