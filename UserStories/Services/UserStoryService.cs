using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStories.Models;
using UserStories.MockData;

namespace UserStories.Services
{
    public class UserStoryService
    {
        private List<UserStory> userStories;

        public UserStoryService()
        {
            userStories = MockUserStories.GetMockUserStories();
        }

        public List<UserStory> GetUserStories()
        {
            return userStories;
        }
        public UserStory GetUserStory(int id)
        {
            foreach (UserStory userStory in userStories)
            {
                if (userStory.Id == id)
                    return userStory;
            }
            return null;
        }
        public UserStory DeleteUserStory(int userstoryId)
        {
            UserStory userstoryToBeDeleted = null;
            foreach (UserStory us in userStories)
            {
                if (us.Id == userstoryId)
                {
                    userstoryToBeDeleted = us;
                    break;
                }
            }
            if (userstoryToBeDeleted != null)
            {
                userStories.Remove(userstoryToBeDeleted);
            }
            return userstoryToBeDeleted;
        }
        public void AddUserStory(UserStory userStory)
        {
            userStories.Add(userStory);
        }
    }
}
