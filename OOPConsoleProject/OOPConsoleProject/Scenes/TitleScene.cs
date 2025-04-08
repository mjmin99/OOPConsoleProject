﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class TitleScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine();
            Util.PrintNoLine("주위를 둘러봐도", ConsoleColor.White, 666);
            Util.PrintNoLine("\'빛\'", ConsoleColor.DarkYellow, 666);
            Util.PrintNoLine("이라곤 찾아볼 수 없는 이곳은...", ConsoleColor.Gray, 666);
            Console.WriteLine();
            Console.WriteLine();
            Util.Print(" _____                                   __                         ", ConsoleColor.White, 333);
            Util.Print("|  ___|                                 / _|                         ", ConsoleColor.White, 333);
            Util.Print("| |__   ___   ___   __ _  _ __    ___  | |_  _ __   ___   _ __ ___   ", ConsoleColor.White, 333);
            Util.Print("|  __| / __| / __| / _` || '_ \\  / _ \\ |  _|| '__| / _ \\ | '_ ` _ \\  ", ConsoleColor.White, 333);
            Util.Print("| |___ \\__ \\| (__ | (_| || |_) ||  __/ | |  | |   | (_) || | | | | | ", ConsoleColor.White, 333);
            Util.Print("\\____/ |___/ \\___| \\__,_|| .__/  \\___| |_|  |_|    \\___/ |_| |_| |_|", ConsoleColor.White, 333);
            Util.Print("                         | |                                         ", ConsoleColor.White, 333);
            Util.Print  ("                         |_|                                         ", ConsoleColor.White, 333);
            Console.WriteLine();
            Util.Print  (" _   __                             _  _      ___                    _                         ", ConsoleColor.White, 333);
            Util.Print("| | / /                            (_)| |    / _ \\                  | |                        ", ConsoleColor.White, 333);
            Util.Print  ("| |/ /  _   _  _   _  _ __    __ _  _ | |   / /_\\ \\  ___   __ _   __| |  ___  _ __ ___   _   _ ", ConsoleColor.White, 333);
            Util.Print("|    \\ | | | || | | || '_ \\  / _` || || |   |  _  | / __| / _` | / _` | / _ \\| '_ ` _ \\ | | | |", ConsoleColor.White, 333);
            Util.Print("| |\\  \\| |_| || |_| || | | || (_| || || |   | | | || (__ | (_| || (_| ||  __/| | | | | || |_| |", ConsoleColor.White, 333);
            Util.Print("\\_| \\_/ \\__, | \\__,_||_| |_| \\__, ||_||_|   \\_| |_/ \\___| \\__,_| \\__,_| \\___||_| |_| |_| \\__, |", ConsoleColor.White, 333);
            Util.Print("         __/ |                __/ |                                                       __/ |", ConsoleColor.White, 333);
            Util.Print("        |___/                |___/                                                       |___/ ", ConsoleColor.White, 1320);
            Console.WriteLine();
            Console.WriteLine();
            Util.Print("\'경일게임아카데미\'였다.", ConsoleColor.White, 333);
            Console.WriteLine();
            Console.WriteLine("탈출하려면 아무키나 누르세요...");
        }

        public override void Input()
        {
            Console.ReadKey(true); //2차 버그 수정 -> 입력된 키가 콘솔 화면에서 안보이게 하기
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            Game.ChangeScene("Op"); //3차 버그 game.을 붙이지 않아서 문법 오류
        }
    }
}
