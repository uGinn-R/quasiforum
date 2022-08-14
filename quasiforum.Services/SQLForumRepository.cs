using quasiforum.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quasiforum.Services
{
    public class SQLForumRepository : IForumRepository
    {
        private readonly AppDbContext _context;
        public SQLForumRepository(AppDbContext context)
        {
            _context = context;
        }
        public Topic Add(Topic newCollection)
        {
            _context.Topics.Add(newCollection);
            _context.SaveChanges();
            return newCollection;
        }

        public Post Add(Post newItem)
        {
            _context.Posts.Add(newItem);
            _context.SaveChanges();
            return newItem;
        }

        public void DeleteTopic(int Id)
        {
           var toDelete = _context.Topics.Find(Id);
            if (toDelete != null)
            {
                _context.Topics.Remove(toDelete);
                _context.SaveChanges();
            }
        }

        public void DeleteItem(int Id)
        {
            var toDelete = _context.Posts.Find(Id);
            if (toDelete != null)
            {
                _context.Posts.Remove(toDelete);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Topic> GetAllTopics()
        {
            if (_context.Topics.CountAsync().Result == 0)
            {
                _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Topics', RESEED)"); // reset id counter
            }
            return _context.Topics;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            if (_context.Posts.CountAsync().Result == 0)
            {
                _context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Posts', RESEED)"); // reset id counter
            }
            return _context.Posts;
        }

        public Topic GetTopicDetails(int Id)
        {
            return _context.Topics.Find(Id);
        }

        public Post GetPostDetails(int Id)
        {
            return _context.Posts.Where(s => s.id == Id).FirstOrDefault();
        }

        public Topic Update(Topic updatedTopic)
        {
            var collection = _context.Topics.Attach(updatedTopic);
            collection.State = EntityState.Modified;
            _context.SaveChanges();
            return updatedTopic;
        }

        public Post Update(Post updatedPost)
        {
            var item = _context.Posts.Attach(updatedPost);
            item.State = EntityState.Modified;
            _context.SaveChanges();
            return updatedPost;
        }

        public IEnumerable<Post> GetAllTopicPosts(int Id)
        {
            return  _context.Posts.Where(s => s.ParentTopic.id == Id).OrderBy(x=>x.CreationDate).ToList();
        }

        public IEnumerable<Topic> GetMyTopics(string userId)
        {
            return _context.Topics.Where(s => s.TopicAuthorID == userId).ToList();
        }

    }
}
