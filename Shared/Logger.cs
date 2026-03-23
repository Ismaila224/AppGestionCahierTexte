using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace AppGestionCahierTexte.Shared
{
    static class Logger
    {
		static string chemin = "C:\\Users\\ACER\\Downloads\\repos\\AppGestionCahierTexteV2\\Logs\\Logs.txt";
		public static void Info(string titre, string message)
		{
			Ecrire("INFO",titre, message);
		}

		public static void Error(string titre, string message)
		{
			Ecrire("ERROR",titre, message);
		}

		public static void Warning(string titre, string message)
		{
			
			Ecrire("WARNING",titre, message);
		}

		private static void Ecrire(string type,string titre, string message)
		{
			string log = $"{DateTime.Now} [{type}] {titre} : {message}";
			File.AppendAllText(chemin, log + Environment.NewLine);
		}

	}
}
