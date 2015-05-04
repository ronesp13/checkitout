using System;
using System.Collections.Generic;

namespace ProjectCS.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal EstimatedCost { get; set; }
        public string CoverUrl { get; set; }
        public string CoverUrlSmall { get; set; }
        public bool IsPublic { get; set; }
        public virtual ICollection<ApplicationUser> Likes { get; set; }
        public virtual ICollection<ApplicationUser> Followers { get; set; } 
    }
}