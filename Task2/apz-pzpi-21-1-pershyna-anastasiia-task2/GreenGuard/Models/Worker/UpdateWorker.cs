﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GreenGuard.Helpers;
using System.Text.Json.Serialization;

namespace GreenGuard.Models.Worker
{
    public class UpdateWorker
    {
        [Required]
        [Column("Worker_name")]
        public string WorkerName { get; set; }

        [Phone]
        [Column("Phone_number")]
        public string? PhoneNumber { get; set; }

        [EmailAddress]
        [Column("Email")]
        public string? Email { get; set; }

        [Column("Start_work_time")]
        [JsonConverter(typeof(JsonTimeOnlyConverter))]
        public TimeOnly? StartWorkTime { get; set; }

        [Column("End_work_time")]
        [JsonConverter(typeof(JsonTimeOnlyConverter))]
        public TimeOnly? EndWorkTime { get; set; }
    }
}