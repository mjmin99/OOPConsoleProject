using OOPConsoleProject.GameObjects;
using OOPConsoleProject.Items;

namespace OOPConsoleProject.Scenes
{
    public class KyungilGameAcademylobby : FieldScene
    {

        public KyungilGameAcademylobby()
        {
            name = "KyungilGameAcademylobby";
            mapData = new string[]
            {
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒                               ▒",
                "▒         ▒▒▒▒▒▒▒▒▒▒▒▒▒         ▒",
                "▒                               ▒",
                "▒                               ▒",
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
            gameObjects.Add(new Place("KyungilGameAcademymainhall", 'O', new Vector2(6, 4)));
            gameObjects.Add(new Place("AllPublicAreas", 'O', new Vector2(12, 4)));
            gameObjects.Add(new Place("AdministrativeOffice", 'O', new Vector2(20, 4)));
            gameObjects.Add(new Place("PlanningLectureRoom", 'O', new Vector2(26, 4)));
            gameObjects.Add(new Note2(new Vector2(17, 1))); //재성쪽지 / 배치 완료
            //<-새로운게 추가된다면 이 줄에 적어야함
        }
        public override void Enter()
        {
            if (Game.prevSceneName == "PlanningLectureRoom")
            {
                Game.Player.position = new Vector2(26, 5);
            }
            else
            {
                Game.Player.position = new Vector2(16, 5);
                Game.Player.map = map;
            }
        }
    }
}
