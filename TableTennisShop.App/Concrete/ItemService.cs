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
        public ItemService(string path)
        {
            Items = (List<Item>)ReadXml(path);
        }
        public Item UpdateItemDetails(Item item, string name, TypeOfItem typeId, LevelOfAdvancement levelId, int price)
        {
            item.Name = name;
            item.TypeId = typeId;
            item.LevelId = levelId;
            item.Price = price;
            return item;
        }
    }
}
