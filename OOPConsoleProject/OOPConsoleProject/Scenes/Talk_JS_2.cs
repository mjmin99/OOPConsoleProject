using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JS_2: BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("  @@@@@\\/@@@   ");
            Console.WriteLine(" @@@@@3   3@@@  ");
            Console.WriteLine(" ;           :  ");
            Console.WriteLine("|   (o) (o)   | ");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|    [___]    | ");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.WriteLine("좋아 어디 내가 내는 문제를.....");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("(으윽... 쪽지도 문제였는데 이런식으로 나오기야..? 독하다 독해!)");
            Thread.Sleep(1000);
            Console.WriteLine("(뭔가 방법을 떠올려야해... 이 문제 지옥을 벗어날 방법을...)");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. 잘 정리되어 있는 방을 어지럽힌다.");
            Console.WriteLine("2. 아까 쪽지에 대해서 질문한다.");
            Console.WriteLine("3. 난데없이 하늘을 쳐다본다.");
            Console.WriteLine("4. 갑자기 춤을 추는 기행을 부린다.");
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
                    Game.ChangeScene("Talk_JS_e");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.D3:
                case ConsoleKey.D4:
                    Game.ChangeScene("Talk_JS_x");
                    break;

            }
        }

        public override void Result()
        {
            //Game.ChangeScene("KyungilGameAcademymainhall");
        }
    }
}
