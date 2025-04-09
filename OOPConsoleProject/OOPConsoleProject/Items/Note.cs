using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Items
{
    public class Note : Item
    {
        public Note(Vector2 position)
            : base(ConsoleColor.Yellow, 'N', position)
        {
            name = "정보를 담은 쪽지";
            description = "세 마왕 정택과, 재성과 준헌... 그들의 방을 열 방법은 열쇠다.";


        }

        public override void Use()
        {
            
        }
    }
}
