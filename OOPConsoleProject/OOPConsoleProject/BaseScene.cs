using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public abstract class BaseScene
    {
        public string name;

        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Result();

        public virtual void Exit() { } // 이 함수가 필요없는 자식 클래스를 위해서 버츄얼로 만들었다.

        public virtual void Enter() { }
    }
}
