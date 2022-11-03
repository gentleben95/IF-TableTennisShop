using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisShop.Domain.Common;
using TableTennisShop.Domain.Helpers;

namespace TableTennisShop.Domain.Entity
{
    public class Item : BaseEntity
    {
        public TypeOfItem TypeId { get; set; }
        public string Name { get; set; }
        public LevelOfAdvancement LevelId { get; set; }
        public double Price { get; set; }
    }
}
