using Domain.Common;
using Domain.Financeiro;

namespace Domain.Pedidos
{
    public class Mesa
    {

        //#region Notification
        //const int MAX_NOTIFICATIONS = 10;

        //private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        //private int _notificationsCount;

        //public int NotificationsCount { get { return _notificationsCount; } }
        //public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        //public bool IsValid { get { return _notificationsCount == 0; } }
        //#endregion

        #region Private
        private int _numContas = 0;
        #endregion

        #region Public
        public int? Numero { get; set; }
        public double Total = 0;
        public int NumLugares { get; set; }
        #endregion

        #region Constructor
        public Mesa(int lugares, int? numero = null)
        {
            Numero = numero;
            NumLugares = lugares;
            //applyValidations();
        }
        #endregion

        //public void RegistrarPrato(Prato prato)
        //{

        //    if (prato.IsValid)
        //    {
        //        Pratos.Add(prato);
        //        Total += prato.SubTotal;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Erros da inicialização: ");
        //        for (int i = 0; i < prato.NotificationsCount; i++)
        //        {
        //            Console.WriteLine($"{prato.Notifications[i]}");
        //        }
        //        prato = null;
        //    }
        //    applyValidations();
        //}

        public void MudarNumLugares(int lugares)
        {
            NumLugares = lugares;
            //applyValidations();
        }

        //public Prato ObterPratoPeloNome(string nome)
        //{
        //    return Pratos.Where(i => i.Nome.ToLower().Equals(nome.ToLower())).FirstOrDefault();
        //}

        public double ObterTotal()
        {
            return Total;
        }

        //public void RemoverPrato(Prato prato)
        //{
        //    Total -= prato.SubTotal;
        //    Pratos.Remove(prato);
        //}


        //public void Pagar()
        //{
        //    Contas.Add(new Conta_a_Receber(Total, Numero));
        //    Total = 0;

        //    Pratos.Clear();
        //}
        //#endregion

        public override bool Equals(object? obj)
        {
            if (!(obj is Mesa)) return false;

            if ((obj as Mesa).Numero.Equals(Numero)) return true;

            return false;
        }

        #region Validations
        //public void applyValidations()
        //{
        //    if (Numero>30 || Numero<0)
        //        addNotification(new Notification("NUMERO", "Numero de mesas excedido (30) ou numero fornecido é negativo."));
            
        //   if(NumLugares<2 || NumLugares>6)
        //        addNotification(new Notification("LUGARES", "Numero de lugares nulo, negativo ou excedido (2 a 6 mesas)."));


        //}

        //public void addNotification(Notification notification)
        //{
        //    if (_notificationsCount == MAX_NOTIFICATIONS) throw new Exception("Limite de notificações excedido");
        //    _notifications[_notificationsCount++] = notification;
        //}
        #endregion

    }
}
