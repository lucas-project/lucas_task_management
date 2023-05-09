﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyKanbanApp.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        public string ?Name { get; set; }

        public virtual ICollection<User> ?Users { get; set; }
    }
}
