namespace Common
{
    public class Notification
    {
        public string Propriedade { get; set; }
        public string Mensagem { get; set; }

        public Notification(string propriedade, string msg)
        {
            Propriedade = propriedade;
            Mensagem = msg;
        }

        public override string ToString()
        {
            return $"{Propriedade} => {Mensagem}";
        }
    }
}
