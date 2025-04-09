using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject.Scenes
{
    public class JunheonsRoom : FieldScene
    {

        public JunheonsRoom()
        {
            name = "JunheonsRoom";
            mapData = new string[]
               {
                "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒",
                "▒                   ▒",
                "▒                   ▒",
                "▒                   ▒",
                "▒                   ▒",
                "▒                   ▒",
                "▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒",
               };

            map = new bool[7, 21];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '▒' ? false : true;
                }
            }

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Place("KyungilGameAcademymainhall", 'O', new Vector2(10, 6)));
            gameObjects.Add(new Place("Talk_JH", 'H', new Vector2(10, 2)));

        }
        public override void Enter()
        {
            Game.Player.position = new Vector2(10, 5);
            Game.Player.map = map;
        }
    }
}
