using System.Configuration;
using System.Data.Common;
using System.Globalization;

namespace Pizzaria_Do_Ze.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);

            #region IDIOMA/REGI�O

            string? auxIdiomaRegiao = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";
            //ajusta o idioma/regi�o
            //o ! afirma que o valor j� foi tratado e n�o ser� nulo aqui
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);

            #endregion

            ApplicationConfiguration.Initialize();
            Application.Run(new TelaPrincipal());
        }
    }
}