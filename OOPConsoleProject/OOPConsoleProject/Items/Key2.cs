using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Items
{
    public class Key2 : Item
    {
        public Key2(Vector2 position)
            : base(ConsoleColor.Yellow, 'N', position)
        {
            name = "재성의 방을 여는 열쇠";
            description = "울분하는 보노보노 키링이 달려있다. 재성의 방 문 앞에서 사용하자";
        }

        public override void Use()
        {
            
        }
    }
}

