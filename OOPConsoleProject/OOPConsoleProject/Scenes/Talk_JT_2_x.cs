using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JT_2_x : BaseScene
    {
        private ConsoleKey input; 
        public override void Render()
        {
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("|  [\\]   [/]  |");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|     ___     |");
            Console.WriteLine(" \\___________/ ");
            Util.PrintNoLine(" ", ConsoleColor.Gray, 1000);
            Console.WriteLine();
            Console.WriteLine("오답이다! 쉬는 시간에도 공부를 할 수 있도록 한다.");
            Console.WriteLine("그것이 \'진정한 탈출\'로 이어지는 길이다!");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("공부를 다시 하려면 아무키나 눌러서 계속...");
            Console.ResetColor();
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            switch (input)
            {
                default:
                    Game.ChangeScene("Jeongtaeksroom");
                    break;
            }
        }

        public override void Result()
        {
            //Game.ChangeScene("Jeongtaeksroom");
        }
    }
}
