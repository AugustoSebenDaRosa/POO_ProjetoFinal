namespace Domain.Financeiro
{
    public class Caixa
    {
        public HashSet<Conta_a_Receber> ContasReceber { get; set; }
        public HashSet<Conta_a_Pagar> ContasPagar { get; set;}
        public double Total { get; set; }


    }
}
