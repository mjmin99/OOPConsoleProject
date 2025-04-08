namespace OOPConsoleProject
{
    public class Util
    {
        //줄 바꿈 있는 글자 입력기
        public static void Print(string context, ConsoleColor textColor = ConsoleColor.White, int delay = 0) //ms임 1000=1초
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(context);
            Thread.Sleep(delay);
            Console.ResetColor();
        }
        //줄 바꿈 없는 글자 입력기
        public static void PrintNoLine(string context, ConsoleColor textColor = ConsoleColor.White, int delay = 0) //ms임 1000=1초
        {
            Console.ForegroundColor = textColor;
            Console.Write(context);
            Thread.Sleep(delay);
            Console.ResetColor();
        }
    }
}
