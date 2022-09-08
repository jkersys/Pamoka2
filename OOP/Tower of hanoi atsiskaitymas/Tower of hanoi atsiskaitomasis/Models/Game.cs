namespace TowerOfHanoi.Models
{
    public class Game
    {
        public int TowersCount { get; set; }
        public int TowerHeight { get; set; }
        public int Moves { get; set; }

        public GameState State { get; private set; }

        public Disc? ActiveDisc { get; private set; } = null;

        public List<Tower> Towers { get; set; } = new List<Tower>();
        public Game(int towersCount, int towerHeight)
        {
            TowersCount = towersCount;
            TowerHeight = towerHeight;

            for (int i = 0; i < TowersCount; i++)
            {
                Towers.Add(new Tower(towerHeight));
            }

            for (int i = 0; i < towerHeight - 1; i++)
            {
                Towers[0].Discs.Add(new Disc(i + 1));
            }
        }

        public void SetInvalidState()
        {
            if (State == GameState.Initial)
            {
                State = GameState.InvalidInputTower;
            }
            if (State == GameState.DiskInHand)
            {
                State = GameState.InvalidDestinationTower;
            }
        }


        public void MakeMove(int towerNumber)
        {
            if (State == GameState.Initial || State == GameState.NoDisksInSelectedTower || State == GameState.InvalidInputTower)
            {
                var tower = Towers[towerNumber - 1];
                if (tower.Discs.Count == 0)
                {
                    State = GameState.NoDisksInSelectedTower;
                    return;
                }
                else
                {
                    State = GameState.DiskInHand;
                    ActiveDisc = tower.Discs.First();
                    tower.Discs.RemoveAt(0);
                    return;
                }
            }
            
            if (State == GameState.DiskInHand || State == GameState.DiskDoesNotFit || State == GameState.InvalidDestinationTower)
            {
                var tower = Towers[towerNumber - 1];

                if (tower.Discs.Any() && ActiveDisc.Size > tower.Discs.First().Size)
                {
                    State = GameState.DiskDoesNotFit;
                    return;
                }

                tower.Discs.Insert(0, ActiveDisc);
                State = GameState.Initial;
                ActiveDisc = null;
                Moves++;
            }
        }

        public void DrawTower()
        {
            for (int i = 0; i < TowerHeight; i++)
            {
                for (int j = 0; j < TowersCount; j++)
                {
                    var currentTower = Towers[j];
                    
                    var currentDisc = currentTower.Discs.Skip(i - 1).FirstOrDefault();

                    if (currentDisc != null && i > 0)
                    {
                        Console.Write($"{i + 1}eil.");
                        Console.Write(currentDisc.ToString()
                            .PadLeft(currentTower.Height + 4 + i, ' ')
                            .PadRight(2 * currentTower.Height + 10, ' '));
                    }
                    else
                    {
                        if (i == 0 && j == 0)
                        {
                            Console.Write($"{i + 1}eil.");
                        }
                        Console.Write("|".PadLeft(currentTower.Height + 4, ' ')
                            .PadRight(2 * currentTower.Height + 10, ' '));
                    }
                }
                Console.WriteLine();
            }

            var towerHeight = Towers[0].Height;

            Console.Write("      ");
            for (int i = 0; i < TowersCount; i++)
            {
                Console.Write($"[{i + 1}]".PadLeft(towerHeight + 4 + i, '-').PadRight(2 * towerHeight + 9, '-'));
            }
        }


        public void ChooseTower(char towerNumber)
        {
            
        }

        public void GetDisc(int towerNumber)
        {
            //Validation+
                 

            //ActiveDisc = Towers[towerNumber - 1].Disc.First();
            //Towers[towerNumber - 1].Disc.RemoveAt(towerNumber -1);
            //Towers[towerNumber - 1].IsActive = true;
            
        }
            public void PutDiscValidation()
            {
           

            }
        

            public void PutDisc(int towerNumber)
        {
            //Validation



            //ActiveDisc = Towers[towerNumber - 1].Disc.First();
            Towers[towerNumber - 1].Discs.Add(ActiveDisc);
            Towers[towerNumber - 1].IsActive = false;
            //CountMoves++;
            ActiveDisc = null;
        }

       

                public static char InputValidation()
                {
                var input = Console.ReadKey().KeyChar;
                if ((input != '1')
                   && (input != '2')
                   && (input != '3')
                   && (input != 'H')
                   && (input != 'h')
                   && (input != '\u001b'))
                {
                //Console.WriteLine("Tokio pasirinkimo nera");
                //input = Console.ReadKey().KeyChar;
            }

                return input;
            }


        }

        }
    

