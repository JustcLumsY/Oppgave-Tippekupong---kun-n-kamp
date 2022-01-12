using System;

namespace Oppgave_Tippekupong___kun_én_kamp
{
    public class Match
    {
        public int homeGoals = 0;
        public int awayGoals = 0;
        public bool matchIsRunning = true;



        public void getScoreText(string bet)
        {
            var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";
            var isBetCorrect = bet.Contains(result);
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }

        public void PrintMatch()
        {
            Console.Write(
                "Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
            var command = Console.ReadLine();
            matchIsRunning = command != "X";
            if (command == "H") homeGoals++;
            else if (command == "B") awayGoals++;
            Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
        }
    }
}