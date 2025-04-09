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
            : base(ConsoleColor.Yellow, ' ', position)
        {
            name = "준헌의 방을 여는 열쇠";
            description = "\"주말엔 좀 쉬자\"라는 글이 프랑스어로 적혀있다. 준헌의 방으로 들어가는 포탈을 생성한다.\n ※ 플밍반에서만 사용할 수 있습니다.";
            isKey = true;
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

