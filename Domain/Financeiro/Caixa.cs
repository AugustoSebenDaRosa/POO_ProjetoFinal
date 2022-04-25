namespace Domain.Financeiro
{
    public class Caixa
    {
        public Guid? CaixaID { get; set; }
        public Guid? AgendamentoID { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string PessoaCPF { get; set; }

        public Caixa(Guid? agendamentoID, decimal valor, DateTime dataAgendamento, Guid? caixaID=null)
        {
            CaixaID=caixaID;
            AgendamentoID=agendamentoID;
            Valor=valor;
            DataAgendamento=dataAgendamento;
        }
    }
}
