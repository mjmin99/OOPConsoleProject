using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;
using OOPConsoleProject.Scenes;

namespace OOPConsoleProject.Items
{
    public class Key2 : Item
    {
        public Key2(Vector2 position)
            : base(ConsoleColor.Yellow, ' ', position)
        {
            name = "재성의 방을 여는 열쇠";
            description = "울분하는 보노보노 키링이 달려있다. 그리고 특이하게 \n아주 작은 글씨로 \"정리하면 좋은 점\"들이 정리되어있다...재성의 방으로 들어가는 포탈을 생성한다.\n ※ 플밍반에서만 사용할 수 있습니다.";
            isKey = true;
        }

        public override void Use()
        {
            if (Game.CurScene is FieldScene)
            {
                FieldScene fieldScene = (FieldScene)Game.CurScene;
                fieldScene.AddGameObject(new Place("Jaeseongsroom", 'O', new Vector2(55, 6))); // 질문 받아서 작성한 내용
            }
        }
    }
}

