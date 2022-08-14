using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace quasiforum.Models
{
    public class Topic
    {
        public int id { get; set; }

        [Required (ErrorMessage = "The 'Name' field can't be empty")]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string imagePath
        {
            get
            {
                return ImagePath ?? "/images/no-image.png";
            }
            set
            {
                this.ImagePath = value;
            }
        }
        public string ImagePath;
        public string TopicAuthorID { get; set; }
        public List<Post> Items { get; set; }
        public DateTime CreationDate { get; set; }

    }
}