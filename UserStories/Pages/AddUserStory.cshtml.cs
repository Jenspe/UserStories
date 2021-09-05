using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStories.Models;
using UserStories.Services;

namespace UserStories.Pages
{
    public class AddUserStoryModel : PageModel
    {
        [BindProperty]
        public UserStory userStory { get; set; }
        public List<UserStory> userStories { get; set; }
        private UserStoryService userStoryService;
        public AddUserStoryModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            userStoryService.AddUserStory(userStory);
            return RedirectToPage("UserStories");
        }
    }
}
