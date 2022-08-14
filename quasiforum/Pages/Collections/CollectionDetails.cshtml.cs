using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using quasiforum.Services;
using quasiforum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;

namespace quasiforum.Pages.Collections
{
    public class CollectionDetailsModel : PageModel
    {
        private readonly IForumRepository _ForumRepository;
        private readonly UserManager<AppUser> _usermanager;
        public AppUser thisUser { get; set; }
        public Post _Item { get; set; }

        public string thisUserId { get; set; }

        public CollectionDetailsModel(IForumRepository forumRepository, UserManager<AppUser> userManager)
        {
            _ForumRepository = forumRepository;
            _usermanager = userManager;
        }
        public Topic Topic { get; private set; }
        public IEnumerable<Post> items { get; set; }
        public IActionResult OnGet(int Id)
        {
            if (TempData["TopicIDYouCameFrom"] != null)
            {
                Id = (int)TempData["TopicIDYouCameFrom"];
            }
            Topic = _ForumRepository.GetTopicDetails(Id);
            items = _ForumRepository.GetAllTopicPosts(Id);
            thisUserId = _usermanager.GetUserId(User);

            if (Topic != null)
            {
                return Page();
            }
            else
                return RedirectToPage("/Index");
        }

        public IActionResult OnPostDelete(int ItemId)
        {
            _Item = _ForumRepository.GetPostDetails(ItemId);
            TempData["CollectionIDYouCameFrom"] = _Item.TopicId;
            _ForumRepository.DeleteItem(ItemId);

            return RedirectToPage("/Collections/CollectionDetails");
        }
    }
}
