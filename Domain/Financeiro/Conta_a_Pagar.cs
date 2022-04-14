using Domain.Common;

namespace Domain.Financeiro
{
    public class Conta_a_Pagar
    {

        #region Notification
        const int MAX_NOTIFICATIONS = 10;

        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount;

        public int NotificationsCount { get { return _notificationsCount; } }
        public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        public bool IsValid { get { return _notificationsCount == 0; } }
        #endregion


        public Guid? ContaPagarID { get; set; }
        public double Valor_a_Pagar { get; set; }
        public double ValorInicial { get; private set; }



        public Conta_a_Pagar(double valor, Guid? contaPagarID = null)
        {
            Valor_a_Pagar = valor;
            ValorInicial = valor;
            ContaPagarID = (contaPagarID != null) ? contaPagarID : Guid.NewGuid();
            applyValidations();
        }



        #region Metodos
        public void ChangeValor(double valor)
        {
            Valor_a_Pagar = valor;
            applyValidations();
        }

        public void Pagar()
        {
            Valor_a_Pagar = 0;
        }
        #endregion




        #region Validations
        public void applyValidations()
        {
            if (ValorInicial < 0)
                addNotification(new Notification("VALOR", "Não pode ser negativo"));
            if (Valor_a_Pagar < 0)
                addNotification(new Notification("VALOR A PAGAR", "Não pode ser negativo"));


        }

        public void addNotification(Notification notification)
        {
            if (_notificationsCount == MAX_NOTIFICATIONS) throw new Exception("Limite de notificações excedido");
            _notifications[_notificationsCount++] = notification;
        }
        #endregion
    }
}
