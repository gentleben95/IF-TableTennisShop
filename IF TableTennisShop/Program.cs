using IF_TableTennisShop.Model;
using IF_TableTennisShop.Services;

namespace IF_TableTennisShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            ItemService itemService = new ItemService();
            Item_TableTennisRacket racketCategory = new();
            Item_TableTennisBall ballCategory = new();
            Item_TableTennisBall tableCategory = new();
            Console.WriteLine("Welcome to TTExperts");


            MenuActionService menuActionService = Initialize(actionService);
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
                var operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:

                        var id = itemService.AddNewItem();
                        Console.Clear();
                        break;
                    case 2:
                        var removeId  = itemService.RemoveItemView(actionService);
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

        public static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add item", "Main" );
            actionService.AddNewAction(2, "Remove item", "Main" );
            actionService.AddNewAction(3, "Check inventory", "Main" );
            actionService.AddNewAction(4, "Show list of items", "Main" );
            actionService.AddNewAction(5, "Show list of items by type Id", "Main" );
            actionService.AddNewAction(6, "Close the program", "Main" );

            actionService.AddNewAction(1, $"{LevelOfAdvancement.Beginner}", "AddNewItemMenu");
            actionService.AddNewAction(2, $"{LevelOfAdvancement.Intermediate}", "AddNewItemMenu");
            actionService.AddNewAction(3, $"{LevelOfAdvancement.Advanced}", "AddNewItemMenu");

            return actionService;
        }
    }
}