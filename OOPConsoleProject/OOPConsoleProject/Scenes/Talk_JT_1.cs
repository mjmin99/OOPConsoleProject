using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JT_1 : BaseScene
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
            Console.WriteLine("야레야레.. 쇼가나이나~, 귀엽다니깐 학생쟝은...");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("길을 잘못들었구나.");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("어서 자리로 돌아가고↗ 출석↗확인해주라~");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("아무키나 눌러서 자리로 돌아가기...");
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
