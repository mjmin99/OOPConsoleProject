using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class OpScene : BaseScene
    {
        private ConsoleKey input;
        private bool joke = false;
        private bool onetime = false;
        public override void Render()
        {
            if (onetime == false)
            {
                Util.Print("갑자기 머리가 깨질듯이 아프다....머리 속에서 누가 말을 걸어온다.", ConsoleColor.White, 3000);
            }

            Util.Print("", ConsoleColor.White, 1000);
            if (joke==true)
            {

                Console.WriteLine(".              |                      ");
                Console.WriteLine("  \\                      /           ");
                Console.WriteLine("           \\      /                  ");
                Console.WriteLine("      \\                /             ");
                Console.WriteLine("　　\\　　  장난치지　 　　/          ");
                Console.WriteLine("-　-　     마십시오! 　　-　-　-      ");
                Console.WriteLine("　　/ 다 들리지 않습니까!\\           ");
                Console.WriteLine("  /    /진짜 안들리나? .              ");
                Console.WriteLine("    /                \\               ");
                Console.WriteLine("          /  |                        ");
                Console.WriteLine("              .                       ");
                Console.WriteLine();
                Thread.Sleep(3000);
            }
            
            Console.Clear();
            Console.WriteLine(".              |                      ");
            Console.WriteLine("  \\                      /           ");
            Console.WriteLine("           \\      /                  ");
            Console.WriteLine("      \\                /             ");
            Console.WriteLine("　　\\　　    설마...　　　/          ");
            Console.WriteLine("-　-　　　제 목소리가　　-　-　-      ");
            Console.WriteLine("　　/　   들리시나요?　　\\           ");
            Console.WriteLine("  /    /               .              ");
            Console.WriteLine("    /                \\               ");
            Console.WriteLine("          /  |                        ");
            Console.WriteLine("              .                       ");
            Console.WriteLine();
            Console.WriteLine("1. 들린다.");
            Console.WriteLine("2. 안들린다.");


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
                    Game.ChangeScene("Op2");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Op");
                    joke = true;
                    onetime = true;
                    break;
            }

        }
    }
}
