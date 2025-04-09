using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Items
{
    public class Note2 : Item
    {
        public Note2(Vector2 position)
            : base(ConsoleColor.Yellow, 'N', position)
        {
            name = "재성의 열쇠를 찾는 힌트가 적힌 쪽지";
            description = "\n플밍반 제자리에서 시작\nfor(int i = 0; i > 4; i++)\n   {\n       ↑→;\n   }\nif(정택의 4월9일 점심 == 생선까스)\n   {\n       (←←←←)*2;\n   }\nelse\n   {\n       ↓↓←↓←↓↓→\n   }\nfor(int i = 0; i < 8; i++)\n   {\n       ←↑;\n   }\n\n(정말 짜증나게도 적어놨군...)";

            //↑↓←→
        }

        public override void Use()
        {
            
        }
    }
}
