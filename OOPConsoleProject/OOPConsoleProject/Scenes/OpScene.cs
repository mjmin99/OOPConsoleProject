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
        public override void Render()
        {
            Util.Print("갑자기 머리가 깨질듯이 아프다....",ConsoleColor.White, 300);

            Util.Print("", ConsoleColor.White, 300);

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
                    break;
            }

        }
    }
}
