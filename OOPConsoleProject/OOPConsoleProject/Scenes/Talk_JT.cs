﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JT : BaseScene
    {
        private ConsoleKey input; 
        public override void Render()
        {
            if (Game.isCleared[0] == false)
            {
                Console.WriteLine("  @@@@@@@@@@@   ");
                Console.WriteLine(" @@@@@@@@@@@@@  ");
                Console.WriteLine(" @           @    ┏━━━━");
                Console.WriteLine("|  [-]   [-]  |   ┃ 삼마");
                Console.WriteLine("|      ^      |   ┗━━━━");
                Console.WriteLine("|    \\___/    |");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@@@@@@@   ");
                Console.WriteLine(" @@@@@@@@@@@@@  ");
                Console.WriteLine(" @           @    ┏━━━━━━━━");
                Console.WriteLine("|  [-]   [-]  |   ┃ 삼마왕 ");
                Console.WriteLine("|      ^      |   ┗━━━━━━━━");
                Console.WriteLine("|    \\___/    |");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@@@@@@@   ");
                Console.WriteLine(" @@@@@@@@@@@@@  ");
                Console.WriteLine(" @           @    ┏━━━━━━━━━━━");
                Console.WriteLine("|  [-]   [-]  |   ┃ 삼마왕 중 ");
                Console.WriteLine("|      ^      |   ┗━━━━━━━━━━━");
                Console.WriteLine("|    \\___/    |");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@@@@@@@   ");
                Console.WriteLine(" @@@@@@@@@@@@@  ");
                Console.WriteLine(" @           @    ┏━━━━━━━━━━━━━");
                Console.WriteLine("|  [-]   [-]  |   ┃ 삼마왕 중 첫");
                Console.WriteLine("|      ^      |   ┗━━━━━━━━━━━━━");
                Console.WriteLine("|    \\___/    |");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@@@@@@@   ");
                Console.WriteLine(" @@@@@@@@@@@@@  ");
                Console.WriteLine(" @           @    ┏━━━━━━━━━━━━━━━━━");
                Console.WriteLine("|  [-]   [-]  |   ┃ 삼마왕 중 첫째 :");
                Console.WriteLine("|      ^      |   ┗━━━━━━━━━━━━━━━━━");
                Console.WriteLine("|    \\___/    |");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@@@@@@@   ");
                Console.WriteLine(" @@@@@@@@@@@@@  ");
                Console.WriteLine(" @           @    ┏━━━━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine("|  [-]   [-]  |   ┃ 삼마왕 중 첫째 : 김정택");
                Console.WriteLine("|      ^      |   ┗━━━━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine("|    \\___/    |");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@@@@@@@   ");
                Console.WriteLine(" @@@@@@@@@@@@@  ");
                Console.WriteLine(" @           @    ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine("|  [-]   [-]  |   ┃ 삼마왕 중 첫째 : 김정택 / 직");
                Console.WriteLine("|      ^      |   ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine("|    \\___/    |");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@@@@@@@   ");
                Console.WriteLine(" @@@@@@@@@@@@@  ");
                Console.WriteLine(" @           @    ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine("|  [-]   [-]  |   ┃ 삼마왕 중 첫째 : 김정택 / 직업 ");
                Console.WriteLine("|      ^      |   ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine("|    \\___/    |");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@@@@@@@   ");
                Console.WriteLine(" @@@@@@@@@@@@@  ");
                Console.WriteLine(" @           @    ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine("|  [-]   [-]  |   ┃ 삼마왕 중 첫째 : 김정택 / 직업 : 전");
                Console.WriteLine("|      ^      |   ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine("|    \\___/    |");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@@@@@@@   ");
                Console.WriteLine(" @@@@@@@@@@@@@  ");
                Console.WriteLine(" @           @    ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine("|  [-]   [-]  |   ┃ 삼마왕 중 첫째 : 김정택 / 직업 : 전사  ┃");
                Console.WriteLine("|      ^      |   ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                Console.WriteLine("|    \\___/    |");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("나는 정택, 전사다. 교육과 수업 담당이다.");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("왜 거기 가만히 서서 날 지켜보는 거지? 용건이라도 있나?");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. 죄송합니다 강의실을 헷갈렸습니다.");
                Console.WriteLine("2. 김전사를 무찌른다.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("  @@@@@@@@@@@   ");
                Console.WriteLine(" @@@@@@@@@@@@@  ");
                Console.WriteLine(" @           @  ");
                Console.WriteLine("|  [-]   [-]  | ");
                Console.WriteLine("|      ^      | ");
                Console.WriteLine("|    \\___/    |");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("지금 이러고 있을때가 아니다.");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("공부는 결국 개인의 몫이야.");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("해야할 공부가 생각나서 계속하려면 아무키나 눌러서 계속...");
                Console.ResetColor();
            }
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {

            if (Game.isCleared[0] == false)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                        Game.ChangeScene("Talk_JT_1");
                        break;
                    case ConsoleKey.D2:
                        Game.ChangeScene("Talk_JT_2");
                        break;
                }
            }
            else
            {
                switch (input)
                {
                    default:
                        Game.ChangeScene("Jeongtaeksroom");
                        break;
                }
            }
        }

        public override void Result()
        {
            //Game.ChangeScene("KyungilGameAcademymainhall");
        }
    }
}
