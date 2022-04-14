using Domain.Common;

namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormCadastro());
            Application.Run(new FormPratosAdmin());
            //Application.Run(new FormLogin());
            //Application.Run(new FormMesa());
            //Application.Run(new FormAgendamento(new Cliente("Augusto Seben da Rosa", 13133017950, "123", Guid.Parse("d47ba0b0-f55e-43cc-acce-453f6d2bd928"))));
            //Application.Run(new ProdutoForm());
            //Application.Run(new FormPratos(null, new Cliente("Augusto Seben da Rosa", 13133017950, "123", Guid.Parse("d47ba0b0-f55e-43cc-acce-453f6d2bd928"))));
        }
    }
}