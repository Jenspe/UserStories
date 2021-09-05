using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStories.Models;

namespace UserStories.MockData
{
    public class MockUserStories
    {
        private static List<UserStory> userStories = new List<UserStory>()
        {
            new UserStory("Create Story", "As P.O I want to create a new Story So ...",4,new DateTime(2021,08,30),4,"Small"),
            new UserStory("Edit Story", "As P.O I want to edit a Story So ...",3,new DateTime(2021,08,30),4,"Small"),
            new UserStory("Move Story", "As team member I want to move a Story So ...",2,new DateTime(2021,08,30),2,"Medium"),
            new UserStory("Delete Story", "As team member I want to delete a Story So ...",1,new DateTime(2021,08,30),1,"Small")
        };
        
        public static List<UserStory> GetMockUserStories()
        {
            return userStories; 
        }
    }
}
