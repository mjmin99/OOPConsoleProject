using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JH : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
            if (Game.isCleared[2] == false)
            {
                Console.WriteLine("  /////\\\\\\\\\\\\   ");
                Console.WriteLine(" ///////\\\\\\\\\\\\  ");
                Console.WriteLine("//           \\\\                                  ━          ");
                Console.WriteLine("|--[o]---[o]--|                                                ");
                Console.WriteLine("|      ^    . |                    ━                           ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  /////\\\\\\\\\\\\   ");
                Console.WriteLine(" ///////\\\\\\\\\\\\  ");
                Console.WriteLine("//           \\\\                        ━         ━          ");
                Console.WriteLine("|--[-]---[-]--|            ㅈ                                  ");
                Console.WriteLine("|      ^    . |       ━            ━                  ━        ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  /////\\\\\\\\\\\\   ");
                Console.WriteLine(" ///////\\\\\\\\\\\\  ");
                Console.WriteLine("//           \\\\            ━           ━         ━          ");
                Console.WriteLine("|--[o]---[o]--|            ㅈ                 ㅈ               ");
                Console.WriteLine("|      ^    . |       ━            ━                  ━        ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  /////\\\\\\\\\\\\   ");
                Console.WriteLine(" ///////\\\\\\\\\\\\  ");
                Console.WriteLine("//           \\\\            ━    ━      ━         ━      ━  ");
                Console.WriteLine("|--[o]---[o]--|     ㅅ     ㅈ        ㅂ       ㅈ       ㅈ      ");
                Console.WriteLine("|      ^    . |       ━   ━        ━        ━         ━        ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  /////\\\\\\\\\\\\   ");
                Console.WriteLine(" ///////\\\\\\\\\\\\  ");
                Console.WriteLine("//           \\\\       ━    ━    ━      ━   ━     ━    ━ ━  ");
                Console.WriteLine("|--[-]---[-]--|     ㅅ  ㅇ ㅈ   ㅉ   ㅂㅈㅎ / ㅈㅇ :   저      ");
                Console.WriteLine("|      ^    . |       ━   ━   ━    ━    ━   ━    ━    ━  ━     ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  /////\\\\\\\\\\\\   ");
                Console.WriteLine(" ///////\\\\\\\\\\\\  ");
                Console.WriteLine("//           \\\\     ━ ━ ━  ━  ━ ━━     ━ ━ ━  ━  ━ ━ ━━ ━  ");
                Console.WriteLine("|--[o]---[o]--|     ㅅㅁ오 ㅈ ㅅㅉ : ㅂㅈ허 / ㅈㅇ : ㄷ저     ");
                Console.WriteLine("|      ^    . |   ┗   ━   ━━  ━ ━  ━ ━  ━ ━ ━ ━  ━  ━ ━  ━    ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  /////\\\\\\\\\\\\   ");
                Console.WriteLine(" ///////\\\\\\\\\\\\  ");
                Console.WriteLine("//           \\\\    ━━ ━ ━  ━  ━ ━━     ━ ━━━  ━  ━ ━ ━━ ━  ");
                Console.WriteLine("|--[o]---[o]--|     ㅅㅁ와 ㅈ 세ㅉ : 바ㅈ허 / ㅈㅇ : ㄷ적     ");
                Console.WriteLine("|      ^    . |   ┗   ━   ━━  ━━━  ━━━  ━━━ ━━━  ━━━━ ━  ━━┛   ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  /////\\\\\\\\\\\\   ");
                Console.WriteLine(" ///////\\\\\\\\\\\\  ");
                Console.WriteLine("//           \\\\   ┏━━ ━━━  ━━━━ ━━  ━━━━ ━━━  ━━━━ ━━━━   ━┓");
                Console.WriteLine("|--[-]---[-]--|   ┃ ㅅㅁ왕 ㅈ 세ㅉ : 박ㅈ헌 / ㅈ업 : ㄷ적     ");
                Console.WriteLine("|      ^    . |   ┗  ━━ ━━━━  ━━━  ━━━  ━━━ ━━━  ━━━━ ━  ━━┛   ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  /////\\\\\\\\\\\\   ");
                Console.WriteLine(" ///////\\\\\\\\\\\\  ");
                Console.WriteLine("//           \\\\   ┏━━ ━━━━━━━━━ ━━━━━━━━ ━━━━━━━━━ ━━━━━━━━┓");
                Console.WriteLine("|--[o]---[o]--|   ┃ 삼ㅁ왕 ㅈ 셋ㅉ : 박ㅈ헌 / ㅈ업 : ㄷ적  ┃   ");
                Console.WriteLine("|      ^    . |   ┗━━━━ ━━━━━━━━━ ━━━━━━━━━ ━━━━━━━━ ━━━━━━┛   ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  /////\\\\\\\\\\\\   ");
                Console.WriteLine(" ///////\\\\\\\\\\\\  ");
                Console.WriteLine("//           \\\\   ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine("|--[o]---[o]--|   ┃ 삼마왕 중 셋째 : 박준헌 / 직업 : 도적  ┃   ");
                Console.WriteLine("|      ^    . |   ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛   ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(1000);
                Console.WriteLine("반갑다 친구.. 내 이름은 준헌. 이 세계에서 제일 차가운 남자다");
                Console.WriteLine("하지만 학생과 형제들에게 만큼은 누구보다도 따듯하지...");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. 죄송합니다 강의실을 헷갈렸습니다.");
                Console.WriteLine("2. 박도적을 무찌른다.");
                Console.ResetColor();
            }
            else {
                Console.WriteLine("  /////\\\\\\\\\\\\   ");
                Console.WriteLine(" ///////\\\\\\\\\\\\  ");
                Console.WriteLine("//           \\\\ ");
                Console.WriteLine("|--[o]---[o]--|    ");
                Console.WriteLine("|      ^    . |    ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("이봐 친구... 자네는 여기서 멈춰있으면 안돼");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("해야할 일이 있잖아. 어서 다른 마왕을 해치우라고.. 힌트를 주자면");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("정택의 열쇠는 전체 공지실 왼쪽 학생 좌석어딘가에 있다는 모양이고..");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("재성의 열쇠는 플밍반 왼쪽 위 어딘가에 숨겨놨다고 해...");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("해야할 일이 생각나서 계속하려면 아무키나 눌러서 계속...");
                Console.ResetColor();
            }
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            if (Game.isCleared[2] == false)
            {
                switch (input)
                {
                    case ConsoleKey.D1:
                        Game.ChangeScene("Talk_JH_1");
                        break;
                    case ConsoleKey.D2:
                        Game.ChangeScene("Talk_JH_2");
                        break;
                }
            }
            else 
            {
                switch (input)
                {
                    default:
                        Game.ChangeScene("JunheonsRoom");
                        break;
                }
            }
        }

        public override void Result()
        {
            //Game.ChangeScene("KyungilGameAcademymainhall"); //자동이동기능
        }
    }
}
