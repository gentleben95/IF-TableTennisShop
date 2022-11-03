using System.Data;
using System.Reflection.Metadata;
using TableTennisShop.App.Concrete;
using TableTennisShop.Domain.Entity;
using TableTennisShop.Domain.Helpers;
using TableTennisShop.App.Common;

namespace TableTennisShop.App.Managers
{
    public class ItemManager
    {
        private readonly MenuActionService _actionService;
        private ItemService _itemService;
        BaseService<Item> baseService = new();
        public ItemManager(ItemService itemService, MenuActionService actionService)
        {
            _actionService = actionService;
            _itemService = itemService;
        }
        public void SelectOptionInItemMenu()
        {
            while (true)
            {
                Console.Clear();
                var itemsView = _actionService.GetMenuActionsByMenuName("ItemView");
                Console.WriteLine();
                for (int i = 0; i < itemsView.Count; i++)
                {
                    Console.WriteLine($"{itemsView[i].Id}. {itemsView[i].Name}"); 
                }
                var chosenOption = Console.ReadKey().KeyChar;
                switch (chosenOption)
                {
                    case '0':

                        break;
                    case '1': 
                        ItemsView(null, true);
                        GoToMenuView();
                        break;
                    case '2': 
                        var category = ChooseTypeOfItem();
                        ItemsView(category, true);
                        GoToMenuView();
                        break;
                    case '3':
                        ItemDetailsView();
                        GoToMenuView();
                        break;
                    case '4':
                        var id = AddNewItem();
                        break;
                    case '5':
                        var itemToUpdate = ItemDetailsView();
                        if (itemToUpdate != null)
                        {
                            AskUserAboutItemDetailsView(itemToUpdate);
                        }
                        GoToMenuView();
                        break;
                    case '6':
                        var idToRemove = ChooseItemView();
                        if (idToRemove != 0)
                        {
                            RemoveById(idToRemove);
                            Console.Clear();
                        }
                        GoToMenuView();
                        break;
                }
                break;
            }
        }

        public Item AskUserAboutItemDetailsView(Item item)
        {
            Console.Clear();
            Console.WriteLine("Type in item name: ");
            string name = Console.ReadLine();
            int type = ChooseTypeOfItem();
            int level = ChooseLevelOfAdvancement();
            Console.WriteLine("Enter the price in $: ");
            int loadedPrice = int.Parse(Console.ReadLine());

            _itemService.UpdateItemDetails(item, name, (TypeOfItem)type, (LevelOfAdvancement)level, loadedPrice);
            return item;
        }
        
        public void RemoveById(int id)
        {
            var itemToRemove = _itemService.GetItemById(id);
            if (itemToRemove != null)
            {
                _itemService.RemoveItem(itemToRemove);
            }
            else
            {
                Console.WriteLine("There is no item with this id!");
            }
        }
        private int AddNewItem()
        {
            var id = _itemService.GetLastId();
            Item itemToAdd = new Item() { Id = id + 1 };
            AskUserAboutItemDetailsView(itemToAdd);
            _itemService.AddItem(itemToAdd);
            return itemToAdd.Id;
        }
        private Item ItemDetailsView()
        {
            var idToDetail = ChooseItemView();
            Console.Clear();
            var itemToShow = _itemService.GetItemById(idToDetail);
            if (idToDetail != null)
            {
                ItemDetails(itemToShow);
            }
            return itemToShow;
        }
        private int ChooseTypeOfItem()
        {
            Console.Clear();
            int readInt;
            Console.WriteLine("Select the type of item: ");
            while (true)
            {
                var typeView = _actionService.GetMenuActionsByMenuName("TypeOfItemView");
                for (int i = 0; i < typeView.Count; i++)
                {
                    Console.WriteLine($"{typeView[i].Id}. {typeView[i].Name}");
                }
                readInt = int.Parse(Console.ReadLine());
                string readString = readInt.ToString();
                Console.Clear();
                break;
            }
            return readInt;
        }
        private int ChooseLevelOfAdvancement()
        {
                Console.Clear();
            int readInt;
                Console.WriteLine("Choose level of advancement: ");
            while (true)
            {
                var levelView = _actionService.GetMenuActionsByMenuName("LevelOfItemView");
                Console.WriteLine();
                for (int i = 0; i < levelView.Count; i++)
                {
                    Console.WriteLine($"{levelView[i].Id}. {levelView[i].Name}");
                }
                readInt = int.Parse(Console.ReadLine());
                string readString = readInt.ToString();
                break;
            }
            Console.Clear();
            return readInt;
        }
        
        private bool ItemsView(int? typeId, bool viewInMenu) 
        {
            List<Item> Items;
            if (viewInMenu)
            {
                Console.Clear();
            }
            if (typeId != null)
            {
                Items = _itemService.GetAllItems().Where(p => (int)p.TypeId == typeId).ToList(); 
            }
            else
            {
                Items = _itemService.GetAllItems();
            }
            if (Items.Any())
            {
                foreach (var item in Items)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{item.Id}. {item.Name} || {item.TypeId} || {item.LevelId}");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine($"There is no item in data base.");
                return false;

            }
            return true;
        }
        private int ChooseItemView()
        {
            Console.Clear();
            int id = 0;
            Console.WriteLine("Choose one of the following Item: ");
            if (ItemsView(null, false))

            {
                var tempId = Console.ReadLine();
                Int32.TryParse(tempId, out id);
            }
            return id;
        }
        private void GoToMenuView()
        {
            Console.WriteLine("Press any button to get back to previous menu");
            Console.ReadKey();
        }
        private void ItemDetails(Item item)
        {
            if (item == null) return;
            Console.WriteLine($"\nId: {item.Id}");
            Console.WriteLine($"Type: {item.TypeId}");
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"Level: {item.LevelId}");
            Console.WriteLine($"Price: {item.Price}");
        }
    }
}