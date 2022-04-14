using Domain.Pedidos;
using System.Data.SqlClient;

namespace Domain.Persistence.DAL
{
    public class AgendamentoDAL
    {

        private SqlConnection _sqlConnection { get; set; }
        public AgendamentoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }


        #region Metodos        
        public void Inserir(Agendamento agendamento)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_AGENDAMENTO(AgendamentoID, PessoaID, MesaNum, DataHora)" +
                "values(@agendamentoID, @pessoaID, @mesaNum, @dataHora)";
            command.Parameters.AddWithValue("@agendamentoID", agendamento.AgendamentoID);
            command.Parameters.AddWithValue("@pessoaID", agendamento.PessoaID);
            command.Parameters.AddWithValue("@mesaNum", agendamento.MesaNum);
            command.Parameters.AddWithValue("@dataHora", agendamento.DataHora);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void Gravar(Agendamento agendamento)
        {
            if (agendamento.DataHora < DateTime.Now)
                throw new Exception("Agendamento não pode ser feito no passado!");
            IReadOnlyCollection<Agendamento> listAgendamentos = ObterTodos(agendamento.MesaNum);
            DateTime aux;
            foreach(var agend in listAgendamentos)
            {
                aux = agend.DataHora.AddMinutes(40);
                if ((agendamento.DataHora < aux && agendamento.DataHora > agend.DataHora))
                    throw new Exception("O tempo entre o agendamento de outro cliente e o seu deve ser de 40 minutos.");
            }


            Inserir(agendamento);
        }

        public IReadOnlyCollection<Agendamento> ObterTodos(int? mesaNum = null)
        {
            List<Agendamento> agendamentos = new List<Agendamento>();

            _sqlConnection.Open();
            var command = new SqlCommand(
                "SELECT PessoaID, MesaNum, DataHora FROM TB_AGENDAMENTO " +
                "WHERE MesaNum = @mesaNum " +
                "ORDER BY MesaNum",
                _sqlConnection);
            command.Parameters.AddWithValue("@mesaNum", (mesaNum == null) ? 1 : mesaNum);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var agendamento = new Agendamento(reader.GetDateTime(2), reader.GetInt32(1), reader.GetGuid(0));
                    agendamentos.Add(agendamento);
                }
            }

            _sqlConnection.Close();
            return agendamentos.AsReadOnly();
        }

        public void DeletarTodos()
        {
            _sqlConnection.Open();
            var command = new SqlCommand(
                "TRUNCATE TABLE TB_AGENDAMENTO",
                _sqlConnection);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        #endregion
    }
}
