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
        static string chemin = "C:\\Users\\Lenovo\\source\\repos\\Ismaila224\\AppGestionCahierTexte\\Logs\\Logs.txt";
            public static void Info(string titre, string message)
            {
                Ecrire("INFO", titre, message);
            }

            public static void Error(string titre, string message)
            {
                Ecrire("ERROR", titre, message);
            }

            public static void Warning(string titre, string message)
            {

                Ecrire("WARNING", titre, message);
            }

            private static void Ecrire(string type, string titre, string message)
            {
                string log = $"{DateTime.Now} [{type}] {titre} : {message}";
                File.AppendAllText(chemin, log + Environment.NewLine);
            }

    }
}
