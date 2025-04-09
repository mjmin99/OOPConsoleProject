using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject
{
    public class Inventory
    {
        private List<Item> items;
        private Stack<string> stack;
        private int selectIndex;

        public Inventory() 
        {
            items = new List<Item>();
            stack = new Stack<string>();
        }
        public void Add(Item item)
        {
            items.Add(item);
        }

        public void Remove(Item item)
        { 
            items.Remove(item);
        }

        public void Remove(int index)
        { 
            items.RemoveAt(index);
        }

        public void UseItem(int index)
        {
            items[index].Use();
        }

        public void Open()
        {
            stack.Push("Menu");
            while (stack.Count > 0)
            {
                Console.Clear();
                switch (stack.Peek())
                {
                    case "Menu":        Menu(); break;
                    case "UseMenu":     UseMenu(); break;
                    case "InfoMenu":    InfoMenu(); break;
                    case "UseConfirm":  UseConfirm(); break;
                    case "InfoConfirm": InfoConfirm(); break;
                 }
            }
        }

        private void Menu()
        { 
            PrintALL();
            Console.WriteLine("1. 사용하기");
            Console.WriteLine("2. 살펴보기");
            Console.WriteLine("0. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    stack.Push("UseMenu");
                    break;
                case ConsoleKey.D2:
                    stack.Push("InfoMenu");
                    break;
                case ConsoleKey.D0:
                    stack.Pop();
                    break;
            }
        }

        private void UseMenu()
        {
            PrintALL();
            Console.WriteLine("사용할 아이템을 선택해주세요");
            Console.WriteLine("뒤로가기는 0");
            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1;
                if (select < 0 || items.Count <= select)
                {
                    Console.WriteLine("범위 내의 아이템을 선택하세요.");
                }
                else
                {
                    selectIndex = select;
                    stack.Push("UseConfirm");
                }
            }
        }

        private void UseConfirm()
        {
            Item selectItem = items[selectIndex];
            Console.WriteLine("{0} 을/를 사용하시겠습니까? (y/n)", selectItem.name);

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    selectItem.Use();
                    Console.WriteLine("{0} 을/를 사용했습니다.", selectItem.name);
                    Remove(selectItem);
                    stack.Pop();
                    break;
                case ConsoleKey.N:
                    stack.Pop();
                    break;
            
            }
        
        }

        private void InfoMenu()
        {
            PrintALL();
            Console.WriteLine("살펴볼 아이템을 선택해주세요");
            Console.WriteLine("뒤로가기는 0");
            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1;
                if (select < 0 || items.Count <= select)
                {
                    Console.WriteLine("범위 내의 아이템을 선택하세요.");
                }
                else
                {
                    selectIndex = select;
                    stack.Push("InfoConfirm");
                }
            }
        }

        private void InfoConfirm()
        {
            Item selectItem = items[selectIndex];
            Console.WriteLine($"아이템 이름{selectItem.name}");
            Console.WriteLine($"아이템 설명{selectItem.description}");
            Console.WriteLine("0. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D0:
                    stack.Pop();
                    break;
            }
        }


        public void PrintALL()
        {
            Console.WriteLine("======소유한 아이템======");
            if (items.Count == 0)
            {
                Console.WriteLine("없음");
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, items[i].name);
            }
            Console.WriteLine("=========================");
        }
    }
}
