using IF_TableTennisShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_TableTennisShop.Services
{
    public class ItemService
    {
        List<Item_TableTennisRacket> ItemsTTRacket { get; set; }
        public ItemService()
        {
            ItemsTTRacket = new List<Item_TableTennisRacket>();
        }
        internal int AddNewItemView(MenuActionService actionService)
        {
            var addNewItemMenu = actionService.GetMenuActionByMenuName("AddNewItemMenu");
            Console.WriteLine("Select one of the following options: ");
            foreach (var menuAction in addNewItemMenu)
            {
                Console.WriteLine($"{menuAction.Id}. {menuAction.Name}");
            }
            var operation = int.Parse(Console.ReadLine());
            return operation;
        }
        public int AddNewItem(int itemType)
        {
            Item_TableTennisRacket itemTTRacket = new Item_TableTennisRacket();
            itemTTRacket.TypeId = (StageOfAdvancement)itemType;
            Console.WriteLine("Please enter id for new item: ");
            var id = Console.ReadLine();
            int.TryParse(id, out int itemId);
            Console.WriteLine("Please enter name of the item: ");
            var name = Console.ReadLine();

            itemTTRacket.Id = itemId;
            itemTTRacket.ModelName = name;
            ItemsTTRacket.Add(itemTTRacket);
            return itemId;
        }
        public void ListAllItems()
        {
            foreach (var item in ItemsTTRacket)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{item.Id}. {item.ModelName} || {item.TypeId}");
                Console.ResetColor();
            }
        }
        internal int RemoveItemView(MenuActionService actionService)
        {
            Console.Write("Enter item ID to be removed: ");
            var removeItem = Console.ReadKey();
            int.TryParse(removeItem.KeyChar.ToString(), out int id);
            return id;
        }

        internal void RemoveItem(int removeId)
        {
            Item_TableTennisRacket itemToRemove = new Item_TableTennisRacket();
            foreach (var item in ItemsTTRacket)
            {
                if (item.Id == removeId)
                {
                    itemToRemove = item;
                    break;
                }
            }
            ItemsTTRacket.Remove(itemToRemove);
        }
    }
}
