using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JT_e : BaseScene
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
            Console.Clear();
            Console.WriteLine("  @@@@@@@@@@@   ");
            Console.WriteLine(" @@@@@@@@@@@@@  ");
            Console.WriteLine(" @           @  ");
            Console.WriteLine("|  [♥]   [♥]  | ");
            Console.WriteLine("|      ^      | ");
            Console.WriteLine("|    \\___/    | ");
            Console.WriteLine(" \\___________/ ");
            Thread.Sleep(1000);
            Console.WriteLine("너무 훌륭하게 잘해주었다.");
            Console.WriteLine("물론 앞으로 취업의 문턱이 쉽진 않겠지만");
            Console.WriteLine("이렇게 열심히 하는 너라면 잘 될 수 있을 거라고 믿는다.");
            Console.WriteLine("\'경일게임아카데미\'를 무사히 탈출 할 수 있겠구나!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("김정택의 응원을 받았다. 경일게임아카데미 탈출이 더 가까워 진 것 같다.");
            Console.WriteLine("스텟이 올랐다. 코딩개념 +1");
            Console.WriteLine("보상을 받았다.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("김정택의 영혼석");
            Console.ResetColor(); 
            Console.WriteLine("학생들을 향한 뜨거운 힘이 느껴진다.");
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            Game.isCleared[0] = true; // 정택을 무찌름
        }

        public override void Result()
        {
            Game.ChangeScene("Jeongtaeksroom");
        }
    }
}
