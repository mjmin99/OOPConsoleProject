using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JS_x : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("  @@@@@\\/@@@   ");
            Console.WriteLine(" @@@@@3   3@@@     ?");
            Console.WriteLine(" ;           : ");
            Console.WriteLine("|   (o) (o)   |");
            Console.WriteLine("|      ^      |");
            Console.WriteLine("|    [___]    | ");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(200);
            Thread.Sleep(1000);
            Console.WriteLine("이게 뭐하는 짓이지?");
            Thread.Sleep(200);
            Console.WriteLine("하나도 알 수가 없군...");
            Thread.Sleep(200);
            Console.WriteLine("뭐가됐든 TIL 은 꼭 작성할 수 있도록 하자");
            Thread.Sleep(200);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("TIL 작성하고 계속하고 싶으면 아무키나 눌러서 계속...");
       
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
           // Game.ChangeScene("Jaeseongsroom");
        }
    }
}
