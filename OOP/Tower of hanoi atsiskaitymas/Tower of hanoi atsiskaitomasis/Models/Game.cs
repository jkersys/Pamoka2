namespace TowerOfHanoi.Models
{
    public class Game
    {
        public int TowersCount { get; set; }
        public int TowerHeight { get; set; }

        public Disc ActiveDisc { get; private set; }

        public List<Tower> Towers { get; set; } = new List<Tower>();
        public Game(int towersCount, int towerHeight)
        {
            TowersCount = towersCount;
            TowerHeight = towerHeight;

            for (int i = 0; i < TowersCount; i++)
            {
                Towers.Add(new Tower(towerHeight));
            }

            for (int i = 0; i < towerHeight; i++)
            {
                Towers[0].Dics.Add(new Disc(i));
                //Towers[1].Dics.Add(new Disc(i));
                //Towers[2].Dics.Add(new Disc(i));
            }
        }

        public void ChooseTower(int towerNumber)
        {

        }

        public void GetDisc(int towerNumber)
        {
            //Validation+

            ActiveDisc = Towers[towerNumber - 1].Dics.First();
            Towers[towerNumber - 1].Dics.Remove(ActiveDisc);
            Towers[towerNumber - 1].IsActive = true;
        }

        public void PutDisc(int towerNumber)
        {
            //Validation



            ActiveDisc = Towers[towerNumber - 1].Dics.First();
            Towers[towerNumber - 1].Dics.Add(ActiveDisc);
            Towers[towerNumber - 1].IsActive = false;
        }

        public static void DrawTower()
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
                            .PadLeft(currentTower.Height + 4 + i, ' ')
                            .PadRight(2 * currentTower.Height + 10, ' '));
                    }
                    else
                    {
                        Console.Write("|".PadLeft(currentTower.Height + 4, ' ')
                            .PadRight(2 * currentTower.Height + 10, ' '));

                    }

                }
                Console.WriteLine();
            }
            }
        }
    }

