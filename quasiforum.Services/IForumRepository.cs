using System;
using System.Collections.Generic;
using System.Text;
using quasiforum.Models;

namespace quasiforum.Services
{
    public interface IForumRepository
    {
        IEnumerable<Topic> GetAllTopics();

        Topic GetTopicDetails(int Id);

        Topic Update(Topic updatedTopic);

        Topic Add(Topic newTopic);

        void DeleteTopic(int Id);

        Post Update(Post updatedPost);

        Post Add(Post newPost);

        IEnumerable<Post> GetAllPosts();

        IEnumerable<Post> GetAllTopicPosts(int Id);

        Post GetPostDetails(int Id);

        void DeleteItem(int Id);
        IEnumerable<Topic> GetMyTopics(string userId);

    }
}
