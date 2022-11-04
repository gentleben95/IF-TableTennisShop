using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using TableTennisShop.App.Common;
using TableTennisShop.Domain.Entity;
using TableTennisShop.Domain.Helpers;

namespace TableTennisShop.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
        public MenuActionService()
        {
            Initialize();
        }
        public List<MenuAction> GetMenuActionsByMenuName(string menuName) // Czemu lista Items jest i tutaj i dla itemów ze sklepu?
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Items)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }
        private void Initialize()
        {
            AddItem(new MenuAction(0, "Save and exit", "Main"));
            AddItem(new MenuAction(1, "Item service", "Main"));

            AddItem(new MenuAction(0, "Back", "ItemView"));
            AddItem(new MenuAction(1, "Show list of items", "ItemView"));
            AddItem(new MenuAction(2, "Show list of items by it's type", "ItemView"));
            AddItem(new MenuAction(3, "Show Details of item", "ItemView"));
            AddItem(new MenuAction(4, "Add item", "ItemView"));
            AddItem(new MenuAction(5, "Update item details", "ItemView"));
            AddItem(new MenuAction(6, "Remove item", "ItemView"));
            AddItem(new MenuAction(7, "Save changes", "ItemView"));

            AddItem(new MenuAction(1, $"{TypeOfItem.TableTennisRackets}", "TypeOfItemView"));
            AddItem(new MenuAction(2, $"{TypeOfItem.TableTennisBalls}", "TypeOfItemView"));
            AddItem(new MenuAction(3, $"{TypeOfItem.TennisTables}", "TypeOfItemView"));

            AddItem(new MenuAction(1, $"{LevelOfAdvancement.Beginner}", "LevelOfItemView"));
            AddItem(new MenuAction(2, $"{LevelOfAdvancement.Intermediate}", "LevelOfItemView"));
            AddItem(new MenuAction(3, $"{LevelOfAdvancement.Advanced}", "LevelOfItemView"));
            AddItem(new MenuAction(4, $"{LevelOfAdvancement.None}", "LevelOfItemView"));

        }
        
    }
           
}
