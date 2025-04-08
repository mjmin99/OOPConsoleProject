using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Scenes
{
    public class KyungilGameAcademymainhall : FieldScene
    {

        public KyungilGameAcademymainhall()
        {
            name = "KyungilGameAcademymainhall";
            mapData = new string[]
            {
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒                      ▒                   ▒                       ▒",
                "▒                      ▒                   ▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒",
                "▒                      ▒                   ▒  ▒     ▒     ▒     ▒  ▒",
                "▒                      ▒                   ▒  ▒     ▒     ▒     ▒  ▒",
                "▒▒▒▒▒▒▒▒▒▒▒▒           ▒▒▒▒             ▒▒▒▒  ▒     ▒     ▒     ▒  ▒",
                "▒                         ▒             ▒     ▒▒▒ ▒▒▒▒▒ ▒▒▒▒▒ ▒▒▒  ▒",
                "▒                         ▒▒▒▒▒▒   ▒▒▒▒▒▒                          ▒",
                "▒                                                                  ▒",
                "▒                                                                  ▒",
                "▒   ▒   ▒   ▒                                       ▒    ▒    ▒    ▒",
                "▒                                                                  ▒",
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒                                                                  ▒",
                "▒           ▒▒▒▒                ▒▒▒▒                ▒▒▒▒           ▒",
                "▒                                                                  ▒",
                "▒           ▒▒▒▒                ▒▒▒▒                ▒▒▒▒           ▒",
                "▒                                                                  ▒",
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
            };

            map = new bool[19, 68];
            for (int y = 0; y < map.GetLength(0) ; y++)
            {
                for (int x = 0; x < map.GetLength(1) ; x++)
                {
                    map[y, x] = mapData[y][x] == '▒' ? false : true;
                }
            } 

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("Jeongtaeksroom", 'O', new Vector2(49, 6)));
            gameObjects.Add(new Place("Jaeseongsroom", 'O', new Vector2(55, 6)));
            gameObjects.Add(new Place("JunheonsRoom", 'O', new Vector2(61, 6)));
            //<-새로운게 추가된다면 이 줄에 적어야함

        }

        public override void Enter()
        {
            if ((Game.prevSceneName == "Op2_1") || (Game.prevSceneName == "Op2_2"))
            {
                Game.Player.position = new Vector2(33, 10);
            }
            else if (Game.prevSceneName == "Jeongtaeksroom")
            {
                Game.Player.position = new Vector2(49, 7);
            }
            Game.Player.map = map;
        }

    }
}
