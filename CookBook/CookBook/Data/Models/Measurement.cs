﻿using System.ComponentModel.DataAnnotations;

namespace CookBook.Data.Models
    {
    public class Measurement
        {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        }
    }
