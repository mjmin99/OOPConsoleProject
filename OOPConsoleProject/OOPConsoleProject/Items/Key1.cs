using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Items
{
    public class Key1 : Item
    {
        public Key1(Vector2 position)
            : base(ConsoleColor.Yellow, 'N', position)
        {
            name = "정택의 방을 여는 열쇠";
            description = "\"좋은아침이야~ 좋은아침이면~ 출석체크하자!\"라는 명언이 적혀있다... 정택의 방 문 앞에서 사용하자";
        }

        public override void Use()
        {
            
        }
    }
}
