﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_TableTennisShop.Model
{
    public class Item_TableTennisRacket
    {
        // Id
        // Nazwa modelu
        // Stopień zaawansowania
        // cena
        public int Id { get; set; }
        public string ModelName { get; set; }
        public StageOfAdvancement TypeId { get; set; }
        public int Price { get; set; }
    }
}
