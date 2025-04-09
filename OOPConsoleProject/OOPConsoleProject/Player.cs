namespace OOPConsoleProject
{
    public class Player
    {
        public Vector2 position;
        public bool[,] map;
        public Inventory inventory;


        public Player()
        { 
            inventory = new Inventory();
        }



        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }


        public void Move(ConsoleKey input)
        {
            Vector2 targetPos = position;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    targetPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    targetPos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    targetPos.x--;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    targetPos.x++;
                    break;
                    case ConsoleKey.I:
                    inventory.Open();
                    break;
            }
            if (map[targetPos.y, targetPos.x] == true)
            { 
                position = targetPos;
            }

        }
    }
}
