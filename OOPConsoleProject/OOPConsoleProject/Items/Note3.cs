using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Items
{
    public class Note3 : Item
    {
        public Note3(Vector2 position)
            : base(ConsoleColor.Yellow, 'N', position)
        {
            name = "준헌의 열쇠를 찾는 힌트가 적힌 쪽지";
            description = "준헌은 진유록 매니저와 친하다는 뒷배경이 있다...\nbool[3,8] UrockKeyPos;\nUrockKeyPos[2, 7] = true;";
            isKey = false;
        }

        public override void Use()
        {
            
        }
    }
}
