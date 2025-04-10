using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JS_1 : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("  @@@@@\\/@@@   ");
            Console.WriteLine(" @@@@@3   3@@@  ");
            Console.WriteLine(" ;           :  ");
            Console.WriteLine("|   (-) (♥)   | ");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|    [___]    | ");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("이번엔 어물쩡 넘어가주지만");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("다음부턴 이렇게 쉽게 보내줄 생각은 없다는 것만 알아두도록 해");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("간신히 탈출해서 나가고 싶다면 아무키나 눌러서 계속...");
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
                    Game.ChangeScene("Jaeseongsroom");
                    break;
            }
        }

        public override void Result()
        {
            //Game.ChangeScene("Jaeseongsroom");
        }
    }
}
