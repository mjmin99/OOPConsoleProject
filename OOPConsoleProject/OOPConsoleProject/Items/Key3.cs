using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OOPConsoleProject.GameObjects;
using OOPConsoleProject.Scenes;

namespace OOPConsoleProject.Items
{
    public class Key3 : Item
    {
        public Key3(Vector2 position)
            : base(ConsoleColor.Yellow, 'N', position)
        {
            name = "준헌의 방을 여는 열쇠";
            description = "\"주말엔 좀 쉬자\"라는 글이 프랑스어로 적혀있다. 준헌의 방으로 들어가는 포탈을 생성한다.\n ※ 주의사항 만약... 플밍반이 아니라 다른 곳에서 사용했을 경우... 게임을 끝내지 못하게 된다.";
        }

        public override void Use()
        {
            if (Game.CurScene is FieldScene)
            {
                FieldScene fieldScene = (FieldScene)Game.CurScene;
                fieldScene.AddGameObject(new Place("JunheonsRoom", 'O', new Vector2(61, 6))); // 질문 받아서 작성한 내용
            }
        }
    }
}

