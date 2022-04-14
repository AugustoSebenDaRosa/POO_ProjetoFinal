
namespace Domain.Common
{
    public abstract class Pessoa
    {
        //#region Notification
        //const int MAX_NOTIFICATIONS = 10;
        //private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        //private int _notificationsCount;
        //public int NotificationsCount { get { return _notificationsCount; } }
        //public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        //public bool IsValid { get { return _notificationsCount == 0; } }
        //#endregion

        #region Public
        public Guid? PessoaID { get; set; }
        public string Nome { get; set; }
        public Contato Contato { get; set; }
        public string Senha { get; set; }
        public long CPF { get; set; }
        #endregion



        #region Metodos
        //public void ChangeName(string nome)
        //{
        //    Nome = nome;
        //    applyValidations();
        //}

        //public void ChangeContato(Contato Contato)
        //{ 
        //    Contato = Contato;
        //    applyValidations();        
        //}

        //public void ChangeCPF(long cpf)
        //{
        //    CPF = cpf;
        //    applyValidations();
        //}

        public string ObterNome()
        {
            return Nome;
        }
        public long ObterCPF()
        {
            return CPF;
        }

        //public Contato ObterContato()
        //{
        //    return Contato;
        //}
        #endregion


        public override bool Equals(object? obj)
        {
            if (!(obj is Pessoa)) return false;

            if ((obj as Pessoa).PessoaID.Equals(PessoaID)) return true;

            return false;
        }


        #region Validations
        //protected void applyValidations()
        //{
        //    if (Nome == null || Nome.Trim().Length == 0)
        //        addNotification(new Notification("NOME", "Não pode ser nulo ou vazio"));

        //    //if (Contato == null)
        //    //    addNotification(new Notification("CONTATO", "Não pode ser nulo"));

        //    if (CPF == null)
        //        addNotification(new Notification("CPF", "Não pode ser nulo."));

        //    if(!(CPF == null) && CPF.ToString().Length < 11)
        //        addNotification(new Notification("CPF", "Faltam digitos no CPF"));

        //    if (Senha == null || Senha.Trim().Length == 0 || Senha.Trim().Length>30)
        //        addNotification(new Notification("SENHA", "Não pode ser nula, vazia ou com mais de 30 caracteres."));

        //}

        //private void addNotification(Notification notification)
        //{
        //    if (_notificationsCount == MAX_NOTIFICATIONS) throw new Exception("Limite de notificações excedido");
        //    _notifications[_notificationsCount++] = notification;
        //}
        #endregion
    }
}
