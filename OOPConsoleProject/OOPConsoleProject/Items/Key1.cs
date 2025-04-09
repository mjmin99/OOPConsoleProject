using OOPConsoleProject.GameObjects;
using OOPConsoleProject.Scenes;

namespace OOPConsoleProject.Items
{
    public class Key1 : Item
    {
        public Key1(Vector2 position)
            : base(ConsoleColor.Yellow, ' ', position)
        {
            name = "정택의 방을 여는 열쇠";
            description = "\"좋은아침이야~ 좋은아침이면~ 출석체크하자!\"라는 명언이 적혀있다... 정택의 방으로 들어가는 포탈을 생성한다. \n ※ 플밍반에서만 사용할 수 있습니다.";
            isKey = true;
        }

        public override void Use()
        {
            //현재 게임씬에 포탈 추가하기
            if (Game.CurScene is FieldScene)
            {
                FieldScene fieldScene = (FieldScene)Game.CurScene;
                fieldScene.AddGameObject(new Place("Jeongtaeksroom", 'O', new Vector2(49, 6))); // 질문 받아서 작성한 내용
            }
        }
    }
}
