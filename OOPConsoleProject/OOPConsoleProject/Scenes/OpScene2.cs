using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class OpScene2 : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Thread.Sleep(1000);
            Console.WriteLine(".              |                      ");
            Console.WriteLine("  \\                      /           ");
            Console.WriteLine("           \\      /                  ");
            Console.WriteLine("      \\                /             ");
            Console.WriteLine("　　\\　　   저는...     　/          ");
            Console.WriteLine("-　-　　　당신의 내면　　-　-　-      ");
            Console.WriteLine("　　/　    속 존재...　　\\           ");
            Console.WriteLine("  /    /               .              ");
            Console.WriteLine("    /                \\               ");
            Console.WriteLine("          /  |                        ");
            Console.WriteLine("              .                       ");
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine(".              |                      ");
            Console.WriteLine("  \\                      /           ");
            Console.WriteLine("           \\      /                  ");
            Console.WriteLine("      \\                /             ");
            Console.WriteLine("　　\\　　   당신을      　/          ");
            Console.WriteLine("-　-　  무슨일이 있어도  -　-　-      ");
            Console.WriteLine("　　/　   반드시 경일　　\\           ");
            Console.WriteLine("  /    /   아카데미    .              ");
            Console.WriteLine("    /                \\               ");
            Console.WriteLine("          /  |                        ");
            Console.WriteLine("              .                       ");
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine(".              |                      ");
            Console.WriteLine("  \\                      /           ");
            Console.WriteLine("           \\      /                  ");
            Console.WriteLine("      \\                /             ");
            Console.WriteLine("　　\\　　   밖으로      　/          ");
            Console.WriteLine("-　-　인도해야하는 사명  -　-　-      ");
            Console.WriteLine("　　/　을 지니고 태어난　\\           ");
            Console.WriteLine("  /    /     자...     .              ");
            Console.WriteLine("    /                \\               ");
            Console.WriteLine("          /  |                        ");
            Console.WriteLine("              .                       ");
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine(".              |                      ");
            Console.WriteLine("  \\                      /           ");
            Console.WriteLine("           \\      /                  ");
            Console.WriteLine("      \\                /             ");
            Console.WriteLine("　　\\　탈출하십시오...  　/          ");
            Console.WriteLine("-　- 당신은 이곳에 있을  -　-　-      ");
            Console.WriteLine("　　/　사람이 아닙니다.　\\           ");
            Console.WriteLine("  /    /    그럼...    .              ");
            Console.WriteLine("    /                \\               ");
            Console.WriteLine("          /  |                        ");
            Console.WriteLine("              .                       ");
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.WriteLine("1. 잠깐 기다려... 왜 여기를 나가야한다는 거야?");
            Console.WriteLine("2. 응 그래 알겠어. 그래서 나는 뭘 해야하지?");
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
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Op2_1");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Op2_2");
                    break;
            }

        }
    }
}
