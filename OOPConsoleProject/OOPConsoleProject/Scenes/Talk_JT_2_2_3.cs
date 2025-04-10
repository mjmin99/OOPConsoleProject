using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JT_2_2_3 : BaseScene
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
            Console.WriteLine("그렇다면 세 번째 문제");
            Console.WriteLine("다음 설명 중 옳지 않은 것을 고르시오");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. 이벤트 - 이벤트를 선언하지 않은 외부 객체에서 참조해 참조한 메서드를 호출할 수 있다");
            Console.WriteLine("2. 이벤트 - 이벤트는 반환형이 있는 함수만 참조할 수 있다.");
            Console.WriteLine("3. 람다식 - 익명메서드를 간결하게 표현하는 방식 중 하나이다");
            Console.WriteLine("4. 람다식 - 주로 복잡한 로직이나 긴 코드를 작성할 때 효과적으로 사용된다");
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
                case ConsoleKey.D3:
                    Game.ChangeScene("Talk_JT_2_x");
                    break;
                case ConsoleKey.D4:
                    Game.ChangeScene("Talk_JT_e");
                    break;
            }
        }

        public override void Result()
        {
            //Game.ChangeScene("Jeongtaeksroom");
        }
    }
}
