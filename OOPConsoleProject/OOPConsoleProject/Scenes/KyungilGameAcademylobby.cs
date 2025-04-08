using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Scenes
{
    class KyungilGameAcademylobby : FieldScene
    {
        private ConsoleKey input;

        private string[] mapData;

        private bool[,] map;

        private List<GameObject> gameObjects;

        public KyungilGameAcademylobby()
        {
            mapData = new string[]
            {
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒                               ▒",
                "▒         ▒▒▒▒▒▒▒▒▒▒▒▒          ▒",
                "▒                               ▒",
                "▒     ▒     ▒      ▒      ▒     ▒",
                "▒                               ▒",
                "▒                               ▒",
                "▒                               ▒",
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",

            };

            map = new bool[9, 33];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '▒' ? false : true;
                }
            }

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("Title", 'P', new Vector2(1, 1))); //임시로 타이틀을 넣었으나 나중에 포탈로 다른 맵과 이어야함
            //<-새로운게 추가된다면 이 줄에 적어야함
            Game.Player.position = new Vector2(33, 10);
            Game.Player.map = map;

        }
    }
}
