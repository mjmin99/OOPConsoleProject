﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public struct Vector2
    {
        public int x; 
        public int y;

        public Vector2(int x, int y)
        { 
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(Vector2 left, Vector2 right)
        {
            return left.x == right.x && left.y == right.y;
        }
        public static bool operator !=(Vector2 left, Vector2 right)
        {
            return left.x != right.x && left.y != right.y;
        }

        //==를 만들기 위해선 != 도 만들어줘야한다. 

        //static 으로 정의해야하고 operator 를 달아야한다.
    }
}
