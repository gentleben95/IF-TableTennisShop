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
        public TypeOfItem TypeId { get; set; }
        public string Name { get; set; }
        public LevelOfAdvancement LevelId { get; set; }
        
        public double Price { get; set; }
    }
}
