using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class End_JH : BaseScene
    {
        private ConsoleKey input;
        private bool onetime = false;
        public override void Render()
        {
            if (onetime == false)
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
                Console.WriteLine("어~ 고생많았어. 하지만 이제 회원가입 완료했을 뿐.. 앞으로도 게을리하면 안된다~");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("아 재성이는 방정리 중이라 못왔데");
                Console.WriteLine();
                Console.WriteLine("못왔지만 막내를 보낸 정성이 느껴지면 아무키나 눌러서 계속...");
            }
            else
            {
                Console.WriteLine("  /////\\\\\\\\\\\\   ");
                Console.WriteLine(" ///////\\\\\\\\\\\\  ");
                Console.WriteLine("//           \\\\  ");
                Console.WriteLine("|--[!]---[!]--|     ");
                Console.WriteLine("|      ^    . |     ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Console.WriteLine();
                Console.WriteLine("\"뭐하고 있어! 너가 가장 기다린 순간이잖아! 어서 탈출해!");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("이 경일게임아카데미를!\" .... 이라고 재성이가 전해달래");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("역시나 못왔지만 막내를 시킨 정성이 느껴지면 아무키나 눌러서 계속...");
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
