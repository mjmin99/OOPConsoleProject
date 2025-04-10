using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.Scenes;

namespace OOPConsoleProject
{
    public static class Game
    {
        public static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        public static BaseScene CurScene { get { return curScene; } } // 질문 받아서 작성한 내용

        public static string prevSceneName;

        private static Player player;
        public static Player Player { get { return player; } }

        public static bool gameOver;

        public static bool[] isCleared = new bool[3];


        public static void Run()
        {
            Start(); // 초기설정 진행

            while (gameOver == false) //게임오버 될 때까지 반복
            { 
                Console.Clear();
                Console.SetCursorPosition(0,0);// 1차 버그 수정 -> 반복 시작될 때 콘솔 화면 클리어.
                Console.CursorVisible = false;
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }

            End(); // 마무리 작업
        }


        public static void ChangeScene(string sceneName)
        {
            prevSceneName = curScene.name;

            curScene.Exit();
            curScene = sceneDic[sceneName];
            curScene.Enter();
        }


        private static void Start() // 콘솔에서 필요한 작업들을 여기서 진행
        {
            gameOver = false;

            //플레이어 설정
            player = new Player();

            //씬 설정
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());   // 타이틀 시퀀스
            sceneDic.Add("Op", new OpScene());         // ━┓
            sceneDic.Add("Op2", new OpScene2());       //  ┃
            sceneDic.Add("Op2_1", new OpScene2_1());   //  ┣━ 오프닝 시퀀스
            sceneDic.Add("Op2_2", new OpScene2_2());   // ━┛
            sceneDic.Add("KyungilGameAcademymainhall", new KyungilGameAcademymainhall()); //메인홀  ━┓
            sceneDic.Add("KyungilGameAcademylobby", new KyungilGameAcademylobby()); //로비           ┃
            sceneDic.Add("Jeongtaeksroom", new Jeongtaeksroom()); //정택의 방                        ┃
            sceneDic.Add("Jaeseongsroom", new Jaeseongsroom()); //재성의 방                          ┃
            sceneDic.Add("JunheonsRoom", new JunheonsRoom()); //준헌의 방                 필드맵 씬 ━┫  
            sceneDic.Add("AllPublicAreas", new AllPublicAreas()); // 전체공지방                      ┃
            sceneDic.Add("AdministrativeOffice", new AdministrativeOffice()); //행정실               ┃
            sceneDic.Add("PlanningLectureRoom", new PlanningLectureRoom()); //기획강의실  ━━━━━━━━━━━┛
            sceneDic.Add("Talk_JT", new Talk_JT()); //정택과의 대화    ━━━━━━━━━━━━━━━━━━━━━━━━┓
            sceneDic.Add("Talk_JT_1", new Talk_JT_1()); //                                     ┃
            sceneDic.Add("Talk_JT_2", new Talk_JT_2());   //                                   ┃
            sceneDic.Add("Talk_JT_2_2", new Talk_JT_2_2()); //                       정택대화 ━┫
            sceneDic.Add("Talk_JT_2_2_3", new Talk_JT_2_2_3());//                              ┃
            sceneDic.Add("Talk_JT_e", new Talk_JT_e()); // 모든 문제 정답                      ┃
            sceneDic.Add("Talk_JT_2_x", new Talk_JT_2_x()); //문제 오답시 컷신  ━━━━━━━━━━━━━━━┛
            sceneDic.Add("Talk_JS", new Talk_JS()); //재성과의 대화
            sceneDic.Add("Talk_JS_1", new Talk_JS_1());
            sceneDic.Add("Talk_JS_2", new Talk_JS_2());
            sceneDic.Add("Talk_JS_e", new Talk_JS_e());
            sceneDic.Add("Talk_JS_x", new Talk_JS_x());
            sceneDic.Add("Talk_JH", new Talk_JH()); //준헌과의 대화
            sceneDic.Add("Talk_JH_1", new Talk_JH_1());
            sceneDic.Add("Talk_JH_2", new Talk_JH_2());
            sceneDic.Add("End", new End());
            sceneDic.Add("End_JT", new End_JT());
            sceneDic.Add("End_JH", new End_JH());
            sceneDic.Add("End1", new End1());
            sceneDic.Add("End2", new End2());



            curScene = sceneDic["Title"]; //첫 시작 타이틀


        }

        private static void End()
        {
            Console.Clear();
            Console.WriteLine("플레이 해주셔서 감사합니다.");
            Console.WriteLine();
            Console.WriteLine("제작자 : 민만준");
            Console.WriteLine();
            Console.WriteLine("기획 의도 : 어딘가를 탈출 한다는 건. 정말 홀가분한 마음으로 \n\n그곳을 탈출했어도 편한 마음으로 살아가는 것이 진정한 탈출이라고 생각했습니다.\n\n따라서 경일게임아카데미를 탈출한다는 건 열심히 배운 뒤 취업을 달성하는\n\n그런 총체적인 노력의 일환인셈입니다.\n\n이 글을 보는 저의 친구들, 전우, 동료분들 모두 \n\n각자 힘든 시간 이겨내고 \'탈출\'하셨으면 좋겠습니다.\n\n경일게임아카데미 화이팅");
        }
    }
}
