using Domain.Financeiro;
using System.Data.SqlClient;

namespace Domain.Persistence.DAL
{
    public class CaixaDAL
    {
        private SqlConnection _sqlConnection { get; set; }
        public CaixaDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }


        #region Metodos        
        public void Inserir(Caixa caixa)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_Caixa(CaixaID, AgendamentoID, Valor)" +
                "values(@CaixaID, @agendamentoID, @valor)";
            command.Parameters.AddWithValue("@caixaID", Guid.NewGuid());
            command.Parameters.AddWithValue("@agendamentoID", caixa.AgendamentoID);
            command.Parameters.AddWithValue("@valor", caixa.Valor);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public IReadOnlyCollection<Caixa> ObterTodos(DateTime? dataInicio = null, DateTime? dataFinal = null)
        {
            List<Caixa> caixas = new List<Caixa>();

            _sqlConnection.Open();
            var command = new SqlCommand(
                "SELECT TB_CAIXA.CaixaID, TB_CAIXA.AgendamentoID, TB_CAIXA.Valor, TB_AGENDAMENTO.DataHora, TB_PESSOA.CPF " +
                "FROM TB_CAIXA " +
                "INNER JOIN TB_AGENDAMENTO ON TB_CAIXA.AgendamentoID = TB_AGENDAMENTO.AgendamentoID " +
                "INNER JOIN TB_PESSOA ON TB_AGENDAMENTO.PessoaID = TB_PESSOA.PessoaID " +
                "ORDER BY TB_AGENDAMENTO.DataHora",
                _sqlConnection);
            //command.Parameters.AddWithValue("@caixaID", caixa.CaixaID);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (dataInicio == null || dataFinal == null)
                    {
                        var caixa = new Caixa(reader.GetGuid(1), reader.GetDecimal(2), reader.GetDateTime(3), reader.GetGuid(0));
                        caixa.PessoaCPF = reader.GetString(4);
                        caixas.Add(caixa);
                    }
                    else
                    {
                        if(reader.GetDateTime(3)>dataInicio && reader.GetDateTime(3)<dataFinal)
                        {
                            var caixa = new Caixa(reader.GetGuid(1), reader.GetDecimal(2), reader.GetDateTime(3), reader.GetGuid(0));
                            caixa.PessoaCPF = reader.GetString(4);
                            caixas.Add(caixa);

                        }
                    }
                }
            }

            _sqlConnection.Close();
            return caixas.AsReadOnly();
        }


        //public IReadOnlyCollection<Pessoa> ObterTodos()
        //{
        //    List<Pessoa> pessoas = new List<Pessoa>();

        //    _sqlConnection.Open();
        //    var command = new SqlCommand("Select PessoaID, Nome from TB_Pessoa order by Nome", _sqlConnection);

        //    using (SqlDataReader reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            //Console.WriteLine(reader.GetString(1));
        //            var pessoa = new Pessoa(reader.GetString(1), pessoaID: reader.GetGuid(0));
        //            pessoas.Add(pessoa);
        //        }
        //    }

        //    _sqlConnection.Close();
        //    return pessoas.AsReadOnly();
        //}

        //public Pessoa ObterPeloID(Guid? pessoaID)
        //{
        //    Pessoa pessoa = null;

        //    var command = new SqlCommand("select PessoaID, Nome from TB_Pessoa where PessoaID = @pessoaID", _sqlConnection);
        //    command.Parameters.AddWithValue("@pessoaID", pessoaID);

        //    _sqlConnection.Open();
        //    using (SqlDataReader reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            pessoa = new Pessoa(reader.GetString(1), reader.GetGuid(0));
        //        }

        //    }
        //    _sqlConnection.Close();
        //    return pessoa;
        //}

        //public void Gravar(Pessoa pessoa)
        //{
        //    if (string.IsNullOrEmpty(pessoa.Nome))
        //        throw new Exception("Nome não pode ser em branco");
        //    if (pessoa.PessoaID == null)
        //    {
        //        Inserir(pessoa);
        //    }
        //    else
        //    {
        //        Atualizar(pessoa);
        //    }
        //}

        //public void Remover(Pessoa pessoa)
        //{

        //    var command = new SqlCommand("delete from TB_Pessoa where PessoaID = @pessoaID", _sqlConnection);
        //    command.Parameters.AddWithValue("@pessoaID", pessoa.PessoaID);


        //    _sqlConnection.Open();
        //    command.ExecuteNonQuery();
        //    _sqlConnection.Close();
        //}

        #endregion
    }
}
