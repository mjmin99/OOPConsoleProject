using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JT_2_2 : BaseScene
    {
        private ConsoleKey input; 
        public override void Render()
        {
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("|  [!]   [!]  | ");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|    \\___/    | ");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("정답~!");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("|  [-]   [-]  | ");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|    \\___/    | ");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("그렇다면 두 번째 문제");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("다음 중 델리게이트에 대한 설명 중 옳지 않은 것을 고르시오.");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. 델리게이트는 메서드를 참조할 수 있다");
            Console.WriteLine("2. 메서드를 매개변수로 전달할 수 있다");
            Console.WriteLine("3. 한 번 생성되면 참조하는 메서드의 목록을 변경할 수 없다");
            Console.WriteLine("4. Action은 반환 값이 없고 Func는 반환값이 존재한다");
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
                case ConsoleKey.D1:
                case ConsoleKey.D2:
                case ConsoleKey.D4:
                    Game.ChangeScene("Talk_JT_2_x");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Talk_JT_2_2_3");
                    break;
            }
        }

        public override void Result()
        {
            //Game.ChangeScene("Jeongtaeksroom");
        }
    }
}
