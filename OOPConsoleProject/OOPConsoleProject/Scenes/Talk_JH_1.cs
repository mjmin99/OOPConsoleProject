using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JH_1 : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("  /////\\\\\\\\\\\\   ");
            Console.WriteLine(" ///////\\\\\\\\\\\\  ");
            Console.WriteLine("//           \\\\  ");
            Console.WriteLine("|--[o]---[o]--|     ");
            Console.WriteLine("|      ^    . |     ");
            Console.WriteLine("|    [___]    | ");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("그렇구나 괜찮아. 혹시 무슨 고민이 있다면");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("편하게 말해보렴 난 그러라고 있는 사람인걸");
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("(다른 마왕들에게서 느껴보지 못한 따뜻함...)");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("(나는 이런 마왕들을 무찔러야 하는가..)");
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("마음이 따뜻해지는 걸 느꼈다면 아무키를 누르고 계속...");
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
                    Game.ChangeScene("JunheonsRoom");
                    break;
            }
        }

        public override void Result()
        {
            //Game.ChangeScene("KyungilGameAcademymainhall");
        }
    }
}
