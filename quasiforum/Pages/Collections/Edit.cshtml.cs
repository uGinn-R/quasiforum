using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using quasiforum.Services;
using quasiforum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Imagekit;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace quasiforum.Pages.Collections
{  
    public class EditModel : PageModel
    {
        private IForumRepository _repository;
        private UserManager<AppUser> _userManager;

        [BindProperty]
        public IFormFile Image { get; set; }

        [BindProperty]
        public Topic topic { get; set; }

        public EditModel(IForumRepository repository, UserManager<AppUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public IActionResult OnGet(int id)
        {
            if (id > 0) // Edit
                topic = _repository.GetTopicDetails(id);
            else // creating new instance
                
            topic = new Topic();

            return Page();
        }

        public IActionResult OnPostDelete()
        {
            _repository.DeleteTopic(topic.id);

            return RedirectToPage("Collections");
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                        var response = ImageUploader.UploadImage(Image);
                        if (response.StatusCode == 200) // OK
                        {
                        topic.imagePath = response.URL;
                        }
                }
                topic.TopicAuthorID = _userManager.GetUserId(User);
                if (topic.id > 0)
                {
                    topic = _repository.Update(topic);
                }
                else
                {
                    
                    topic.CreationDate = DateTime.Now;
                    topic = _repository.Add(topic);
                }

                    return RedirectToPage("/Collections/Collections");
            }
            return Page();
        }
    }
}
