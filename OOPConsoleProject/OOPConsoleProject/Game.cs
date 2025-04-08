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
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static bool gameOver;


        public static void Run()
        {
            Start(); // 초기설정 진행

            while (gameOver == false) //게임오버 될 때까지 반복
            { 
                Console.Clear();// 1차 버그 수정 -> 반복 시작될 때 콘솔 화면 클리어.
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }

            End(); // 마무리 작업
        }


        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }


        private static void Start() // 콘솔에서 필요한 작업들을 여기서 진행
        {
            gameOver = false;

            //씬 설정
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene()); //씬이 추가될때마다 아래에 추가할 것
            sceneDic.Add("Op", new OpScene());
            sceneDic.Add("Op2", new OpScene2());
            sceneDic.Add("Op2_1", new OpScene2_1());
            sceneDic.Add("Op2_2", new OpScene2_2());
            sceneDic.Add("KyungilGameAcademymainhall", new KyungilGameAcademymainhall());

            curScene = sceneDic["KyungilGameAcademymainhall"]; //첫 시작 타이틀
        }

        private static void End()
        { 
        
        }
    }
}
