using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_S1_L4.Exceptions
{
    //:Exception--> eredita tutte le funzionalità (e i comportamenti) dalla classe base di C# chiamata Exception.
    public class LoginException : Exception
    {
        //costruttore per poter chiamare throw new LoginException 
        public LoginException() { }
        //costruttore con messaggio
        //public LoginException(string message)--> mi permette di dire che il mio messaggio sarà una stringa
        //base(message) { } --> base si collega alla classe madre (Exception) e gli dice di modificare/leggere il messaggio che ha ricevuto,
        //che gli è stato passato
        public LoginException(string message) : base(message) { }



    }
}
