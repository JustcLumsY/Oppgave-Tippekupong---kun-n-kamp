using System;

namespace Oppgave_Tippekupong___kun_én_kamp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var kamp = new Match();

            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            var bet = Console.ReadLine();
         
            while (kamp.matchIsRunning)
            {
                kamp.PrintMatch();
            }

          kamp.getScoreText(bet);
        }

   
    }
}
