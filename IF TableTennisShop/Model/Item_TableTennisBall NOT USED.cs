using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_TableTennisShop.Model
{
    public class Item_TableTennisBall
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public LevelOfAdvancement TypeId { get; set; }
        public int Price { get; set; }
    }
}
