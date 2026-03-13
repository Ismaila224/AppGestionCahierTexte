using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;

namespace AppGestionCahierTexte
{
    public static class LogClasse
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        public static void Configure()
        {
            var services = new ServiceCollection();

            services.AddLogging(builder =>
            {
                builder.AddEventLog(config =>
                {
                    config.SourceName = "AppGestionCahierTexte";
                });
            });

            ServiceProvider = services.BuildServiceProvider();

        }
        static string chemin = "C:\\Users\\USER\\source\\repos\\AppGestionCahierTexte\\Logs\\Logs.txt";
        static string cheminE = "C:\\Users\\USER\\source\\repos\\AppGestionCahierTexte\\Logs\\ErreurLog.txt";
        static string cheminW = "C:\\Users\\USER\\source\\repos\\AppGestionCahierTexte\\Logs\\Warning.txt";
        public static void Info(string titre, string message)
        {
            Ecrire("INFO", titre, message, chemin);
        }

        public static void Error(string titre, string message)
        {
            Ecrire("ERROR", titre, message, chemin);
            Ecrire("ERROR", titre, message, cheminE);
        }

        public static void Warning(string titre, string message)
        {

            Ecrire("WARNING", titre, message, chemin);
            Ecrire("WARNING", titre, message, cheminW);
        }

        private static void Ecrire(string type, string titre, string message, string chemin)
        {
            string log = $"{DateTime.Now} [{type}] {titre} : {message}";
            File.AppendAllText(chemin, log + Environment.NewLine);
        }

    }
}