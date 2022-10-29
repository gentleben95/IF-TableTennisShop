using IF_TableTennisShop.Model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisShop.App.Common;
using TableTennisShop.Domain.Entity;
using TableTennisShop.Domain.Helpers;

namespace TableTennisShop.App.Concrete
{
    public class ItemService : BaseService<Item>
    {
        public ItemService()
        {
            // Add read file from xml
        }
        public Item UpdateItemDetails(Item item, string name, TypeOfItem typeId, LevelOfAdvancement levelId)
        {
            item.Name = name;
            item.TypeId = typeId;
            item.LevelId = levelId;
            return item;
        }
        /*
        List<Item_TableTennisRacket> ItemsTtRacket = new List<Item_TableTennisRacket>();

        public int AddNewItem()
        {
            MenuActionService actionService = new MenuActionService();

            Item_TableTennisRacket itemTTRacket = new Item_TableTennisRacket();
            Console.Write("Please enter id for new item: ");
            var id = Console.ReadLine();
            int.TryParse(id, out int itemId);
            Console.Write("Please enter name of the item: ");
            var name = Console.ReadLine();
            Console.WriteLine("----------");
            Console.WriteLine("Level of advancement: ");
            var addNewItemMenu = actionService.GetMenuActionByMenuName("AddNewItemMenu");
            foreach (var menuAction in addNewItemMenu)
            {
                Console.WriteLine($"{menuAction.Id}. {menuAction.Name}");
            }
            Console.WriteLine("----------");
            Console.Write("Choose level of advancement: ");
            var typeIdRead = Console.ReadLine();
            int.TryParse(typeIdRead, out int typeId);
            itemTTRacket.TypeId = (LevelOfAdvancement)typeId;

            Console.Write("Please enter the price of the item: ");
            var priceRead = Console.ReadLine();
            double.TryParse(priceRead, out double price);

            itemTTRacket.Id = itemId;
            itemTTRacket.ModelName = name;
            itemTTRacket.Price = price;
            ItemsTtRacket.Add(itemTTRacket);
            return itemId;
        }
        public void ListAllItems()
        {
            foreach (var item in ItemsTtRacket)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("List of items: ");
                Console.WriteLine($"{item.Id}. {item.ModelName} || {item.TypeId} || {item.Price}");
                Console.WriteLine("------------------------------");
                Console.ResetColor();
            }
        }
        public int RemoveItemView()
        {
            Console.Write("Enter item ID to be removed: ");
            var removeItem = Console.ReadKey();
            int.TryParse(removeItem.KeyChar.ToString(), out int id);
            return id;
        }

        public void RemoveItem(int removeId)
        {
            Item_TableTennisRacket itemToRemove = new Item_TableTennisRacket();
            foreach (var item in ItemsTtRacket)
            {
                if (item.Id == removeId)
                {
                    itemToRemove = item;
                    break;
                }
            }
            ItemsTtRacket.Remove(itemToRemove);
        }

        public int CheckInventoryView()
        {
            Console.WriteLine("Please enter id of item you wish to check: ");
            var itemId = Console.ReadLine();
            int.TryParse(itemId, out int id);
            return id;
        }

        public void CheckInventory(int itemId)
        {
            Item_TableTennisRacket itemToCheck = new Item_TableTennisRacket();
            foreach (var item in ItemsTtRacket)
            {
                if (item.Id == itemId)
                {
                    itemToCheck = item;
                    break;
                }
                Console.WriteLine($"Racket ID: {itemToCheck.Id}. ");
                Console.WriteLine($"Model name: {itemToCheck.ModelName}");
                Console.WriteLine($"Stage of advancement: {itemToCheck.TypeId}.");
                Console.WriteLine($"Price: {itemToCheck.Price}$.");
            }
        }
        */
    }
}
