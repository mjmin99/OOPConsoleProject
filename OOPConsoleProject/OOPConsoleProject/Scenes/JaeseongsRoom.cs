using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Scenes
{
    public class Jaeseongsroom : FieldScene
    {
        
        public Jaeseongsroom()
        {
            name = "Jaeseongsroom";
            mapData = new string[]
            {
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒                   ▒",
                "▒                   ▒",
                "▒                   ▒",
                "▒                   ▒",
                "▒                   ▒",
                "▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒",
            };

            map = new bool[7, 21];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '▒' ? false : true;
                }
            }

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("KyungilGameAcademymainhall", 'O', new Vector2(10, 6))); //임시로 타이틀을 넣었으나 나중에 포탈로 다른 맵과 이어야함
            //<-새로운게 추가된다면 이 줄에 적어야함
        }

        public override void Enter()
        {
            Game.Player.position = new Vector2(10, 5);
            Game.Player.map = map;
        }
    }
}
