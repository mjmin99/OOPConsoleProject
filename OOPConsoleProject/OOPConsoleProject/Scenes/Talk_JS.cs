using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    class Talk_JS : BaseScene
    {
        private ConsoleKey input;
        public override void Render()
        {
                Console.WriteLine("  @@@@@\\/@@@   ");
                Console.WriteLine(" @@@@@3   3@@@  ");
                Console.WriteLine(" ;           :                                              ");
                Console.WriteLine("|   (o) (o)   |                                             ");
                Console.WriteLine("|      ^      |                                             ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@\\/@@@   ");
                Console.WriteLine(" @@@@@3   3@@@  ");
                Console.WriteLine(" ;           :                        ━━                    ");
                Console.WriteLine("|   (-) (-)   |                      이재                   ");
                Console.WriteLine("|      ^      |                       ━━                    ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@\\/@@@   ");
                Console.WriteLine(" @@@@@3   3@@@  ");
                Console.WriteLine(" ;           :                       ━━━━                   ");
                Console.WriteLine("|   (o) (o)   |                      이재                   ");
                Console.WriteLine("|      ^      |                      ━━━━                   ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@\\/@@@   ");
                Console.WriteLine(" @@@@@3   3@@@  ");
                Console.WriteLine(" ;           :                    ━━━━━━━━━━                ");
                Console.WriteLine("|   (O) (O)   |                    : 이재성                 ");
                Console.WriteLine("|      ^      |                   ━━━━━━━━━━                ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@\\/@@@   ");
                Console.WriteLine(" @@@@@3   3@@@  ");
                Console.WriteLine(" ;           :                 ━━━━━━━━━━━━━━━━             ");
                Console.WriteLine("|   (o) (o)   |               둘째 : 이재성 /               ");
                Console.WriteLine("|      ^      |                ━━━━━━━━━━━━━━━━             ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@\\/@@@   ");
                Console.WriteLine(" @@@@@3   3@@@  ");
                Console.WriteLine(" ;           :              ━━━━━━━━━━━━━━━━━━━━━━          ");
                Console.WriteLine("|   (-) (-)   |            중 둘째 : 이재성 / 직업          ");
                Console.WriteLine("|      ^      |             ━━━━━━━━━━━━━━━━━━━━━━          ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@\\/@@@   ");
                Console.WriteLine(" @@@@@3   3@@@  ");
                Console.WriteLine(" ;           :           ━━━━━━━━━━━━━━━━━━━━━━━━━━━━       ");
                Console.WriteLine("|   (o) (o)   |         왕 중 둘째 : 이재성 / 직업 :        ");
                Console.WriteLine("|      ^      |          ━━━━━━━━━━━━━━━━━━━━━━━━━━━━       ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@\\/@@@   ");
                Console.WriteLine(" @@@@@3   3@@@  ");
                Console.WriteLine(" ;           :        ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━    ");
                Console.WriteLine("|   (o) (o)   |       마왕 중 둘째 : 이재성 / 직업 : 궁     ");
                Console.WriteLine("|      ^      |       ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━    ");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@\\/@@@   ");
                Console.WriteLine(" @@@@@3   3@@@  ");
                Console.WriteLine(" ;           :    ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine("|   (-) (-)   |     삼마왕 중 둘째 : 이재성 / 직업 : 궁수   ");
                Console.WriteLine("|      ^      |   ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine("  @@@@@\\/@@@   ");
                Console.WriteLine(" @@@@@3   3@@@  ");
                Console.WriteLine(" ;           :    ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine("|   (o) (o)   |   ┃ 삼마왕 중 둘째 : 이재성 / 직업 : 궁수  ┃");
                Console.WriteLine("|      ^      |   ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                Console.WriteLine("|    [___]    | ");
                Console.WriteLine(" \\___________/ ");
                Thread.Sleep(1000);
                Console.WriteLine("이번에 들어온 풋내기가 \'너\'인가? 하지만 여기까지 왔다면");
                Console.WriteLine("if문과 for문을 완벽하게 이해하고 있다는 뜻이겠지... 칭찬해주마");
                Console.WriteLine("너라면 날 더 즐겁게 해 줄지도 모르겠군...");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. 죄송합니다 \'정말로\' 강의실을 헷갈린 것 같습니다.");
                Console.WriteLine("2. 이궁수를 무찌른다.");
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
                switch (input)
                {
                    case ConsoleKey.D1:
                        Game.ChangeScene("Talk_JS_1");
                        break;
                    case ConsoleKey.D2:
                        Game.ChangeScene("Talk_JS_2");
                        break;
                }
        }

        public override void Result()
        {
            //Game.ChangeScene("KyungilGameAcademymainhall");
        }
    }
}
