using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using quasiforum.Models;
using quasiforum.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace quasiforum.Pages.UserProfile
{
    public class UserProfileModel : PageModel
    {
        private readonly IForumRepository _ForumRepository;
        private readonly UserManager<AppUser> _userManager;
        [BindProperty]
        public AppUser thisUser { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }
        public IEnumerable<Post> PostsList { get; set; }
        [BindProperty]
        public IEnumerable<Topic> TopicsList { get; set; }
        public Topic currentTopic { get; set; }
        public int count { get; set; }
        public bool isDarkTheme { get; set; }
        //public int colId { get; set; }

        public UserProfileModel(IForumRepository forumRepository, UserManager<AppUser> userManager)
        {
            _ForumRepository = forumRepository;
            _userManager = userManager;
        }
        public async Task<IActionResult> OnGet()
        {
            thisUser = await _userManager.GetUserAsync(User);

            if (thisUser == null)
            {
                return Redirect("/Index");
            }

            TopicsList = _ForumRepository.GetMyTopics(thisUser.Id);
            return Page();
        }

        public int GetItemsCount(Topic topic)
        {
            return _ForumRepository.GetAllTopicPosts(topic.id).Count();
        }
        
        public IActionResult OnPostDelete(int topicId)
        {
            _ForumRepository.DeleteTopic(topicId);

            return RedirectToPage("/UserProfile/UserProfile");
        }
        public async Task<IActionResult> OnPostUpdateUser(bool isDarkTheme, bool Language)
        {
            thisUser = await _userManager.GetUserAsync(User);

            if (Image != null)
            {
                var response = ImageUploader.UploadImage(Image);
                if (response.StatusCode == 200) // OK
                {
                    thisUser.AvatarImagePath = response.URL;
                }
            }
            thisUser.isDarkTheme = isDarkTheme;
            thisUser.Language = Language;
            
            await _userManager.UpdateAsync(thisUser);
            return RedirectToPage("/UserProfile/UserProfile");
        }
    }
}
