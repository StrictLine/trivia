using System;

namespace Trivia
{
    public class GameRunner
    {
        private static bool _notAWinner;

        public static void Main(string[] args)
        {
            var aGame = new Game();
            string[] players = new[] 
            {
                "Chet",
                "Pat",
                "Sue"
            };

            aGame.Add("Chet");
            aGame.Add("Pat");
            aGame.Add("Sue");
            var aGame = new Game();

            var rand = new Random();
            foreach (var playerName in players)
                aGame.Add(playerName);

            do
            {
                aGame.Roll(rand.Next(5) + 1);
                aGame.Roll(diceSize: 6);

                if (rand.Next(9) == 7)
                {
                    _notAWinner = aGame.WrongAnswer();
                }
                else
                {
                    _notAWinner = aGame.WasCorrectlyAnswered();
                }
            } while (_notAWinner);
        }
    }
}