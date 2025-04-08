using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject.Scenes
{
    public class TitleScene : BaseScene
    {
        public override void Render()
        {
            Console.WriteLine("어두운 곳에서 눈을 뜨니 이곳은 \'경일게임아카데미\'였다.");
            Console.WriteLine();
            Console.WriteLine("계속하려면 아무키나 누르세요...");
        }

        public override void Input()
        {
            Console.ReadKey(true); //2차 버그 수정 -> 입력된 키가 콘솔 화면에서 안보이게 하기
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
           
        }
    }
}
