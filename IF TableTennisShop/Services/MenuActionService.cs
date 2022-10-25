using IF_TableTennisShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace IF_TableTennisShop.Services
{
    public class MenuActionService
    {
        public List<MenuAction> _menuActions; 
        public MenuActionService()
        {
            _menuActions = new List<MenuAction>(); 
        }
        
        public void AddNewAction(int id, string name, string menuName )
        {
            MenuAction menuAction = new MenuAction
            {
                Id = id,
                Name = name,
                MenuName = menuName,
            };
            _menuActions.Add(menuAction);
        }
        public List<MenuAction> GetMenuActionByMenuName(string menuName) // metoda do wyswietlania menu
        {
            List<MenuAction> menu = new List<MenuAction>();
            foreach (var menuAction in _menuActions)
            {
                if (menuAction.MenuName == menuName)
                {
                    menu.Add(menuAction);
                }
            }
            return menu;
        }

        internal void SelectCategoryOfItem(int itemCategory, string v2)
        {
            
        }
        public MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add item", "Main");
            actionService.AddNewAction(2, "Remove item", "Main");
            actionService.AddNewAction(3, "Check inventory", "Main");
            actionService.AddNewAction(4, "Show list of items", "Main");
            actionService.AddNewAction(5, "Show list of items by type Id", "Main");
            actionService.AddNewAction(6, "Close the program", "Main");

            actionService.AddNewAction(1, $"{LevelOfAdvancement.Beginner}", "AddNewItemMenu");
            actionService.AddNewAction(2, $"{LevelOfAdvancement.Intermediate}", "AddNewItemMenu");
            actionService.AddNewAction(3, $"{LevelOfAdvancement.Advanced}", "AddNewItemMenu");


            return actionService;
        }
    }
}
