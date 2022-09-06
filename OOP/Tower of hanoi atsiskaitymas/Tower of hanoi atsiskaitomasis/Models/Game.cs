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

            for (int i = 1; i < towerHeight; i++)
            {
                Towers[0].Dics.Add(new Disc(i));
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
    }
}
