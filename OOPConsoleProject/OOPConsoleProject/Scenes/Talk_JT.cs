using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JT : BaseScene
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
            Util.PrintNoLine(" ", ConsoleColor.Gray, 1000);
            Console.Clear();
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("|  [-]   [-]  | ");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|    \\___/    |");
            Console.WriteLine(" \\___________/ ");
            Util.PrintNoLine(" ", ConsoleColor.Gray, 1000);
            Console.Clear();
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("|   [-]   [-] | ");
            Console.WriteLine("|       ^     | ");
            Console.WriteLine("|     \\___/   |");
            Console.WriteLine(" \\___________/ ");
            Util.PrintNoLine(" ", ConsoleColor.Gray, 1000);
            Console.Clear();
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("|  [-]   [-]  | ");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|    \\___/    |");
            Console.WriteLine(" \\___________/ ");
            Util.PrintNoLine(" ", ConsoleColor.Gray, 1000);
            Console.WriteLine();
            Console.WriteLine("반갑군, 내 이름은 정택. 교육과 수업 담당이다.");
            Console.WriteLine("왜 거기 가만히 서서 날 지켜보는 거지? 할 질문이라도 있나?");
            Console.WriteLine();
            Console.WriteLine("1. 아무것도 아닌 척 질문한다.");
            Console.WriteLine("2. 무찌른다.");
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
                    Game.ChangeScene("Jeongtaeksroom");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Jeongtaeksroom");
                    break;
            }
        }

        public override void Result()
        {
            //Game.ChangeScene("KyungilGameAcademymainhall");
        }
    }
}
