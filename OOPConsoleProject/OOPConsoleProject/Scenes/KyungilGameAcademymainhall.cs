using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;
using OOPConsoleProject.Items;

namespace OOPConsoleProject.Scenes
{
    public class KyungilGameAcademymainhall : FieldScene
    {

        public KyungilGameAcademymainhall()
        {
            name = "KyungilGameAcademymainhall";
            mapData = new string[]
            {
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒                      ▒                   ▒                       ▒",
                "▒                      ▒                   ▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒",
                "▒                      ▒                   ▒  ▒     ▒     ▒     ▒  ▒",
                "▒                      ▒                   ▒  ▒     ▒     ▒     ▒  ▒",
                "▒▒▒▒▒▒▒▒▒▒▒▒           ▒▒▒▒             ▒▒▒▒  ▒  ▒  ▒  ▒  ▒  ▒  ▒  ▒",
                "▒                         ▒             ▒     ▒▒▒ ▒▒▒▒▒ ▒▒▒▒▒ ▒▒▒  ▒",
                "▒                         ▒▒▒▒▒▒   ▒▒▒▒▒▒                          ▒",
                "▒                                                                  ▒",
                "▒                                                                  ▒",
                "▒   ▒   ▒   ▒                                       ▒    ▒    ▒    ▒",
                "▒                                                                  ▒",
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒                                                                  ▒",
                "▒           ▒▒▒▒                ▒▒▒▒                ▒▒▒▒           ▒",
                "▒                                                                  ▒",
                "▒           ▒▒▒▒                ▒▒▒▒                ▒▒▒▒           ▒",
                "▒                                                                  ▒",
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
            };

            map = new bool[19, 68];
            for (int y = 0; y < map.GetLength(0) ; y++)
            {
                for (int x = 0; x < map.GetLength(1) ; x++)
                {
                    map[y, x] = mapData[y][x] == '▒' ? false : true;
                }
            } 

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("Jeongtaeksroom", 'O', new Vector2(49, 6))); //디버그용 정택 포탈 생성
            gameObjects.Add(new Place("Jaeseongsroom", 'O', new Vector2(55, 6))); //디버그용 재성 포탈 생성
            gameObjects.Add(new Place("JunheonsRoom", 'O', new Vector2(61, 6))); //디버그용 준헌 포탈 생성
            gameObjects.Add(new Place("KyungilGameAcademylobby", 'O', new Vector2(29, 8)));
            gameObjects.Add(new Place("KyungilGameAcademylobby", 'O', new Vector2(30, 8)));
            gameObjects.Add(new Place("KyungilGameAcademylobby", 'O', new Vector2(36, 8)));
            gameObjects.Add(new Place("KyungilGameAcademylobby", 'O', new Vector2(37, 8)));

            gameObjects.Add(new Note(new Vector2(32, 10))); //아이템
            
            gameObjects.Add(new Key2(new Vector2(17, 2))); //재성키 / 셋팅 끝

            

            gameObjects.Add(new Note3(new Vector2(53, 15))); //준헌쪽지
            //<-새로운게 추가된다면 이 줄에 적어야함

        }

        public override void Enter()
        {
            if ((Game.prevSceneName == "Op2_1") || (Game.prevSceneName == "Op2_2"))
            {
                Game.Player.position = new Vector2(33, 10);
            }
            else if (Game.prevSceneName == "Jeongtaeksroom") // 정택의 방
            {
                Game.Player.position = new Vector2(49, 7);
            }
            else if (Game.prevSceneName == "Jaeseongsroom") //재성의 방
            {
                Game.Player.position = new Vector2(56, 7);
            }
            else if (Game.prevSceneName == "JunheonsRoom") //준헌의 방
            {
                Game.Player.position = new Vector2(61, 7);
            }
            else
            {   
                Game.Player.position = new Vector2(33, 10); //아무데에서도 진입하지 못했을때 디버깅용
            }
                Game.Player.map = map;
            
        }

    }
}
