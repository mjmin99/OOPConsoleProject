using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public abstract class FieldScene : BaseScene
    {
        private ConsoleKey input;

        protected string[] mapData;

        protected bool[,] map;

        protected List<GameObject> gameObjects;

        public override void Render()
        {
            PrintMap();
            foreach (GameObject go in gameObjects)
            {
                go.Print();
            }
            Game.Player.Print();

            Console.SetCursorPosition(70, 0);
            Game.Player.inventory.PrintALL();
            PrintSoulStons();

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
                    if(go.isOnce == true)
                        { 
                            gameObjects.Remove(go);
                        }
                    break;
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

        private void PrintSoulStons()
        {
            Console.SetCursorPosition(70, 13);
            Console.WriteLine("┏━━━━가지고 있는 영혼석━━━━┓");
            Console.SetCursorPosition(70, 14);
            if (Game.isCleared[0] == false)
            {
                Console.WriteLine("┃          (빈칸)          ┃");
            }
            else if (Game.isCleared[0] == true)
            {
                Console.Write("┃");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("     김정택의 영혼석      ");
                Console.ResetColor();
                Console.Write("┃");
            }
            Console.SetCursorPosition(70, 15);
            if (Game.isCleared[1] == false)
            {
                Console.WriteLine("┃          (빈칸)          ┃");
            }
            else if (Game.isCleared[1] == true)
            {
                Console.Write("┃");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("     이재성의 영혼석      ");
                Console.ResetColor();
                Console.Write("┃");
            }
            Console.SetCursorPosition(70, 16);
            if (Game.isCleared[2] == false)
            {
                Console.WriteLine("┃          (빈칸)          ┃");
            }
            else if (Game.isCleared[2] == true)
            {
                Console.Write("┃");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("     박준헌의 영혼석      ");
                Console.ResetColor();
                Console.Write("┃");
            }
            Console.SetCursorPosition(70, 17);
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }

        public void AddGameObject(GameObject go) // 질문 받아서 작성한 내용
        { 
            gameObjects.Add(go);
        }
    }
}
