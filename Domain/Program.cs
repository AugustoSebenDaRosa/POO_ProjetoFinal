using Domain.Common;
using Domain.Pedidos;
using Domain.Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;

#region DAL
string connectionString = ConfigurationManager.ConnectionStrings["Teste"].ConnectionString;
PessoaDAL pessoaDAL = new PessoaDAL(new SqlConnection(connectionString));
MesaDAL mesaDAL = new MesaDAL(new SqlConnection(connectionString));
ProdutoDAL produtoDAL = new ProdutoDAL(new SqlConnection(connectionString));
PratoDAL pratoDAL = new PratoDAL(new SqlConnection(connectionString));
PratoProdutoDAL pratoProdutoDAL = new PratoProdutoDAL(new SqlConnection(connectionString));

#endregion

#region DAL Operations
//pratoProdutoDAL.Gravar(new Guid("19dbc256-0aa6-40fb-996c-186bd0a42011"), new Guid("be300cf5-4e21-42ee-8375-c3ff0c5d7836"));

//var prato = new Prato("Feijão, arroz e carne", 0);
//pratoDAL.Gravar(prato);

//var produto = new Produto("Feijão", 5);
//produtoDAL.Gravar(produto);

var mesa = new Mesa(6, 1);
mesaDAL.Inserir(mesa);

//Cliente cliente = new Cliente("Augusto", 13133017950, "TCHE", new Contato(45988199559, "snykralafk@gmail.com"));
//pessoaDAL.Inserir(cliente);
#endregion

//#region Mesa
//Prato prato01 = new Prato("Feijao Arroz Carne");
//Prato prato02 = new Prato("Feijao Arroz Peixe");

//Produto feijao = new Produto("Feijao", 5.00);
//Produto arroz = new Produto("Arroz", 5.00);
//Produto carne = new Produto("Carne", 7.00);
//Produto peixe = new Produto("Peixe", 9.00);


//prato01.RegistrarProduto(feijao);
//prato01.RegistrarProduto(arroz);
//prato01.RegistrarProduto(carne);
//Console.WriteLine(prato01.Produtos.Count());



//prato02.RegistrarProduto(feijao);
//prato02.RegistrarProduto(arroz);
//prato02.RegistrarProduto(peixe);


////prato01.RemoverProduto(feijao);


//Mesa mesa = new Mesa(8, 1);

//mesa.RegistrarPrato(prato01);
//mesa.RegistrarPrato(prato02);


//Agendamento agendamento = new Agendamento(new DateTime(27/05/2022), mesa);
//Agendamento agendamento01 = new Agendamento(new DateTime(27 / 04 / 2022), mesa);

//Cliente cliente = new Cliente("Augusto", 13133017950, "TCHE", new Contato(45988199559, "snykralafk@gmail.com"));

//cliente.RegistrarAgendamento(agendamento);

//mesa.Pagar();
//mesa.RegistrarPrato(prato01);
//mesa.Pagar();

//foreach (var conta in mesa.Contas)
//{
//    Console.WriteLine(conta.Valor);
//}

////if (mesa.IsValid)
////{
////    Console.WriteLine($"Lugares: {mesa.NumLugares}, Total: {mesa.Total}, Pratos: {mesa.Pratos.Count}");
////}
////else
////{
////    Console.WriteLine("Erros da inicialização: ");
////    for (int i = 0; i < mesa.NotificationsCount; i++)
////    {
////        Console.WriteLine($"{mesa.Notifications[i]}");
////    }
////    mesa = null;
////}
//#endregion




#region Pessoa
//Cliente cliente = new Cliente("Augusto", 13133017950, new Contato(45988199559, "snykralafk@gmail.com"));

//if (cliente.IsValid)
//{
//    Console.WriteLine($"Pessoa {cliente.Nome}, Telefone: {cliente.Contato.Telefone}");
//}
//else
//{
//    Console.WriteLine("Erros da inicialização: ");
//    for (int i = 0; i < cliente.NotificationsCount; i++)
//    {
//        Console.WriteLine($"{cliente.Notifications[i]}");
//    }
//    cliente = null;
//}

//Funcionario funcionario = new Funcionario("A", 13111111111, new Contato(45999999999, "abc@gmail.com"), 2500.00);

//if (funcionario.IsValid)
//{
//    Console.WriteLine($"Pessoa {funcionario.Nome}, Telefone: {funcionario.Contato.Telefone}");
//}
//else
//{
//    Console.WriteLine("Erros da inicialização: ");
//    for (int i = 0; i < funcionario.NotificationsCount; i++)
//    {
//        Console.WriteLine($"{funcionario.Notifications[i]}");
//    }
//    funcionario = null;
//}
#endregion
