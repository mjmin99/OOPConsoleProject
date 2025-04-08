using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Scenes
{
    class AllPublicAreas : BaseScene
    {
        private ConsoleKey input;

        private string[] mapData;

        private bool[,] map;

        private List<GameObject> gameObjects;

        public AllPublicAreas()
        {
            mapData = new string[]
                {
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒    ▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒        ▒▒▒▒▒▒▒    ▒",
                "▒                 ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                 ▒",
                "▒                    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                    ▒",
                "▒                       ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                       ▒",
                "▒                                                             ▒",
                "▒                                                             ▒",
                "▒   ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒         ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒   ▒",
                "▒                                                             ▒",
                "▒   ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒         ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒   ▒",
                "▒                                                             ▒",
                "▒   ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒         ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒   ▒",
                "▒                                                             ▒",
                "▒   ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒         ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒ ▒▒   ▒",
                "▒                                                             ▒",
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                };

            map = new bool[16, 63];
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
        public override void Render()
        {
            PrintMap();
            foreach (GameObject go in gameObjects)
            {
                go.Print();
            }
            Game.Player.Print();
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public override void Update()
        {
            Game.Player.Move(input);
        }

        public override void Result()
        {
            foreach (GameObject go in gameObjects)
            {
                if (Game.Player.position == go.position) // 두 값끼리 비교를 위해 연산자 재정의를 해본다.
                {
                    go.Interact(Game.Player);
                }
            }
        }

        private void PrintMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == true)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write('▒');
                    }
                }
                Console.WriteLine(); //4차 버그 줄바꿈 위치가 잘못되어 있었음
            }
        }
    }
}
