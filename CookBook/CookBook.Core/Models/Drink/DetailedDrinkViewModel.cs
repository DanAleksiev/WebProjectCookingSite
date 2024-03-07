﻿using CookBook.Infrastructures.Data.Models.Drinks;
using CookBook.Infrastructures.Data.Models.Shared;

namespace CookBook.Core.Models.Drink

    {
    public class DetailedDrinkViewModel
        {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DatePosted { get; set; }
        public string Image { get; set; }
        public string Origen { get; set; }
        public int Cups { get; set; }
        public int TumbsUp { get; set; }
        public string Owner { get; set; }
        public string OwnerId { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public ICollection<DrinkStep> Steps { get; set; } = new List<DrinkStep>();
        }
    }