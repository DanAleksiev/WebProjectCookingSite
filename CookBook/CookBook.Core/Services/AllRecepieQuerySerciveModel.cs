﻿using CookBook.Core.Enum;
using CookBook.Core.Models.Shared;

namespace CookBook.Core.Services
    {
    public class AllRecepieQuerySerciveModel
        {
        public int RecepiesPerPage { get; } = 5;
        public string? SearchTerm { get; set; }
        public SearchFieldsEnum Searching { get; set; }
        public SortingFieldsEnum Sorting { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int TotalRecepiesCount { get; set; }
        public IEnumerable<AllRecepieViewModel> Recepies { get; set; } = new List<AllRecepieViewModel>();
        }
    }
