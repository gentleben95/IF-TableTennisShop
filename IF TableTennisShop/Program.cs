using IF_TableTennisShop.Model.Items;
using TableTennisShop.App.Concrete;
using TableTennisShop.Domain.Helpers;

namespace IF_TableTennisShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            ItemService itemService = new ItemService();

            Console.WriteLine("Welcome to TTExperts");
            MenuActionService menuActionService = MenuActionService.Initialize(actionService);
            actionService = menuActionService;
            
            bool mainMenuView = true;
            while (mainMenuView)
                {
                var mainMenu = actionService.GetMenuActionByMenuName("Main");
                foreach (var menu in mainMenu)
                {
                    Console.WriteLine($"{menu.Id}. {menu.Name}");
                }
                Console.Write("Choose action: ");
                var operation1 = Console.ReadLine();
                int.TryParse(operation1, out int operation);
                switch (operation)
                {
                    case 1:

                        var id = itemService.AddNewItem();
                        Console.Clear();
                        itemService.ListAllItems();
                        break;
                    case 2:
                        var removeId  = itemService.RemoveItemView();
                        itemService.RemoveItem(removeId);
                        Console.Clear();
                        break;
                    case 3:
                        var itemId = itemService.CheckInventoryView();
                        itemService.CheckInventory(itemId);
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        itemService.ListAllItems();
                        break;
                    case 5:
                        Console.Clear();
                        
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("\nSee you soon again!");
                        mainMenuView = false;
                        break;
                        
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }  
            }
        }
    }
}