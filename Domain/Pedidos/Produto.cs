using Domain.Common;

namespace Domain.Pedidos
{
    public class Produto
    {
        //#region Notification
        //const int MAX_NOTIFICATIONS = 10;

        //private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        //private int _notificationsCount;

        //public int NotificationsCount { get { return _notificationsCount; } }
        //public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        //public bool IsValid { get { return _notificationsCount == 0; } }
        //#endregion




        public Guid? ProdutoID { get; set; }
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        
        public Produto(string nome, decimal precoUnitario, Guid? produtoID = null)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            ProdutoID = produtoID;
            //applyValidations();
        }

        public void ChangePreco(decimal preco)
        {
            PrecoUnitario = preco;
            //applyValidations();
        }



        #region Override
        public override bool Equals(object? obj)
        {
            if (!(obj is Produto)) return false;
            if ((obj as Produto).ProdutoID.Equals(ProdutoID)) return true;
            return false;
        }

        public override int GetHashCode()
        {
            return 11 * (ProdutoID == null ? 1 : ProdutoID.GetHashCode());
        }
        #endregion


        #region Validations
        //public void applyValidations()
        //{
        //    if (PrecoUnitario > 50 || PrecoUnitario <2)
        //        addNotification(new Notification("PREÇO UNITÁRIO", "Não pode ser menor que R$2,00 ou maior que R$50,00."));

        //    if (Nome == null || Nome.Trim().Length == 0)
        //        addNotification(new Notification("NOME", "Não pode ser nulo ou vazio"));


        //}

        //public void addNotification(Notification notification)
        //{
        //    if (_notificationsCount == MAX_NOTIFICATIONS) throw new Exception("Limite de notificações excedido");
        //    _notifications[_notificationsCount++] = notification;
        //}
        #endregion
    }
}
