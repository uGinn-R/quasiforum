using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace quasiforum.Models
{
    public class AppUser : IdentityUser
    {
        public IEnumerable<Topic> OwnTopics { get; set; }
        //public string AvatarImagePath { get; set; }
        public string AvatarImagePath
        {
            get
            {
                return _AvatarImagePath ?? "/images/no-image.png";
            }
            set
            {
                this._AvatarImagePath = value;
            }
        }
        public string _AvatarImagePath;

        public DateTime? Registered { get; set; }
        public bool isDarkTheme { get; set; }
        public bool Language { get; set; }
    }
}
