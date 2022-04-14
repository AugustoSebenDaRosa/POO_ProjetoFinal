using Domain.Financeiro;

namespace Domain.Common
{
    public class Funcionario : Pessoa
    {
        #region Notification
        const int MAX_NOTIFICATIONS = 10;

        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount;

        public int NotificationsCount { get { return _notificationsCount; } }
        public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        public bool IsValid { get { return _notificationsCount == 0; } }

        public Conta_a_Pagar Conta { get; set; }
        #endregion



        public double Salario { private get; set; }
        public Conta_a_Pagar Contas { get; set; }

        #region Constructor
        public Funcionario(string nome, long cpf, double salario, Guid? pessoaID) : base()
        {
            Salario = salario;
            CPF = cpf;
            Nome = nome;
            PessoaID = (pessoaID != null) ? pessoaID : Guid.NewGuid();
            Contas = new Conta_a_Pagar(Salario);
            //base.applyValidations();
            applyValidations();
        }

        #endregion

        #region Metodos
        public void ChangeSalario(double salario)
        {
            Salario = salario;
            applyValidations();
        }

        public double GetSalario()
        {
            return Salario;
        }
        #endregion

        #region Validations
        private void applyValidations()
        {
            if (Salario < 1000 || Salario > 5000)
                addNotification(new Notification("SALARIO", "Salario não pode ser menor que 1000, nem maior que 5000"));

        }

        private void addNotification(Notification notification)
        {
            if (_notificationsCount == MAX_NOTIFICATIONS) throw new Exception("Limite de notificações excedido");
            _notifications[_notificationsCount++] = notification;
        }
        #endregion
    }
}
