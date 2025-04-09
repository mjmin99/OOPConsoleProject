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
            //Game.ChangeScene("KyungilGameAcademymainhall");
        }
    }
}
