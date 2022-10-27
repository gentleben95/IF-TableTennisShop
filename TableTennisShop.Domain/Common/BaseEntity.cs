using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisShop.Domain.Helpers;

namespace TableTennisShop.Domain.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public LevelOfAdvancement TypeId { get; set; }
        public double Price { get; set; }
    }
}
