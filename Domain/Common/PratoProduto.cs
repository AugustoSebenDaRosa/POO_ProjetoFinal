using Domain.Pedidos;

namespace Domain.Common
{
    public class PratoProduto
    {
        public Guid? PratoID { get; set; }
        public Guid? ProdutoID { get; set; }
        public string PratoNome { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Produto Produto { get; set; }
        public Prato Prato { get; set; }
        public PratoProduto(Guid? pratoID, Guid? produtoID)
        {
            PratoID = pratoID;
            ProdutoID = produtoID;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is PratoProduto)) return false;

            if ((obj as PratoProduto).PratoID.Equals(PratoID)) return true;

            return false;
        }
    }
}
