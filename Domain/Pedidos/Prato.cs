using Domain.Common;

namespace Domain.Pedidos
{
    public class Prato
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
        public Guid? PratoID { get; set; }
        public string Nome { get; set; }

        public double SubTotal = 0;
        public int? MesaNum { get; set; }
        public Guid? AgendamentoID { get; set; }
        #endregion


        #region Constructor
        public Prato(string? nome = null, int? mesaNum = null, Guid? pratoID = null, Guid? agendamentoID = null)
        {
            Nome = nome;
            PratoID = pratoID;
            MesaNum = mesaNum;
            AgendamentoID= agendamentoID;
        }
        #endregion

        #region Métodos
        //public void RegistrarProduto(Produto produto)
        //{
        //    if (produto.IsValid)
        //    {
        //        Produtos.Add(produto);
        //        SubTotal += produto.PrecoUnitario;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Erros da inicialização: ");
        //        for (int i = 0; i < produto.NotificationsCount; i++)
        //        {
        //            Console.WriteLine($"{produto.Notifications[i]}");
        //        }
        //        produto = null;
        //    }
        //    applyValidations();
        //}

        //public void RemoverProduto(Produto produto)
        //{
        //    SubTotal -= produto.PrecoUnitario;
        //    Produtos.Remove(produto);
        //}

        //public Produto ObterProdutoPeloNome(string nome)
        //{
        //    return Produtos.Where(i => i.Nome.ToLower().Equals(nome.ToLower())).FirstOrDefault();
        //}
        #endregion

        #region Override
        public override bool Equals(object? obj)
        {
            if (!(obj is Prato)) return false;
            if ((obj as Prato).PratoID.Equals(PratoID)) return true;
            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (PratoID == null ? 1 : PratoID.GetHashCode());
        }
        #endregion

        #region Validations
        //public void applyValidations()
        //{
        //    if (Nome == null || Nome.Trim().Length == 0)
        //        addNotification(new Notification("NOME DO PRATO", "Não pode ser nulo ou vazio."));


        //    //if (Produtos.Count()>6)
        //    //    addNotification(new Notification("QUANTIDADE DE PRODUTOS", "Não pode exceder 6."));
        //}

        //public void addNotification(Notification notification)
        //{
        //    if (_notificationsCount == MAX_NOTIFICATIONS) throw new Exception("Limite de notificações excedido");
        //    _notifications[_notificationsCount++] = notification;
        //}
        #endregion
    }
}
