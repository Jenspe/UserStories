using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserStories.Models
{
    public class UserStory
    {
        private static int nextId = 1;
        private int NextId { get { return nextId++; } }

        public int Id { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Max 25 tegn")]
        public string Title { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Max 50 tegn")]
        public string Description { get; set; }

        [Required]
        [Range(1,5)]
        public int BusinessValue { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        [Range(1, 5)]
        public int Priority { get; set; }
        public string StoryPoints { get; set; }

        public UserStory()
        {
            CreationDate = DateTime.Now;
            Id = NextId;
        }
        public UserStory(string title, string description, int businessValue, DateTime creationDate, int priority, string storyPoints)
        {
            Id = NextId;
            Title = title;
            Description = description;
            BusinessValue = businessValue;
            CreationDate = creationDate;
            Priority = priority;
            StoryPoints = storyPoints;
        }
    }
}
