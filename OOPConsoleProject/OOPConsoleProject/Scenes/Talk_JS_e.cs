using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JS_e : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("  @@@@@\\/@@@   ");
            Console.WriteLine(" @@@@@3   3@@@  ");
            Console.WriteLine(" ;           :  ");
            Console.WriteLine("|   [★] (O)   | ");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|    [___]    | ");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("제발.....");
            Thread.Sleep(200);
            Console.WriteLine();
            Console.WriteLine("정리되어있는 방을 어지럽히지마!!!");
            Console.WriteLine();
            Thread.Sleep(200);
            Console.WriteLine("무언갈 어지럽히기 전에 한 번 만 더 생각해!!!!");
            Thread.Sleep(200);
            Console.WriteLine();
            Console.WriteLine("이재성을 물리쳤다. 경일게임아카데미의 탈출이 더 가까워 진 것 같다.");
            Console.WriteLine();
            Thread.Sleep(200);
            Console.WriteLine("스텟이 떨어졌다. [정리정돈 +2]");
            Thread.Sleep(200);
            Console.WriteLine("보상을 받았다.");
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("이재성의 영혼석");
            Thread.Sleep(200);
            Console.ResetColor();
            Console.WriteLine("학생들을 향한 차가운 지혜가 느껴진다.");
            Thread.Sleep(200);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("탈출을 계속하려면 아무키나 눌러서 계속...");
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
                    Game.isCleared[1] = true; // 재성을 무찌름
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
