using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JT_2 : BaseScene
    {
        private ConsoleKey input; 
        public override void Render()
        {
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("| [-]   [-]   | ");
            Console.WriteLine("|     ^       | ");
            Console.WriteLine("|   \\___/     |");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("|  [-]   [-]  | ");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|    \\___/    |");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("|   [-]   [-] | ");
            Console.WriteLine("|       ^     | ");
            Console.WriteLine("|     \\___/   |");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("|  [-]   [-]  | ");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|    \\___/    |");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("야레야레.. 쇼가나이나~, 스고쿠 카와이인다요.. 학생쟝은...");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("진짜로 무찌른다고 생각했어? 이 학원에서 날 \'무찌른다\'는 건..."); 
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("스승인 나보다 코딩 지식이 앞선 다는 것... 어이 거기, 나와 코딩 지식으로 듀얼이다!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("|  [-]   [-]  | ");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|    \\___/    |");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("자 그럼 1번 문제다.");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("요즘 코딩의 패러다임이며, C#은 기본적으로 ㅇㅇㅇㅇ 언어이다.");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("네모에 들어갈 말로 알 맞은 것은?");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. 절차지향");
            Console.WriteLine("2. 객체지향");
            Console.WriteLine("3. 순서지향");
            Console.WriteLine("4. 커서지향");
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
                case ConsoleKey.D3:
                case ConsoleKey.D4:
                    Game.ChangeScene("Talk_JT_2_x");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Talk_JT_2_2");
                    break;
            }
        }

        public override void Result()
        {
            //Game.ChangeScene("KyungilGameAcademymainhall");
        }
    }
}
