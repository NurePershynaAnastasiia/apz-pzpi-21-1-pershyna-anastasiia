﻿using System.ComponentModel.DataAnnotations;

namespace GreenGuard.Models
{
    public class AddPlant
    {
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public required string PlantLocation { get; set; }

        public int PlantTypeId { get; set; }

        public float? Temp { get; set; }

        public float? Humidity { get; set; }

        public float? Light { get; set; }

        [StringLength(300)]
        public string? AdditionalInfo { get; set; }

        [Required]
        [StringLength(50)]
        public required string PlantState { get; set; }
    }
}