using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class PlanningLectureRoom : BaseScene
    {
        private ConsoleKey input;
        public PlanningLectureRoom() 
        {
            name = "PlanningLectureRoom";
        }
        public override void Render()
        {

            Console.WriteLine();
            //Util.Print("X스를 한번도 못해본 사람은", ConsoleColor.Gray, 733);
            Util.PrintNoLine("현실에서", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 어떠한", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 경험을", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 해보지", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 않은", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 사람은", ConsoleColor.Gray, 433);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Util.Print("\"인지적 경험 부족\"", ConsoleColor.DarkYellow, 733);
            Console.WriteLine();
            Console.WriteLine();
            //Util.Print("때문에 꿈에서조차 X스를 하지 못한다는 이야기가 있다...", ConsoleColor.Gray, 733);
            Util.PrintNoLine("때문에", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 꿈에서조차", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 경험을", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 하지", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 못한다는", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 이야기가", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 있다...", ConsoleColor.Gray, 433);
            Console.WriteLine();
            Console.WriteLine();
            //Util.Print("모든 것을 상상만 할 뿐이지만. 기획반은 플밍반과는 다르게", ConsoleColor.Gray, 733);
            Util.PrintNoLine("모든", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 것을", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 상상만", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 할 뿐이지만.", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 기획반은", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 플밍반과는", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 다르게", ConsoleColor.Gray, 433);
            Console.WriteLine();
            Console.WriteLine();
            //Util.Print("모두가 조별과제때 해맑게 웃으며 따스한 인사를 건네고", ConsoleColor.Gray, 733);
            Util.PrintNoLine("모두가", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 조별과제때", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 해맑게", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 웃으며", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 따스한", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 인사를", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 건네고", ConsoleColor.Gray, 433);
            Console.WriteLine();
            Console.WriteLine();
            //Util.Print("일말의 삭막함은 찾아볼 수 조차 없으며", ConsoleColor.Gray, 733);
            Util.PrintNoLine("일말의", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 삭막함은", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 찾아볼", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 수 조차", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 없으며", ConsoleColor.Gray, 433);
            Console.WriteLine();
            Console.WriteLine();
            //Util.Print("배우는 즐거움이 가득한 배움으로 행복한 곳이 아닐까...", ConsoleColor.Gray, 733);
            Util.PrintNoLine("배우는", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 즐거움이", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 가득한", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 배움으로", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 무척이나", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 행복한", ConsoleColor.Magenta, 433);
            Util.PrintNoLine(" 곳이 아닐까?", ConsoleColor.Gray, 433);
            Console.WriteLine();
            Console.WriteLine();
            // Util.Print("착한일을 많이하면 다음 생에는 기획반에서 태어날 수 있을까...", ConsoleColor.Gray, 733);
            Util.PrintNoLine("착한일을", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 많이하면", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 다음", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 생에는", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 기획반에서", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 태어날", ConsoleColor.Gray, 433);
            Util.PrintNoLine(" 수 있을까...", ConsoleColor.Gray, 433);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Util.Print("(시덥잖은 감상을 모두 마쳤으면 아무키나 눌러서 계속)", ConsoleColor.DarkYellow, 733);
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
            Game.ChangeScene("KyungilGameAcademylobby");
        }
    }
}
