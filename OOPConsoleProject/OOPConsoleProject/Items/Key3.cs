using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Items
{
    public class Key3 : Item
    {
        public Key3(Vector2 position)
            : base(ConsoleColor.Yellow, 'N', position)
        {
            name = "준헌의 방을 여는 열쇠";
            description = "\"주말엔 좀 쉬자\"라는 글이 프랑스어로 적혀있다. 준헌의 방 문 앞에서 사용하자";
        }

        public override void Use()
        {

        }
    }
}

