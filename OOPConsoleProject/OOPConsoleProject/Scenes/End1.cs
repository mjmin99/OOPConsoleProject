using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class End1 : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            Console.WriteLine("이 느낌은? 내면의 의식이 말을 걸어온다.");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine(".              |                      ");
            Console.WriteLine("  \\                      /           ");
            Console.WriteLine("           \\      /                  ");
            Console.WriteLine("      \\                /             ");
            Console.WriteLine("　　\\　　    무사히     　/          ");
            Console.WriteLine("-　-　　 　경일아카를  　-　-　-      ");
            Console.WriteLine("　　/　  \'졸업\'했구나!　 \\         ");
            Console.WriteLine("  /    /     축하해.   .              ");
            Console.WriteLine("    /                \\               ");
            Console.WriteLine("          /  |                        ");
            Console.WriteLine("              .                       ");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine(".              |                      ");
            Console.WriteLine("  \\                      /           ");
            Console.WriteLine("           \\      /                  ");
            Console.WriteLine("      \\                /             ");
            Console.WriteLine("　　\\　　  수고했어     　/          ");
            Console.WriteLine("-　-　 밖은 더 힘들거야  -　-　-      ");
            Console.WriteLine("　　/　    하지만......　\\           ");
            Console.WriteLine("  /    /               .              ");
            Console.WriteLine("    /                \\               ");
            Console.WriteLine("          /  |                        ");
            Console.WriteLine("              .                       ");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine(".              |                      ");
            Console.WriteLine("  \\                      /           ");
            Console.WriteLine("           \\      /                  ");
            Console.WriteLine("      \\                /             ");
            Console.WriteLine("　　\\　　   그때도      　/          ");
            Console.WriteLine("-　-　  포기하지마....!! -　-　-      ");
            Console.WriteLine("　　/　  너라면 뭐든지 　\\           ");
            Console.WriteLine("  /    /  할 수 있어!  .              ");
            Console.WriteLine("    /                \\               ");
            Console.WriteLine("          /  |                        ");
            Console.WriteLine("              .                       ");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("문을 열고 나갈 준비가 됐으면 아무키나 눌러서 계속...");
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
                    Game.gameOver = true;
                    Game.ChangeScene("Talk_JH_2");
                    break;
            }
        }

        public override void Result()
        {
            //Game.ChangeScene("KyungilGameAcademymainhall"); //자동이동기능
        }
    }
}
