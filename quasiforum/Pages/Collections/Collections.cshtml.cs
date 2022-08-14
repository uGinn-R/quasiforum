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
    public class CollectionsModel : PageModel
    {
        private readonly IForumRepository _db;
        private readonly UserManager<AppUser> _userManager;
        public CollectionsModel(IForumRepository db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public IEnumerable<Topic> collection { get; set; }
        public void OnGet()
        {

                collection = _db.GetAllTopics();

        }
        public int GetItemsCount(Topic collection)
        {
            return _db.GetAllTopicPosts(collection.id).Count();
        }

        public IActionResult OnPostDelete(int topicId)
        {
            _db.DeleteTopic(topicId);

            return RedirectToPage("/Collections/Collections");
        }

    }
}
