using Common;

namespace ProjetoFinal
{
    public class Aluno
    {
        #region Constants
        const int MAX_NOTIFICATIONS = 10;
        #endregion

        #region Private
        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount;
        #endregion

        #region public
        public string Nome { get; set; }


        public int NotificationsCount { get { return _notificationsCount; } }

        public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }

        public bool IsValid { get { return _notificationsCount == 0; } }


        #endregion




        public Aluno(string nome)
        {
            Nome = nome;
            applyValidations();
        }

        public void ChangeName(string nome)
        {
            Nome = nome;
            applyValidations();
        }

        private void applyValidations()
        {
            if (Nome == null || Nome.Trim().Length == 0)
                addNotification(new Notification("NOME", "Não pode ser nulo ou vazio"));

            //if (DatadeNascimento == null)
            //addNotification(new Notification("NASCIMENTO", "Não pode ser nulo"));

            //if (_notificationsCount > 0)
            //    throw new Exception("Erro(s) na violação de dados");

        }

        private void addNotification(Notification notification)
        {
            if (_notificationsCount == MAX_NOTIFICATIONS) throw new Exception("Limite de notificações excedido");
            _notifications[_notificationsCount++] = notification;
        }
    }
}
