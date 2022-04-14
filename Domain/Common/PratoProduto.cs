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
        public Guid? PessoaID { get; set; }
        public Guid? AgendamentoID { get; set; }
        public PratoProduto(Guid? pratoID, Guid? produtoID, Guid? pessoaID, Guid? agendamentoID)
        {
            PratoID = pratoID;
            ProdutoID = produtoID;
            PessoaID = pessoaID;
            AgendamentoID = agendamentoID;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is PratoProduto)) return false;

            if ((obj as PratoProduto).PratoID.Equals(PratoID)) return true;

            return false;
        }
    }
}
