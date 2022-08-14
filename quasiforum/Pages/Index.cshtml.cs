using quasiforum.Models;
using quasiforum.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quasiforum.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IForumRepository _repository;
        private readonly UserManager<AppUser> _userManager;
        public Topic _collection = new Topic();
        public IEnumerable<Topic> AllTopics { get; set; }
        public IEnumerable<Post> LastPosts { get; set; }

        public Post _post = new Post();

        public string title { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IForumRepository ForumRepository, UserManager<AppUser> userManager)
        {
            _logger = logger;
            _repository = ForumRepository;
            _userManager = userManager;
        }

        public void OnGet()
        {
            LastPosts = GetLastAddedPosts();
            AllTopics = _repository.GetAllTopics();
        }
        public IEnumerable<Post> GetLastAddedPosts()
        {
            return _repository.GetAllPosts().Where(s => s.CreationDate > DateTime.Now.AddDays(-2));
        }
        public int GetItemsCount(Topic topic)
        {
            return _repository.GetAllTopicPosts(topic.id).Count();
        }
    }
}
