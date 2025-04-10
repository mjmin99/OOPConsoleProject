using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JH_2 : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("  /////\\\\\\\\\\\\   ");
            Console.WriteLine(" ///////\\\\\\\\\\\\  ");
            Console.WriteLine("//           \\\\ ");
            Console.WriteLine("|--[o]---[o]--|   ");
            Console.WriteLine("|      ^    . |   ");
            Console.WriteLine("|    [___]    | ");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.WriteLine("이 경일아카에서 무찌른다는 건 결국 스승을 뛰어넘어 밖으로 나간다는 것...");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("나 박준헌은 학생이 그럴 의지가 있는지 테스트하는 사람이지"); 
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("스스로 헤쳐나갈 마음이 들었다면.. 그걸로 충분해");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("가져가라..");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("박준헌의 테스트를 통과했다. 경일게임아카데미 탈출이 더 가까워진 것 같다.");
            Thread.Sleep(1000);
            Console.WriteLine("스텟이 올랐다. [헤쳐나갈 용기 +1]");
            Thread.Sleep(1000);
            Console.WriteLine("보상을 받았다.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("박준헌의 영혼석");
            Thread.Sleep(1000);
            Console.ResetColor();
            Console.WriteLine("어떠한 상황에서도 겁먹지 않을 용기가 느껴진다.");
            Thread.Sleep(1000);
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
                    Game.ChangeScene("JunheonsRoom");
                    Game.isCleared[2] = true;
                    break;
            }
        }

        public override void Result()
        {
            //Game.ChangeScene("KyungilGameAcademymainhall");
        }
    }
}
