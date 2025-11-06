using BackEnd_S1_L4.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_S1_L4
{
    public static class Utente
    {
        private static string _UserName { get; } = "Rebecca"; //creo la mia proprietà privata (solo get)
        private static string _Password { get; } = "Rebecca98"; //creo la mia proprietà privata (solo get)

        public static DateTime? DataOraLogin { get; set; }

        public static List<DateTime?> ListaDataOra = new List<DateTime?>();

        //potrei anche scriverlo private static bool _IsLoggedIn perchè il false è implicito
        private static bool _LoginEffettuato = false; //potrei anche scriverlo private static bool _IsLoggedIn perchè il false è implicito



        //metodi
        public static void Login()
        {
            if (_LoginEffettuato)
            {
                throw new LoginException("Login già effettuato");
            }

            Console.WriteLine("Inserisci il tuo username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Inserisci la tua password");
            string password = Console.ReadLine();

            //se le credenziali non sono uguali mi dai il messaggio "credenziali non valide"
            if (_UserName != userName || _Password != password)
            {
                throw new Exception("Credenziali non valide");
            }

            DataOraLogin = DateTime.Now;

            ListaDataOra.Add(DataOraLogin);

            _LoginEffettuato = true;
            Console.WriteLine("Login effettuato con successo!");

        }

        public static void Logout()
        {
            if (!_LoginEffettuato)
            {
                throw new LoginException("Non sei loggato");
            }
            _LoginEffettuato = false;
            DataOraLogin = null;
            Console.WriteLine("Logout effettuato");
        }

        public static void OraData()
        {
            if (!_LoginEffettuato)
            {
                throw new LoginException("Non è possibile vedere la data e l'ora, devi loggarti!");

            }
            _LoginEffettuato = true;
            DataOraLogin = DateTime.Now;
            Console.WriteLine($"Data e ora di accesso: {DataOraLogin}");
        }

        public static void ListaAccessi()
        {
            if (!_LoginEffettuato)
            {
                throw new LoginException("Non è possibile vedere la data e l'ora, devi loggarti!");

            }
            Console.WriteLine("""
                Lista accessi:

                """);

            foreach (var accesso in ListaDataOra)
            {
                Console.WriteLine(accesso);
            }

        }

        public static void Esci()
        {
            Console.WriteLine("Sessione terminata");
            Environment.Exit(0);
        }
    }
}

