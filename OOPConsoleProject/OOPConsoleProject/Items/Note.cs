﻿using System;
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
            description = "세 마왕 정택과, 재성과 준헌... 그들의 방을 열 방법은 열쇠다.\n하지만 열쇠들은 각각 경일게임 아카데미의 모든 곳에세 마왕의 의해서 철저하게 숨겨졌다.단서를 찾고 단서를 토대로 열쇠를 찾아 세 마왕을 무찔러라.Tip : 열쇠는 작아서 보이지 않습니다.";
            isKey = false;

        }

        public override void Use()
        {
            
        }
    }
}
