using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace quasiforum.Models
{
    public class Post
    {
        public int id { get; set; }

        //[Required(ErrorMessage = "The 'Name' field can't be empty")]
        //[MaxLength(50)]
        //public string Name { get; set; }
        public string Description { get; set; }
        //public string imagePath 
        //{
        //    get 
        //    {
        //        return ImagePath ?? "/images/no-image.png";
        //    }
        //    set 
        //    {
        //        this.ImagePath = value;
        //    } 
        //}
        //public string ImagePath;
        public int TopicId { get; set; }
        public DateTime CreationDate { get; set; }      
        public Topic ParentTopic { get; set; }
        public string OwnerId { get; set; }
        //public List<Comment> ItemComments { get; set; }
    }
}
