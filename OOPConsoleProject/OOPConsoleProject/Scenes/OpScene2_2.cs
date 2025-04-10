using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class OpScene2_2 : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Thread.Sleep(1000);
            Console.WriteLine(".              |                      ");
            Console.WriteLine("  \\                      /           ");
            Console.WriteLine("           \\      /                  ");
            Console.WriteLine("      \\                /             ");
            Console.WriteLine("　　\\　　  아직많이     　/          ");
            Console.WriteLine("-　-　　  혼란...네?.. 　-　-　-      ");
            Console.WriteLine("　　/　  이해가 빠르시 　\\           ");
            Console.WriteLine("  /    /     군요...   .              ");
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
            Console.WriteLine("　　\\　  형식상 설명    　/          ");
            Console.WriteLine("-　-　　 은 생략하죠   　-　-　-      ");
            Console.WriteLine("　　/　    (이상한) 　 　\\           ");
            Console.WriteLine("  /    / (녀석이네..)  .              ");
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
            Console.WriteLine("　　\\　　   우선..      　/          ");
            Console.WriteLine("-　-　  경일게임아카의 　-　-　-      ");
            Console.WriteLine("　　/ 세 마왕을 무찌르는 \\           ");
            Console.WriteLine("  /    /    겁니다     .              ");
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
            Console.WriteLine("　　\\　　    모든       　/          ");
            Console.WriteLine("-　-　  마왕이 쓰러지면　-　-　-      ");
            Console.WriteLine("　　/그 뒤 부턴 자연스레 \\           ");
            Console.WriteLine("  /    /알게 될 겁니다 .              ");
            Console.WriteLine("    /                \\               ");
            Console.WriteLine("          /  |                        ");
            Console.WriteLine("              .                       ");
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.WriteLine("내면속 존재는 홀연히 사라졌다. 그전에 잠깐 이건 정말 현실인가.");
            Console.WriteLine("내면속 존재의 말을 온전히 믿어도 되는 걸까?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("그래도 행동하기로 마음먹었다면 아무키를 눌러서 계속...");
            Console.ResetColor();
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
            Game.ChangeScene("KyungilGameAcademymainhall");
        }
    }
}
