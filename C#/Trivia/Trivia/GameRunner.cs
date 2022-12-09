using System;

namespace Trivia
{
    public class GameRunner
    {
        private static bool _notAWinner;

        public static void Main(string[] args)
        {
            string[] players = new[] 
            {
                "Chet",
                "Pat",
                "Sue"
            };

            var aGame = new Game();

            foreach (var playerName in players)
                aGame.Add(playerName);

            do
            {
                aGame.Roll(diceSize: 6);

                if (aGame.HasWon())
                    _notAWinner = aGame.WrongAnswer();
                else
                    _notAWinner = aGame.WasCorrectlyAnswered();
            } while (_notAWinner);
        }
    }
}