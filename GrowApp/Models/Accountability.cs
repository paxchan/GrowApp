﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrowApp.Models
{
    public class Accountability
    {
        [Key]
        [Required]
        public int accountability_id { get; set; }

        [ForeignKey("goal_id")]
        public int goal_id { get; set; }
        public Goal Goal { get; set; }

        [ForeignKey("friendship_id")]
        public int friendship_id { get; set; }
        public Friendship Friendship { get; set; }

        public string can_edit { get; set; }

        public string added_at { get; set; }
    }
}
