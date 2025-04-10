using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class End_JT : BaseScene
    {
        private ConsoleKey input;
        private bool onetime = false;
        public override void Render()
        {
            if (onetime == false)
            {
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("|  [-]   [-]  | ");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|    \\___/    | ");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("그간 고생많았다. 뛰다가 넘어지지말고 차근차근 알았지?");
            Thread.Sleep(1000);
            Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("덕담을 듣고 나아갈 준비가 됐다면 아무키나 눌러서 계속...");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("  @@@@@@@@@@@   ");
                Console.WriteLine(" @@@@@@@@@@@@@  ");
                Console.WriteLine(" @           @  ");
                Console.WriteLine("|  [ㅠ] [ㅠ]  | ");
                Console.WriteLine("|      ^      | ");
                Console.WriteLine("|     ===     | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("(정택은 소리없이 울고 있다...)");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("스승의 뒷모습을 볼 준비가 됐다면 아무키나 눌러서 계속...");
                Console.ResetColor();
            }
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
                    onetime = true;
                    Game.ChangeScene("End");
                    break;
            }
        }

        public override void Result()
        {
            //Game.ChangeScene("KyungilGameAcademymainhall"); //자동이동기능
        }
    }
}
