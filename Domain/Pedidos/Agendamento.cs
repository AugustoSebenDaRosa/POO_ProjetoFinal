using Domain.Common;

namespace Domain.Pedidos
{
    public class Agendamento
    {
        #region Notification
        const int MAX_NOTIFICATIONS = 10;

        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount;

        public int NotificationsCount { get { return _notificationsCount; } }
        public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        public bool IsValid { get { return _notificationsCount == 0; } }
        #endregion



        #region Variaveis
        public Guid? AgendamentoID { get; set; }
        public DateTime DataHora { get; set; }
        public int? MesaNum { get; set; }
        public Guid? PessoaID { get; set; }
        public decimal Valor { get; set; }

        #endregion


        #region Constructor
        public Agendamento(DateTime dataHora, int? mesaNum, Guid? pessoaID = null, Guid? agendamentoID = null)
        {
            DataHora = dataHora;
            MesaNum = mesaNum;
            PessoaID = pessoaID;
            AgendamentoID = agendamentoID;
            applyValidations();
        }
        #endregion

        #region Validations
        public void applyValidations()
        {
            if (DataHora < DateTime.Now)
                addNotification(new Notification("AGENDAMENTO", "Não pode ser feito no passado"));
        }

        public void addNotification(Notification notification)
        {
            if (_notificationsCount == MAX_NOTIFICATIONS) throw new Exception("Limite de notificações excedido");
            _notifications[_notificationsCount++] = notification;
        }
        #endregion
    }
}
