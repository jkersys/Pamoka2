using TowerOfHanoi.Models;

namespace Tests
{
    public class GameTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldPrintMenu()
        {
            var game = new Game(3, 5);

            for (int i = 0; i < game.TowerHeight; i++)
            {
                
                for (int j = 0; j < game.TowersCount; j++)
                {
                    var currentTower = game.Towers[j];

                    if (currentTower.Dics.Count > i)
                    {
                        Console.Write(currentTower.Dics[i].ToString()
                            .PadLeft(currentTower.Height + 5 + i, ' ')
                            .PadRight(2 * currentTower.Height + 10 + (i *2), ' '));
        }
                    else{
                        Console.Write("|");
                    }
                    
                }
                Console.WriteLine();


            }
            

        }
    }
}