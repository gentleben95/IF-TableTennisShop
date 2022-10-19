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
    }
}
