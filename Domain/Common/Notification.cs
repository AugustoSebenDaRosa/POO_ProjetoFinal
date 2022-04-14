namespace Domain.Common
{
    public class Notification
    {
        public string Propriedade { get; set; }
        public string Mensagem { get; set; }

        public Notification (string propriedade, string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }

        public override string ToString()
        {
            return $"{Propriedade}: {Mensagem}";
        }
    }
}
