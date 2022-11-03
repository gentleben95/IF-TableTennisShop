using IF_TableTennisShop.Model.Items;
using TableTennisShop.App.Concrete;
using TableTennisShop.Domain.Helpers;
using TableTennisShop.App.Managers;
using TableTennisShop.App.Common;
using TableTennisShop.Domain.Entity;
using System.Xml.Serialization;

namespace IF_TableTennisShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            ItemService itemService = new ItemService(@"C:\Users\benia\Testing\TableTennisShop.xml");
            ItemManager itemManager = new ItemManager(itemService, actionService);
            BaseService<Item> baseService = new();

            while (true)
            {
                Console.Clear();
                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Welcome to Table Tennis Shop!\n");
                Console.ResetColor();
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }
                var chosenOption = Console.ReadKey().KeyChar;
                switch (chosenOption)
                {
                    case '0':
                        baseService.SaveXml(@"C:\Users\benia\Testing\TableTennisShop.xml");
                        Environment.Exit(0);
                        break;
                    case '1':
                        itemManager.SelectOptionInItemMenu();
                        break;
                    default:
                        Console.WriteLine("Try again");
                        break;
                }
                
            }
        }
    }
}