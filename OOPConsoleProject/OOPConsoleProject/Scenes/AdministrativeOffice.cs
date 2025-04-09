using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Scenes
{
    public class AdministrativeOffice : FieldScene
    {

        public AdministrativeOffice() 
        {
            name = "AdministrativeOffice";
            mapData = new string[]
               {
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒        ▒        ▒        ▒       ▒        ▒        ▒        ▒",
                "▒        ▒        ▒        ▒       ▒        ▒        ▒        ▒",
                "▒        ▒        ▒        ▒       ▒        ▒        ▒        ▒",
                "▒▒▒▒  ▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒  ▒▒▒▒       ▒▒▒▒  ▒▒▒▒▒▒▒  ▒▒▒▒▒▒▒  ▒▒▒▒",
                "▒                                                             ▒",
                "▒                         ▒▒▒▒▒▒▒▒▒▒▒                         ▒",
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
               };

            map = new bool[8, 63];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '▒' ? false : true;
                }
            }

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("KyungilGameAcademylobby", 'O', new Vector2(24, 6)));
            gameObjects.Add(new Place("KyungilGameAcademylobby", 'O', new Vector2(25, 6)));
            gameObjects.Add(new Place("KyungilGameAcademylobby", 'O', new Vector2(37, 6)));
            gameObjects.Add(new Place("KyungilGameAcademylobby", 'O', new Vector2(38, 6)));
            //<-새로운게 추가된다면 이 줄에 적어야함
        }
        public override void Enter()
        {
            Game.Player.position = new Vector2(31, 5);
            Game.Player.map = map;
        }
    }
}
