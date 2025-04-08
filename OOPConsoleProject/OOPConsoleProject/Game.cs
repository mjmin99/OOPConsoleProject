using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public static class Game
    {
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static bool gameOver;

        public static void Run()
        {
            while (gameOver == false)
            { 
                curScene.Render();
                curScene.Input();
                curScene.Update();
                curScene.Result();
            }
        }
    }
}
