﻿using CookBook.Infrastructures.Data.Models.Shared;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CookBook.Infrastructures.Data.Models.Food
    {
    public class FoodRecepie
        {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<IngredientFoodRecepie> IngredientsRecepies { get; set; } = new List<IngredientFoodRecepie>();

        public ICollection<FoodRecepiesUsers> RecepiesUsers { get; set; } = new List<FoodRecepiesUsers>();

        public ICollection<FavouriteFoodRecepiesUsers> FavouriteRecepiesUsers { get; set; } = new List<FavouriteFoodRecepiesUsers>();


        [Required]
        public DateTime DatePosted { get; set; }

        [Required]
        public ICollection<Step> Steps { get; set; } = new HashSet<Step>();

        [Required]
        public string Image { get; set; } = string.Empty;

        [Required]
        public int PrepTime { get; set; }

        public string Origen { get; set; } = string.Empty;

        [Required]
        public string Preparation { get; set; } = string.Empty;

        [Required]
        public string OwnerId { get; set; } = string.Empty;

        [ForeignKey(nameof(OwnerId))]
        public IdentityUser Owner { get; set; }

        [Required]
        public int TumbsUp { get; set; } = 0;

        [Required]
        public int CookTime { get; set; }

        public int Portions { get; set; }

        [Required]
        public int RecepieTypeId { get; set; }

        [ForeignKey(nameof(RecepieTypeId))]
        public RecepieType RecepieType { get; set; }

        public int Temperature { get; set; }

        [Required]
        public int TemperatureMeasurmentId { get; set; }

        [ForeignKey(nameof(TemperatureMeasurmentId))]
        public TemperatureMeasurment TemperatureMeasurment { get; set; }

        public int OvenTypeId { get; set; }

        public OvenType OvenType { get; set; }

        public DateTime LastTimeYouHadIt { get; set; }

        public bool IsPrivate { get; set; }
    }
    }