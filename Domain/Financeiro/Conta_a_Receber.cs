using Domain.Common;

namespace Domain.Financeiro
{
    public class Conta_a_Receber
    {

        #region Notification
        const int MAX_NOTIFICATIONS = 10;

        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount;

        public int NotificationsCount { get { return _notificationsCount; } }
        public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        public bool IsValid { get { return _notificationsCount == 0; } }
        #endregion


        public Guid? ContaReceberID { get; set; }
        public double Valor { get; set; }
        public int? NumMesa { get; set; }



        public Conta_a_Receber(double valor, int? numMesa, Guid? contaReceberID = null)
        {
            Valor = valor;
            NumMesa = numMesa;
            ContaReceberID = (contaReceberID != null) ? contaReceberID : Guid.NewGuid();
            applyValidations();
        }




        #region Validations
        private void applyValidations()
        {
            if (Valor < 2)
                addNotification(new Notification("VALOR", "Não pode ser negativo"));


        }

        private void addNotification(Notification notification)
        {
            if (_notificationsCount == MAX_NOTIFICATIONS) throw new Exception("Limite de notificações excedido");
            _notifications[_notificationsCount++] = notification;
        }
        #endregion
    }
}
