using BackEnd_S1_L4;
using BackEnd_S1_L4.Exceptions;
using System;
using System.ComponentModel;
using System.Security;

//lista è la mia etichetta che andrò a richiamare tramite goto lista 
lista:

Console.WriteLine("scegli un'opzione:");
Console.WriteLine("""
    1: Login
    2: Logout
    3: Verifica ora e data di login
    4: Lista degli accessi
    5: Esci
    """);

//numero intero scelta (variabile)= int.Parse converte la stringa in numero e Console.ReadLine restituisce il valore dato
int scelta = int.Parse(Console.ReadLine());

switch (scelta)
{
    case 1:
        try
        {
            Utente.Login();
        }
        catch (LoginException ex) //messaggio che ho scritto io nel metodo login
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex) //messaggio di default Exception
        {
            Console.WriteLine(ex.Message);
        }
        break;
    case 2:
        try
        {
            Utente.Logout();
        }
        catch (LoginException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;
    case 3:
        try
        {
            Utente.OraData();
        }
        catch (LoginException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;
    case 4:
        try
        {
            Utente.ListaAccessi();
        }
        catch (LoginException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;
    case 5:
        try
        {
            Utente.Esci();

        }
        catch(SecurityException ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;

}

goto lista;