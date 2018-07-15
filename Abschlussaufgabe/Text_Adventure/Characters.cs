using System;
using System.Collections.Generic;

namespace Text_Adventure
{



    class Character
    {
        //Int
        public int Char_HP_Current = 100;
        public int Char_HP_Full = 100;
        private List<Item> inventory;
        public string name;
        private bool fightable;
        private bool needsItem;
        private string description;
        public string weapon;


        public Character()
        {
            // Blank out the title and description at start
            name = "";
            fightable = true;
            inventory = new List<Item>();
            weapon = "";
        }

        public Character(string _name, bool canFight, bool neededItem, string _description)
        {
            name = _name;
            fightable = canFight;
            needsItem = neededItem;
            description = _description;
        }

        public Character(string _name, bool canFight, string _description)
        {
            name = _name;
            fightable = canFight;
            description = _description;
        }

        public string Name
        {
            get { return name; }
        }

        public bool Fightable
        {
            get { return fightable; }
        }

        public string Description
        {
            get { return description; }
        }


         public List<Item> getInventory()
        {
            return new List<Item>(inventory);
        }

        public void addItem(Item itemToAdd)
        {
            inventory.Add(itemToAdd);
        }

        public void removeItem(Item itemToRemove)
        {
            if (inventory.Contains(itemToRemove))
            {
                inventory.Remove(itemToRemove);
            }
        }

        public Item takeItem(string name)
        {
            foreach (Item _item in inventory)
            {
                if (_item.Name.ToLower() == name)
                {
                    Item temp = _item;
                    inventory.Remove(temp);
                    return temp;
                }
            }

            return null;
        }

        public void showInventory()
        {
            if (inventory.Count > 0)
            {
                Console.WriteLine("\nA quick look in your bag reveals the following:\n");

                foreach (Item item in inventory)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                Console.WriteLine("\nYour bag is empty.\n");
            }
        }

    }


}
