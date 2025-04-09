using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPConsoleProject.GameObjects;

namespace OOPConsoleProject
{
    public class Inventory
    {
        private List<Item> items;
        public Inventory() 
        {
            items = new List<Item>();
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
    }
}
