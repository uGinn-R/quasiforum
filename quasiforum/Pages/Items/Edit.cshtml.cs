using quasiforum.Models;
using quasiforum.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace quasiforum.Pages.Items
{
    public class EditModel : PageModel
    {
        private IForumRepository _repository;
        private UserManager<AppUser> _userManager;

        [BindProperty]
        public IFormFile Image { get; set; }
       
        [BindProperty]
        public int TopicId { get; set; }
        private Topic _topic { get; set; }

        [BindProperty]
        public Post post { get; set; }

        public EditModel(IForumRepository repository, UserManager<AppUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }
        public IActionResult OnGet(int id)
        {
            var currentUser = _userManager.GetUserId(User);
 
            if (id > 0)
            {
                post = _repository.GetPostDetails(id);
                TopicId = post.TopicId;
                _topic = _repository.GetTopicDetails(TopicId);
            }
            else // creating new instance
                
                post = new Post();

            return Page();
        }

        public IActionResult OnGetCreateItem(int id)
        {
            TopicId = id;
            _topic = _repository.GetTopicDetails(TopicId);
            //ItemOptions = _collection.GetItemOptions(_collection);
            post = new Post();
            //itemFields = item.GetOptionsValues(item);
            return Page();
        }
        public IActionResult OnPostDelete()
        {
            _repository.DeleteItem(post.id);

            return RedirectToPage("Collections");
        }

        public IActionResult OnPost()
        {
            _topic = _repository.GetTopicDetails(TopicId);

            if (ModelState.IsValid)
            {
                post.OwnerId = _userManager.GetUserId(User);
                if (post.id > 0) // edit
                {
                    post.TopicId = TopicId;
                    post = _repository.Update(post);
                }
                else // create
                {
                    post.TopicId = TopicId;
                    post.ParentTopic = _topic;
                    post.CreationDate = DateTime.Now;
                    post = _repository.Add(post);
                }

                return RedirectToPage("/Collections/CollectionDetails", new { id = TopicId });
            }
            return Page();
        }
    }
}
