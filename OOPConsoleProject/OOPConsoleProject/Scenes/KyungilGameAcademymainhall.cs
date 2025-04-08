using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class KyungilGameAcademymainhall : BaseScene
    {
        private ConsoleKey input;

        private string[] mapData;
        
        private bool[,] map;

        public KyungilGameAcademymainhall()
        {
            mapData = new string[]
            {
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒                      ▒                   ▒                       ▒",
                "▒                      ▒                   ▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒",
                "▒                      ▒                   ▒  ▒     ▒     ▒     ▒  ▒",
                "▒                      ▒                   ▒  ▒     ▒     ▒     ▒  ▒",
                "▒▒▒▒▒▒▒▒▒▒▒▒           ▒▒▒▒             ▒▒▒▒  ▒     ▒     ▒     ▒  ▒",
                "▒                         ▒             ▒     ▒▒▒ ▒▒▒▒▒ ▒▒▒▒▒ ▒▒▒  ▒",
                "▒                         ▒▒▒▒▒▒▒  ▒▒▒▒▒▒                          ▒",
                "▒                                                                  ▒",
                "▒                                                                  ▒",
                "▒                                                                  ▒",
                "▒                                                                  ▒",
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒                                                                  ▒",
                "▒                                                                  ▒",
                "▒                                                                  ▒",
                "▒                                                                  ▒",
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
        }


        public override void Render()
        {
            PrintMap();
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {

        }
        public override void Result()
        {
          
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
